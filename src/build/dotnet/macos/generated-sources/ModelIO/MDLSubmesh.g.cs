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
namespace ModelIO {
	/// <summary>Indexes and identifies a portion of an MDLMesh, and contains material information about the indexed portion.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLSubmesh_Class/index.html">Apple documentation for <c>MDLSubmesh</c></related>
	[Register("MDLSubmesh", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLSubmesh : NSObject, IMDLNamed {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGeometryTypeX = "geometryType";
		static readonly NativeHandle selGeometryTypeXHandle = Selector.GetHandle ("geometryType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexBufferX = "indexBuffer";
		static readonly NativeHandle selIndexBufferXHandle = Selector.GetHandle ("indexBuffer");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexBufferAsIndexType_X = "indexBufferAsIndexType:";
		static readonly NativeHandle selIndexBufferAsIndexType_XHandle = Selector.GetHandle ("indexBufferAsIndexType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexCountX = "indexCount";
		static readonly NativeHandle selIndexCountXHandle = Selector.GetHandle ("indexCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexTypeX = "indexType";
		static readonly NativeHandle selIndexTypeXHandle = Selector.GetHandle ("indexType");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_X = "initWithIndexBuffer:indexCount:indexType:geometryType:material:";
		static readonly NativeHandle selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_XHandle = Selector.GetHandle ("initWithIndexBuffer:indexCount:indexType:geometryType:material:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithMDLSubmesh_IndexType_GeometryType_X = "initWithMDLSubmesh:indexType:geometryType:";
		static readonly NativeHandle selInitWithMDLSubmesh_IndexType_GeometryType_XHandle = Selector.GetHandle ("initWithMDLSubmesh:indexType:geometryType:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_X = "initWithName:indexBuffer:indexCount:indexType:geometryType:material:";
		static readonly NativeHandle selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_XHandle = Selector.GetHandle ("initWithName:indexBuffer:indexCount:indexType:geometryType:material:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_X = "initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:";
		static readonly NativeHandle selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_XHandle = Selector.GetHandle ("initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaterialX = "material";
		static readonly NativeHandle selMaterialXHandle = Selector.GetHandle ("material");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNameX = "name";
		static readonly NativeHandle selNameXHandle = Selector.GetHandle ("name");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMaterial_X = "setMaterial:";
		static readonly NativeHandle selSetMaterial_XHandle = Selector.GetHandle ("setMaterial:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetName_X = "setName:";
		static readonly NativeHandle selSetName_XHandle = Selector.GetHandle ("setName:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetTopology_X = "setTopology:";
		static readonly NativeHandle selSetTopology_XHandle = Selector.GetHandle ("setTopology:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubmeshWithSCNGeometryElement_X = "submeshWithSCNGeometryElement:";
		static readonly NativeHandle selSubmeshWithSCNGeometryElement_XHandle = Selector.GetHandle ("submeshWithSCNGeometryElement:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubmeshWithSCNGeometryElement_BufferAllocator_X = "submeshWithSCNGeometryElement:bufferAllocator:";
		static readonly NativeHandle selSubmeshWithSCNGeometryElement_BufferAllocator_XHandle = Selector.GetHandle ("submeshWithSCNGeometryElement:bufferAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTopologyX = "topology";
		static readonly NativeHandle selTopologyXHandle = Selector.GetHandle ("topology");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLSubmesh");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLSubmesh" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLSubmesh () : base (NSObjectFlag.Empty)
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
		protected MDLSubmesh (NSObjectFlag t) : base (t)
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
		protected internal MDLSubmesh (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="name">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="geometryType">To be added.</param><param name="material"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithName:indexBuffer:indexCount:indexType:geometryType:material:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLSubmesh (string name, IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, MDLMaterial? material)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			var material__handle__ = material.GetHandle ();
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_IntPtr_NativeHandle (this.Handle, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_XHandle, nsname, indexBuffer__handle__, indexCount, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType, material__handle__), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_UIntPtr_IntPtr_NativeHandle (&__objc_super__, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_XHandle, nsname, indexBuffer__handle__, indexCount, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType, material__handle__), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexBuffer);
			GC.KeepAlive (material);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="indexBuffer">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="geometryType">To be added.</param><param name="material"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithIndexBuffer:indexCount:indexType:geometryType:material:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLSubmesh (IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, MDLMaterial? material)
			: base (NSObjectFlag.Empty)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			var material__handle__ = material.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_IntPtr_NativeHandle (this.Handle, selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_XHandle, indexBuffer__handle__, indexCount, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType, material__handle__), "initWithIndexBuffer:indexCount:indexType:geometryType:material:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_UIntPtr_IntPtr_NativeHandle (&__objc_super__, selInitWithIndexBuffer_IndexCount_IndexType_GeometryType_Material_XHandle, indexBuffer__handle__, indexCount, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType, material__handle__), "initWithIndexBuffer:indexCount:indexType:geometryType:material:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexBuffer);
			GC.KeepAlive (material);
		}
		/// <param name="name">To be added.</param><param name="indexBuffer">To be added.</param><param name="indexCount">To be added.</param><param name="indexType">To be added.</param><param name="geometryType">To be added.</param><param name="material"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="topology"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLSubmesh (string name, IMDLMeshBuffer indexBuffer, nuint indexCount, MDLIndexBitDepth indexType, MDLGeometryType geometryType, MDLMaterial? material, MDLSubmeshTopology? topology)
			: base (NSObjectFlag.Empty)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			var material__handle__ = material.GetHandle ();
			var topology__handle__ = topology.GetHandle ();
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_UIntPtr_UIntPtr_IntPtr_NativeHandle_NativeHandle (this.Handle, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_XHandle, nsname, indexBuffer__handle__, indexCount, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType, material__handle__, topology__handle__), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_UIntPtr_UIntPtr_IntPtr_NativeHandle_NativeHandle (&__objc_super__, selInitWithName_IndexBuffer_IndexCount_IndexType_GeometryType_Material_Topology_XHandle, nsname, indexBuffer__handle__, indexCount, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType, material__handle__, topology__handle__), "initWithName:indexBuffer:indexCount:indexType:geometryType:material:topology:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexBuffer);
			GC.KeepAlive (material);
			GC.KeepAlive (topology);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="indexBuffer">To be added.</param><param name="indexType">To be added.</param><param name="geometryType">To be added.</param><summary>Creates a new MDLSubmesh with the specified parameters.</summary><remarks>If either <paramref name="indexType" /> or <paramref name="geometryType" /> do not match the type of data in <paramref name="indexBuffer" />, then a new buffer is created and filled with converted data.</remarks>
		[Export ("initWithMDLSubmesh:indexType:geometryType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLSubmesh (MDLSubmesh indexBuffer, MDLIndexBitDepth indexType, MDLGeometryType geometryType)
			: base (NSObjectFlag.Empty)
		{
			var indexBuffer__handle__ = indexBuffer!.GetNonNullHandle (nameof (indexBuffer));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr (this.Handle, selInitWithMDLSubmesh_IndexType_GeometryType_XHandle, indexBuffer__handle__, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType), "initWithMDLSubmesh:indexType:geometryType:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_IntPtr (&__objc_super__, selInitWithMDLSubmesh_IndexType_GeometryType_XHandle, indexBuffer__handle__, (UIntPtr) (ulong) indexType, (IntPtr) (long) geometryType), "initWithMDLSubmesh:indexType:geometryType:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (indexBuffer);
		}
		/// <param name="element">To be added.</param><summary>Creates a new MDLSubmesh object from the specified Scene Kit geometry element.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("submeshWithSCNGeometryElement:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLSubmesh FromGeometryElement (global::SceneKit.SCNGeometryElement element)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			MDLSubmesh? ret;
			ret =  Runtime.GetNSObject<MDLSubmesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selSubmeshWithSCNGeometryElement_XHandle, element__handle__), false)!;
			GC.KeepAlive (element);
			return ret!;
		}
		/// <param name="element">To be added.</param><param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new submesh from the provided Scene Kit element.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("submeshWithSCNGeometryElement:bufferAllocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLSubmesh FromGeometryElement (global::SceneKit.SCNGeometryElement element, IMDLMeshBufferAllocator? bufferAllocator)
		{
			var element__handle__ = element!.GetNonNullHandle (nameof (element));
			var bufferAllocator__handle__ = bufferAllocator.GetHandle ();
			MDLSubmesh? ret;
			ret =  Runtime.GetNSObject<MDLSubmesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selSubmeshWithSCNGeometryElement_BufferAllocator_XHandle, element__handle__, bufferAllocator__handle__), false)!;
			GC.KeepAlive (element);
			GC.KeepAlive (bufferAllocator);
			return ret!;
		}
		/// <param name="indexType">To be added.</param><summary>Returns the index buffer for the submesh with the specified bit depth.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("indexBufferAsIndexType:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer GetIndexBuffer (MDLIndexBitDepth indexType)
		{
			IMDLMeshBuffer ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selIndexBufferAsIndexType_XHandle, (UIntPtr) (ulong) indexType), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selIndexBufferAsIndexType_XHandle, (UIntPtr) (ulong) indexType), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>Gets or sets the geometry type of the submesh.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLGeometryType GeometryType {
			[Export ("geometryType")]
			get {
				MDLGeometryType ret;
				if (IsDirectBinding) {
					ret = (MDLGeometryType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selGeometryTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MDLGeometryType) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (&__objc_super__, selGeometryTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the buffer whose indices sequence the vertex data into interpretable geometry.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer IndexBuffer {
			[Export ("indexBuffer", ArgumentSemantic.Retain)]
			get {
				IMDLMeshBuffer? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selIndexBufferXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLMeshBuffer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selIndexBufferXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the number of indices in the index buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint IndexCount {
			[Export ("indexCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selIndexCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selIndexCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the numeric data type of the values in the index buffer.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLIndexBitDepth IndexType {
			[Export ("indexType")]
			get {
				MDLIndexBitDepth ret;
				if (IsDirectBinding) {
					ret = (MDLIndexBitDepth) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selIndexTypeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = (MDLIndexBitDepth) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selIndexTypeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the material to use when rendering the submesh.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMaterial? Material {
			[Export ("material", ArgumentSemantic.Retain)]
			get {
				MDLMaterial? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLMaterial> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMaterialXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLMaterial> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMaterialXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMaterial:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMaterial_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMaterial_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets or sets the descriptive name of the named object.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public virtual string Name {
			[Export ("name")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
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
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
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
		/// <summary>Gets a value that controls how the vertices in the submesh define the geometry of the mesh.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>Gets or sets an object that describes the submesh's topology.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLSubmeshTopology? Topology {
			[Export ("topology", ArgumentSemantic.Retain)]
			get {
				MDLSubmeshTopology? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLSubmeshTopology> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selTopologyXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLSubmeshTopology> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selTopologyXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setTopology:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetTopology_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetTopology_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class MDLSubmesh */
}
