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
	[Register("MTL4MeshRenderPipelineDescriptor", true)]
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	public unsafe partial class MTL4MeshRenderPipelineDescriptor : MTL4PipelineDescriptor {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlphaToCoverageStateX = "alphaToCoverageState";
		static readonly NativeHandle selAlphaToCoverageStateXHandle = Selector.GetHandle ("alphaToCoverageState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAlphaToOneStateX = "alphaToOneState";
		static readonly NativeHandle selAlphaToOneStateXHandle = Selector.GetHandle ("alphaToOneState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorAttachmentMappingStateX = "colorAttachmentMappingState";
		static readonly NativeHandle selColorAttachmentMappingStateXHandle = Selector.GetHandle ("colorAttachmentMappingState");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selColorAttachmentsX = "colorAttachments";
		static readonly NativeHandle selColorAttachmentsXHandle = Selector.GetHandle ("colorAttachments");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFragmentFunctionDescriptorX = "fragmentFunctionDescriptor";
		static readonly NativeHandle selFragmentFunctionDescriptorXHandle = Selector.GetHandle ("fragmentFunctionDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFragmentStaticLinkingDescriptorX = "fragmentStaticLinkingDescriptor";
		static readonly NativeHandle selFragmentStaticLinkingDescriptorXHandle = Selector.GetHandle ("fragmentStaticLinkingDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsRasterizationEnabledX = "isRasterizationEnabled";
		static readonly NativeHandle selIsRasterizationEnabledXHandle = Selector.GetHandle ("isRasterizationEnabled");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxTotalThreadgroupsPerMeshGridX = "maxTotalThreadgroupsPerMeshGrid";
		static readonly NativeHandle selMaxTotalThreadgroupsPerMeshGridXHandle = Selector.GetHandle ("maxTotalThreadgroupsPerMeshGrid");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxTotalThreadsPerMeshThreadgroupX = "maxTotalThreadsPerMeshThreadgroup";
		static readonly NativeHandle selMaxTotalThreadsPerMeshThreadgroupXHandle = Selector.GetHandle ("maxTotalThreadsPerMeshThreadgroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxTotalThreadsPerObjectThreadgroupX = "maxTotalThreadsPerObjectThreadgroup";
		static readonly NativeHandle selMaxTotalThreadsPerObjectThreadgroupXHandle = Selector.GetHandle ("maxTotalThreadsPerObjectThreadgroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaxVertexAmplificationCountX = "maxVertexAmplificationCount";
		static readonly NativeHandle selMaxVertexAmplificationCountXHandle = Selector.GetHandle ("maxVertexAmplificationCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeshFunctionDescriptorX = "meshFunctionDescriptor";
		static readonly NativeHandle selMeshFunctionDescriptorXHandle = Selector.GetHandle ("meshFunctionDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeshStaticLinkingDescriptorX = "meshStaticLinkingDescriptor";
		static readonly NativeHandle selMeshStaticLinkingDescriptorXHandle = Selector.GetHandle ("meshStaticLinkingDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeshThreadgroupSizeIsMultipleOfThreadExecutionWidthX = "meshThreadgroupSizeIsMultipleOfThreadExecutionWidth";
		static readonly NativeHandle selMeshThreadgroupSizeIsMultipleOfThreadExecutionWidthXHandle = Selector.GetHandle ("meshThreadgroupSizeIsMultipleOfThreadExecutionWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectFunctionDescriptorX = "objectFunctionDescriptor";
		static readonly NativeHandle selObjectFunctionDescriptorXHandle = Selector.GetHandle ("objectFunctionDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectStaticLinkingDescriptorX = "objectStaticLinkingDescriptor";
		static readonly NativeHandle selObjectStaticLinkingDescriptorXHandle = Selector.GetHandle ("objectStaticLinkingDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectThreadgroupSizeIsMultipleOfThreadExecutionWidthX = "objectThreadgroupSizeIsMultipleOfThreadExecutionWidth";
		static readonly NativeHandle selObjectThreadgroupSizeIsMultipleOfThreadExecutionWidthXHandle = Selector.GetHandle ("objectThreadgroupSizeIsMultipleOfThreadExecutionWidth");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPayloadMemoryLengthX = "payloadMemoryLength";
		static readonly NativeHandle selPayloadMemoryLengthXHandle = Selector.GetHandle ("payloadMemoryLength");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRasterSampleCountX = "rasterSampleCount";
		static readonly NativeHandle selRasterSampleCountXHandle = Selector.GetHandle ("rasterSampleCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiredThreadsPerMeshThreadgroupX = "requiredThreadsPerMeshThreadgroup";
		static readonly NativeHandle selRequiredThreadsPerMeshThreadgroupXHandle = Selector.GetHandle ("requiredThreadsPerMeshThreadgroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRequiredThreadsPerObjectThreadgroupX = "requiredThreadsPerObjectThreadgroup";
		static readonly NativeHandle selRequiredThreadsPerObjectThreadgroupXHandle = Selector.GetHandle ("requiredThreadsPerObjectThreadgroup");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResetX = "reset";
		static readonly NativeHandle selResetXHandle = Selector.GetHandle ("reset");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlphaToCoverageState_X = "setAlphaToCoverageState:";
		static readonly NativeHandle selSetAlphaToCoverageState_XHandle = Selector.GetHandle ("setAlphaToCoverageState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAlphaToOneState_X = "setAlphaToOneState:";
		static readonly NativeHandle selSetAlphaToOneState_XHandle = Selector.GetHandle ("setAlphaToOneState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetColorAttachmentMappingState_X = "setColorAttachmentMappingState:";
		static readonly NativeHandle selSetColorAttachmentMappingState_XHandle = Selector.GetHandle ("setColorAttachmentMappingState:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFragmentFunctionDescriptor_X = "setFragmentFunctionDescriptor:";
		static readonly NativeHandle selSetFragmentFunctionDescriptor_XHandle = Selector.GetHandle ("setFragmentFunctionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFragmentStaticLinkingDescriptor_X = "setFragmentStaticLinkingDescriptor:";
		static readonly NativeHandle selSetFragmentStaticLinkingDescriptor_XHandle = Selector.GetHandle ("setFragmentStaticLinkingDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxTotalThreadgroupsPerMeshGrid_X = "setMaxTotalThreadgroupsPerMeshGrid:";
		static readonly NativeHandle selSetMaxTotalThreadgroupsPerMeshGrid_XHandle = Selector.GetHandle ("setMaxTotalThreadgroupsPerMeshGrid:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxTotalThreadsPerMeshThreadgroup_X = "setMaxTotalThreadsPerMeshThreadgroup:";
		static readonly NativeHandle selSetMaxTotalThreadsPerMeshThreadgroup_XHandle = Selector.GetHandle ("setMaxTotalThreadsPerMeshThreadgroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxTotalThreadsPerObjectThreadgroup_X = "setMaxTotalThreadsPerObjectThreadgroup:";
		static readonly NativeHandle selSetMaxTotalThreadsPerObjectThreadgroup_XHandle = Selector.GetHandle ("setMaxTotalThreadsPerObjectThreadgroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaxVertexAmplificationCount_X = "setMaxVertexAmplificationCount:";
		static readonly NativeHandle selSetMaxVertexAmplificationCount_XHandle = Selector.GetHandle ("setMaxVertexAmplificationCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMeshFunctionDescriptor_X = "setMeshFunctionDescriptor:";
		static readonly NativeHandle selSetMeshFunctionDescriptor_XHandle = Selector.GetHandle ("setMeshFunctionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMeshStaticLinkingDescriptor_X = "setMeshStaticLinkingDescriptor:";
		static readonly NativeHandle selSetMeshStaticLinkingDescriptor_XHandle = Selector.GetHandle ("setMeshStaticLinkingDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMeshThreadgroupSizeIsMultipleOfThreadExecutionWidth_X = "setMeshThreadgroupSizeIsMultipleOfThreadExecutionWidth:";
		static readonly NativeHandle selSetMeshThreadgroupSizeIsMultipleOfThreadExecutionWidth_XHandle = Selector.GetHandle ("setMeshThreadgroupSizeIsMultipleOfThreadExecutionWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObjectFunctionDescriptor_X = "setObjectFunctionDescriptor:";
		static readonly NativeHandle selSetObjectFunctionDescriptor_XHandle = Selector.GetHandle ("setObjectFunctionDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObjectStaticLinkingDescriptor_X = "setObjectStaticLinkingDescriptor:";
		static readonly NativeHandle selSetObjectStaticLinkingDescriptor_XHandle = Selector.GetHandle ("setObjectStaticLinkingDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth_X = "setObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth:";
		static readonly NativeHandle selSetObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth_XHandle = Selector.GetHandle ("setObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetPayloadMemoryLength_X = "setPayloadMemoryLength:";
		static readonly NativeHandle selSetPayloadMemoryLength_XHandle = Selector.GetHandle ("setPayloadMemoryLength:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRasterSampleCount_X = "setRasterSampleCount:";
		static readonly NativeHandle selSetRasterSampleCount_XHandle = Selector.GetHandle ("setRasterSampleCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRasterizationEnabled_X = "setRasterizationEnabled:";
		static readonly NativeHandle selSetRasterizationEnabled_XHandle = Selector.GetHandle ("setRasterizationEnabled:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRequiredThreadsPerMeshThreadgroup_X = "setRequiredThreadsPerMeshThreadgroup:";
		static readonly NativeHandle selSetRequiredThreadsPerMeshThreadgroup_XHandle = Selector.GetHandle ("setRequiredThreadsPerMeshThreadgroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetRequiredThreadsPerObjectThreadgroup_X = "setRequiredThreadsPerObjectThreadgroup:";
		static readonly NativeHandle selSetRequiredThreadsPerObjectThreadgroup_XHandle = Selector.GetHandle ("setRequiredThreadsPerObjectThreadgroup:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupportFragmentBinaryLinking_X = "setSupportFragmentBinaryLinking:";
		static readonly NativeHandle selSetSupportFragmentBinaryLinking_XHandle = Selector.GetHandle ("setSupportFragmentBinaryLinking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupportIndirectCommandBuffers_X = "setSupportIndirectCommandBuffers:";
		static readonly NativeHandle selSetSupportIndirectCommandBuffers_XHandle = Selector.GetHandle ("setSupportIndirectCommandBuffers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupportMeshBinaryLinking_X = "setSupportMeshBinaryLinking:";
		static readonly NativeHandle selSetSupportMeshBinaryLinking_XHandle = Selector.GetHandle ("setSupportMeshBinaryLinking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSupportObjectBinaryLinking_X = "setSupportObjectBinaryLinking:";
		static readonly NativeHandle selSetSupportObjectBinaryLinking_XHandle = Selector.GetHandle ("setSupportObjectBinaryLinking:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportFragmentBinaryLinkingX = "supportFragmentBinaryLinking";
		static readonly NativeHandle selSupportFragmentBinaryLinkingXHandle = Selector.GetHandle ("supportFragmentBinaryLinking");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportIndirectCommandBuffersX = "supportIndirectCommandBuffers";
		static readonly NativeHandle selSupportIndirectCommandBuffersXHandle = Selector.GetHandle ("supportIndirectCommandBuffers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportMeshBinaryLinkingX = "supportMeshBinaryLinking";
		static readonly NativeHandle selSupportMeshBinaryLinkingXHandle = Selector.GetHandle ("supportMeshBinaryLinking");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSupportObjectBinaryLinkingX = "supportObjectBinaryLinking";
		static readonly NativeHandle selSupportObjectBinaryLinkingXHandle = Selector.GetHandle ("supportObjectBinaryLinking");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MTL4MeshRenderPipelineDescriptor");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MTL4MeshRenderPipelineDescriptor" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MTL4MeshRenderPipelineDescriptor () : base (NSObjectFlag.Empty)
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
		protected MTL4MeshRenderPipelineDescriptor (NSObjectFlag t) : base (t)
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
		protected internal MTL4MeshRenderPipelineDescriptor (NativeHandle handle) : base (handle)
		{
		}

		[Export ("reset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Reset ()
		{
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4AlphaToCoverageState AlphaToCoverageState {
			[Export ("alphaToCoverageState", ArgumentSemantic.Assign)]
			get {
				MTL4AlphaToCoverageState ret;
				if (IsDirectBinding) {
					ret = (MTL4AlphaToCoverageState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlphaToCoverageStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTL4AlphaToCoverageState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAlphaToCoverageStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAlphaToCoverageState:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAlphaToCoverageState_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAlphaToCoverageState_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4AlphaToOneState AlphaToOneState {
			[Export ("alphaToOneState", ArgumentSemantic.Assign)]
			get {
				MTL4AlphaToOneState ret;
				if (IsDirectBinding) {
					ret = (MTL4AlphaToOneState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAlphaToOneStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTL4AlphaToOneState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selAlphaToOneStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAlphaToOneState:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAlphaToOneState_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetAlphaToOneState_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4LogicalToPhysicalColorAttachmentMappingState ColorAttachmentMappingState {
			[Export ("colorAttachmentMappingState", ArgumentSemantic.Assign)]
			get {
				MTL4LogicalToPhysicalColorAttachmentMappingState ret;
				if (IsDirectBinding) {
					ret = (MTL4LogicalToPhysicalColorAttachmentMappingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selColorAttachmentMappingStateXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTL4LogicalToPhysicalColorAttachmentMappingState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selColorAttachmentMappingStateXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setColorAttachmentMappingState:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetColorAttachmentMappingState_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetColorAttachmentMappingState_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4RenderPipelineColorAttachmentDescriptorArray ColorAttachments {
			[Export ("colorAttachments")]
			get {
				MTL4RenderPipelineColorAttachmentDescriptorArray? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTL4RenderPipelineColorAttachmentDescriptorArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selColorAttachmentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTL4RenderPipelineColorAttachmentDescriptorArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selColorAttachmentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4FunctionDescriptor? FragmentFunctionDescriptor {
			[Export ("fragmentFunctionDescriptor", ArgumentSemantic.Copy)]
			get {
				MTL4FunctionDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTL4FunctionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFragmentFunctionDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTL4FunctionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFragmentFunctionDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFragmentFunctionDescriptor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFragmentFunctionDescriptor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFragmentFunctionDescriptor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4StaticLinkingDescriptor? FragmentStaticLinkingDescriptor {
			[Export ("fragmentStaticLinkingDescriptor", ArgumentSemantic.Copy)]
			get {
				MTL4StaticLinkingDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTL4StaticLinkingDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selFragmentStaticLinkingDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTL4StaticLinkingDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selFragmentStaticLinkingDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setFragmentStaticLinkingDescriptor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetFragmentStaticLinkingDescriptor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetFragmentStaticLinkingDescriptor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MaxTotalThreadgroupsPerMeshGrid {
			[Export ("maxTotalThreadgroupsPerMeshGrid")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaxTotalThreadgroupsPerMeshGridXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaxTotalThreadgroupsPerMeshGridXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxTotalThreadgroupsPerMeshGrid:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaxTotalThreadgroupsPerMeshGrid_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaxTotalThreadgroupsPerMeshGrid_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MaxTotalThreadsPerMeshThreadgroup {
			[Export ("maxTotalThreadsPerMeshThreadgroup")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaxTotalThreadsPerMeshThreadgroupXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaxTotalThreadsPerMeshThreadgroupXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxTotalThreadsPerMeshThreadgroup:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaxTotalThreadsPerMeshThreadgroup_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaxTotalThreadsPerMeshThreadgroup_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MaxTotalThreadsPerObjectThreadgroup {
			[Export ("maxTotalThreadsPerObjectThreadgroup")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaxTotalThreadsPerObjectThreadgroupXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaxTotalThreadsPerObjectThreadgroupXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxTotalThreadsPerObjectThreadgroup:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaxTotalThreadsPerObjectThreadgroup_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaxTotalThreadsPerObjectThreadgroup_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint MaxVertexAmplificationCount {
			[Export ("maxVertexAmplificationCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selMaxVertexAmplificationCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selMaxVertexAmplificationCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setMaxVertexAmplificationCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetMaxVertexAmplificationCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetMaxVertexAmplificationCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4FunctionDescriptor? MeshFunctionDescriptor {
			[Export ("meshFunctionDescriptor", ArgumentSemantic.Copy)]
			get {
				MTL4FunctionDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTL4FunctionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMeshFunctionDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTL4FunctionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMeshFunctionDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMeshFunctionDescriptor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMeshFunctionDescriptor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMeshFunctionDescriptor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4StaticLinkingDescriptor? MeshStaticLinkingDescriptor {
			[Export ("meshStaticLinkingDescriptor", ArgumentSemantic.Copy)]
			get {
				MTL4StaticLinkingDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTL4StaticLinkingDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMeshStaticLinkingDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTL4StaticLinkingDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMeshStaticLinkingDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMeshStaticLinkingDescriptor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMeshStaticLinkingDescriptor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMeshStaticLinkingDescriptor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeshThreadgroupSizeIsMultipleOfThreadExecutionWidth {
			[Export ("meshThreadgroupSizeIsMultipleOfThreadExecutionWidth")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selMeshThreadgroupSizeIsMultipleOfThreadExecutionWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selMeshThreadgroupSizeIsMultipleOfThreadExecutionWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setMeshThreadgroupSizeIsMultipleOfThreadExecutionWidth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetMeshThreadgroupSizeIsMultipleOfThreadExecutionWidth_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetMeshThreadgroupSizeIsMultipleOfThreadExecutionWidth_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4FunctionDescriptor? ObjectFunctionDescriptor {
			[Export ("objectFunctionDescriptor", ArgumentSemantic.Copy)]
			get {
				MTL4FunctionDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTL4FunctionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObjectFunctionDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTL4FunctionDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObjectFunctionDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setObjectFunctionDescriptor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetObjectFunctionDescriptor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetObjectFunctionDescriptor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4StaticLinkingDescriptor? ObjectStaticLinkingDescriptor {
			[Export ("objectStaticLinkingDescriptor", ArgumentSemantic.Copy)]
			get {
				MTL4StaticLinkingDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MTL4StaticLinkingDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selObjectStaticLinkingDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MTL4StaticLinkingDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selObjectStaticLinkingDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setObjectStaticLinkingDescriptor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetObjectStaticLinkingDescriptor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetObjectStaticLinkingDescriptor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth {
			[Export ("objectThreadgroupSizeIsMultipleOfThreadExecutionWidth")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selObjectThreadgroupSizeIsMultipleOfThreadExecutionWidthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selObjectThreadgroupSizeIsMultipleOfThreadExecutionWidthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetObjectThreadgroupSizeIsMultipleOfThreadExecutionWidth_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint PayloadMemoryLength {
			[Export ("payloadMemoryLength")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selPayloadMemoryLengthXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selPayloadMemoryLengthXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setPayloadMemoryLength:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetPayloadMemoryLength_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetPayloadMemoryLength_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint RasterSampleCount {
			[Export ("rasterSampleCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selRasterSampleCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selRasterSampleCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setRasterSampleCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetRasterSampleCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetRasterSampleCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RasterizationEnabled {
			[Export ("isRasterizationEnabled")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsRasterizationEnabledXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsRasterizationEnabledXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setRasterizationEnabled:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRasterizationEnabled_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetRasterizationEnabled_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSize RequiredThreadsPerMeshThreadgroup {
			[Export ("requiredThreadsPerMeshThreadgroup", ArgumentSemantic.Assign)]
			get {
				MTLSize ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, selRequiredThreadsPerMeshThreadgroupXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, selRequiredThreadsPerMeshThreadgroupXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper (&__objc_super__, selRequiredThreadsPerMeshThreadgroupXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper_stret (&__objc_super__, selRequiredThreadsPerMeshThreadgroupXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setRequiredThreadsPerMeshThreadgroup:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize (this.Handle, selSetRequiredThreadsPerMeshThreadgroup_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTLSize (&__objc_super__, selSetRequiredThreadsPerMeshThreadgroup_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTLSize RequiredThreadsPerObjectThreadgroup {
			[Export ("requiredThreadsPerObjectThreadgroup", ArgumentSemantic.Assign)]
			get {
				MTLSize ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, selRequiredThreadsPerObjectThreadgroupXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, selRequiredThreadsPerObjectThreadgroupXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper (&__objc_super__, selRequiredThreadsPerObjectThreadgroupXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSendSuper_stret (&__objc_super__, selRequiredThreadsPerObjectThreadgroupXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
			[Export ("setRequiredThreadsPerObjectThreadgroup:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_MTLSize (this.Handle, selSetRequiredThreadsPerObjectThreadgroup_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_MTLSize (&__objc_super__, selSetRequiredThreadsPerObjectThreadgroup_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportFragmentBinaryLinking {
			[Export ("supportFragmentBinaryLinking")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSupportFragmentBinaryLinkingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSupportFragmentBinaryLinkingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSupportFragmentBinaryLinking:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSupportFragmentBinaryLinking_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSupportFragmentBinaryLinking_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4IndirectCommandBufferSupportState SupportIndirectCommandBuffers {
			[Export ("supportIndirectCommandBuffers", ArgumentSemantic.Assign)]
			get {
				MTL4IndirectCommandBufferSupportState ret;
				if (IsDirectBinding) {
					ret = (MTL4IndirectCommandBufferSupportState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSupportIndirectCommandBuffersXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MTL4IndirectCommandBufferSupportState) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selSupportIndirectCommandBuffersXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSupportIndirectCommandBuffers:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSupportIndirectCommandBuffers_XHandle, (IntPtr) (long) value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (&__objc_super__, selSetSupportIndirectCommandBuffers_XHandle, (IntPtr) (long) value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportMeshBinaryLinking {
			[Export ("supportMeshBinaryLinking")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSupportMeshBinaryLinkingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSupportMeshBinaryLinkingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSupportMeshBinaryLinking:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSupportMeshBinaryLinking_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSupportMeshBinaryLinking_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SupportObjectBinaryLinking {
			[Export ("supportObjectBinaryLinking")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selSupportObjectBinaryLinkingXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selSupportObjectBinaryLinkingXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
			[Export ("setSupportObjectBinaryLinking:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetSupportObjectBinaryLinking_XHandle, value ? (byte) 1 : (byte) 0);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (&__objc_super__, selSetSupportObjectBinaryLinking_XHandle, value ? (byte) 1 : (byte) 0);
						GC.KeepAlive (this);
					}
				}
			}
		}
	} /* class MTL4MeshRenderPipelineDescriptor */
}
