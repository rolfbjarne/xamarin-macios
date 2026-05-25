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
	/// <summary>A container that stores 3D assets as an indexed collection of <see cref="T:ModelIO.MDLObject" /> trees.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLAsset_Class/index.html">Apple documentation for <c>MDLAsset</c></related>
	[Register("MDLAsset", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLAsset : NSObject, INSCopying {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selURLX = "URL";
		static readonly NativeHandle selURLXHandle = Selector.GetHandle ("URL");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddObject_X = "addObject:";
		static readonly NativeHandle selAddObject_XHandle = Selector.GetHandle ("addObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAnimationsX = "animations";
		static readonly NativeHandle selAnimationsXHandle = Selector.GetHandle ("animations");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWithSCNScene_X = "assetWithSCNScene:";
		static readonly NativeHandle selAssetWithSCNScene_XHandle = Selector.GetHandle ("assetWithSCNScene:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAssetWithSCNScene_BufferAllocator_X = "assetWithSCNScene:bufferAllocator:";
		static readonly NativeHandle selAssetWithSCNScene_BufferAllocator_XHandle = Selector.GetHandle ("assetWithSCNScene:bufferAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingBoxX = "boundingBox";
		static readonly NativeHandle selBoundingBoxXHandle = Selector.GetHandle ("boundingBox");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingBoxAtTime_X = "boundingBoxAtTime:";
		static readonly NativeHandle selBoundingBoxAtTime_XHandle = Selector.GetHandle ("boundingBoxAtTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBufferAllocatorX = "bufferAllocator";
		static readonly NativeHandle selBufferAllocatorXHandle = Selector.GetHandle ("bufferAllocator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanExportFileExtension_X = "canExportFileExtension:";
		static readonly NativeHandle selCanExportFileExtension_XHandle = Selector.GetHandle ("canExportFileExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCanImportFileExtension_X = "canImportFileExtension:";
		static readonly NativeHandle selCanImportFileExtension_XHandle = Selector.GetHandle ("canImportFileExtension:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selChildObjectsOfClass_X = "childObjectsOfClass:";
		static readonly NativeHandle selChildObjectsOfClass_XHandle = Selector.GetHandle ("childObjectsOfClass:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentConformingToProtocol_X = "componentConformingToProtocol:";
		static readonly NativeHandle selComponentConformingToProtocol_XHandle = Selector.GetHandle ("componentConformingToProtocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComponentsX = "components";
		static readonly NativeHandle selComponentsXHandle = Selector.GetHandle ("components");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCopyWithZone_X = "copyWithZone:";
		static readonly NativeHandle selCopyWithZone_XHandle = Selector.GetHandle ("copyWithZone:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountX = "count";
		static readonly NativeHandle selCountXHandle = Selector.GetHandle ("count");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEndTimeX = "endTime";
		static readonly NativeHandle selEndTimeXHandle = Selector.GetHandle ("endTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExportAssetToURL_Error_X = "exportAssetToURL:error:";
		static readonly NativeHandle selExportAssetToURL_Error_XHandle = Selector.GetHandle ("exportAssetToURL:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFrameIntervalX = "frameInterval";
		static readonly NativeHandle selFrameIntervalXHandle = Selector.GetHandle ("frameInterval");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBufferAllocator_X = "initWithBufferAllocator:";
		static readonly NativeHandle selInitWithBufferAllocator_XHandle = Selector.GetHandle ("initWithBufferAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_X = "initWithURL:";
		static readonly NativeHandle selInitWithURL_XHandle = Selector.GetHandle ("initWithURL:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_VertexDescriptor_BufferAllocator_X = "initWithURL:vertexDescriptor:bufferAllocator:";
		static readonly NativeHandle selInitWithURL_VertexDescriptor_BufferAllocator_XHandle = Selector.GetHandle ("initWithURL:vertexDescriptor:bufferAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_X = "initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:";
		static readonly NativeHandle selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_XHandle = Selector.GetHandle ("initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLoadTexturesX = "loadTextures";
		static readonly NativeHandle selLoadTexturesXHandle = Selector.GetHandle ("loadTextures");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMastersX = "masters";
		static readonly NativeHandle selMastersXHandle = Selector.GetHandle ("masters");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtIndex_X = "objectAtIndex:";
		static readonly NativeHandle selObjectAtIndex_XHandle = Selector.GetHandle ("objectAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtIndexedSubscript_X = "objectAtIndexedSubscript:";
		static readonly NativeHandle selObjectAtIndexedSubscript_XHandle = Selector.GetHandle ("objectAtIndexedSubscript:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selObjectAtPath_X = "objectAtPath:";
		static readonly NativeHandle selObjectAtPath_XHandle = Selector.GetHandle ("objectAtPath:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selOriginalsX = "originals";
		static readonly NativeHandle selOriginalsXHandle = Selector.GetHandle ("originals");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlaceLightProbesWithDensity_Heuristic_UsingIrradianceDataSource_X = "placeLightProbesWithDensity:heuristic:usingIrradianceDataSource:";
		static readonly NativeHandle selPlaceLightProbesWithDensity_Heuristic_UsingIrradianceDataSource_XHandle = Selector.GetHandle ("placeLightProbesWithDensity:heuristic:usingIrradianceDataSource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveObject_X = "removeObject:";
		static readonly NativeHandle selRemoveObject_XHandle = Selector.GetHandle ("removeObject:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResolverX = "resolver";
		static readonly NativeHandle selResolverXHandle = Selector.GetHandle ("resolver");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetAnimations_X = "setAnimations:";
		static readonly NativeHandle selSetAnimations_XHandle = Selector.GetHandle ("setAnimations:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetComponent_ForProtocol_X = "setComponent:forProtocol:";
		static readonly NativeHandle selSetComponent_ForProtocol_XHandle = Selector.GetHandle ("setComponent:forProtocol:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetEndTime_X = "setEndTime:";
		static readonly NativeHandle selSetEndTime_XHandle = Selector.GetHandle ("setEndTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetFrameInterval_X = "setFrameInterval:";
		static readonly NativeHandle selSetFrameInterval_XHandle = Selector.GetHandle ("setFrameInterval:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetMasters_X = "setMasters:";
		static readonly NativeHandle selSetMasters_XHandle = Selector.GetHandle ("setMasters:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetOriginals_X = "setOriginals:";
		static readonly NativeHandle selSetOriginals_XHandle = Selector.GetHandle ("setOriginals:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetResolver_X = "setResolver:";
		static readonly NativeHandle selSetResolver_XHandle = Selector.GetHandle ("setResolver:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetStartTime_X = "setStartTime:";
		static readonly NativeHandle selSetStartTime_XHandle = Selector.GetHandle ("setStartTime:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetUpAxis_X = "setUpAxis:";
		static readonly NativeHandle selSetUpAxis_XHandle = Selector.GetHandle ("setUpAxis:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStartTimeX = "startTime";
		static readonly NativeHandle selStartTimeXHandle = Selector.GetHandle ("startTime");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpAxisX = "upAxis";
		static readonly NativeHandle selUpAxisXHandle = Selector.GetHandle ("upAxis");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVertexDescriptorX = "vertexDescriptor";
		static readonly NativeHandle selVertexDescriptorXHandle = Selector.GetHandle ("vertexDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLAsset");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLAsset" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLAsset () : base (NSObjectFlag.Empty)
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
		protected MDLAsset (NSObjectFlag t) : base (t)
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
		protected internal MDLAsset (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="url">To be added.</param><summary>Creates a new MDLAsset by loading the file at the specified URL.</summary><remarks>To be added.</remarks>
		[Export ("initWithURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLAsset (NSUrl url)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithURL_XHandle, url__handle__), "initWithURL:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithURL_XHandle, url__handle__), "initWithURL:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
		}
		/// <param name="url">To be added.</param><param name="vertexDescriptor"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new MDLAsset by loading the file at the specified URL into the buffers provided by the buffer allocator, and formatting the data in memory as described by the vertex descriptor.</summary><remarks>To be added.</remarks>
		[Export ("initWithURL:vertexDescriptor:bufferAllocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLAsset (NSUrl? url, MDLVertexDescriptor? vertexDescriptor, IMDLMeshBufferAllocator? bufferAllocator)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url.GetHandle ();
			var vertexDescriptor__handle__ = vertexDescriptor.GetHandle ();
			var bufferAllocator__handle__ = bufferAllocator.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selInitWithURL_VertexDescriptor_BufferAllocator_XHandle, url__handle__, vertexDescriptor__handle__, bufferAllocator__handle__), "initWithURL:vertexDescriptor:bufferAllocator:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selInitWithURL_VertexDescriptor_BufferAllocator_XHandle, url__handle__, vertexDescriptor__handle__, bufferAllocator__handle__), "initWithURL:vertexDescriptor:bufferAllocator:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (vertexDescriptor);
			GC.KeepAlive (bufferAllocator);
		}
		/// <param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new Model IO asset by using the provided <paramref name="bufferAllocator" />.</summary><remarks>To be added.</remarks>
		[Export ("initWithBufferAllocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLAsset (IMDLMeshBufferAllocator? bufferAllocator)
			: base (NSObjectFlag.Empty)
		{
			var bufferAllocator__handle__ = bufferAllocator.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithBufferAllocator_XHandle, bufferAllocator__handle__), "initWithBufferAllocator:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithBufferAllocator_XHandle, bufferAllocator__handle__), "initWithBufferAllocator:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (bufferAllocator);
		}
		/// <param name="url"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="vertexDescriptor"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="preserveTopology">To be added.</param><param name="error">To be added.</param><summary>Creates a new MDLAsset by loading the file at the specified URL into the buffers provided by the buffer allocator, and formatting the data in memory as described by the vertex descriptor.</summary><remarks>To be added.</remarks>
		[Export ("initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe MDLAsset (NSUrl url, MDLVertexDescriptor? vertexDescriptor, IMDLMeshBufferAllocator? bufferAllocator, bool preserveTopology, out NSError error)
			: base (NSObjectFlag.Empty)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			var vertexDescriptor__handle__ = vertexDescriptor.GetHandle ();
			var bufferAllocator__handle__ = bufferAllocator.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_bool_ref_NativeHandle (this.Handle, selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_XHandle, url__handle__, vertexDescriptor__handle__, bufferAllocator__handle__, preserveTopology ? (byte) 1 : (byte) 0, &errorValue), "initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_bool_ref_NativeHandle (&__objc_super__, selInitWithURL_VertexDescriptor_BufferAllocator_PreserveTopology_Error_XHandle, url__handle__, vertexDescriptor__handle__, bufferAllocator__handle__, preserveTopology ? (byte) 1 : (byte) 0, &errorValue), "initWithURL:vertexDescriptor:bufferAllocator:preserveTopology:error:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			GC.KeepAlive (vertexDescriptor);
			GC.KeepAlive (bufferAllocator);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
		}
		/// <param name="object">To be added.</param><summary>Adds the specified <see cref="T:ModelIO.MDLObject" />, which may be a <see cref="T:ModelIO.MDLCamera" />, <see cref="T:ModelIO.MDLMesh" />, or <see cref="T:ModelIO.MDLLight" />, to the end of the indexed list of objects for this <see cref="T:ModelIO.MDLAsset" />.</summary><remarks>To be added.</remarks>
		[Export ("addObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddObject (MDLObject @object)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddObject_XHandle, @object__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddObject_XHandle, @object__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@object);
		}
		/// <param name="extension">To be added.</param><summary>Returns <see langword="true" /> if the asset can export information to files with a format that corresponds to the specified extension. Otherwise, returns <see langword="false" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canExportFileExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanExportFileExtension (string extension)
		{
			if (extension is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (extension));
			var nsextension = CFString.CreateNative (extension);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanExportFileExtension_XHandle, nsextension);
			CFString.ReleaseNative (nsextension);
			return ret != 0;
		}
		/// <param name="extension">To be added.</param><summary>Returns <see langword="true" /> if the asset can import information from files with a format that corresponds to the specified extension. Otherwise, returns <see langword="false" />.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("canImportFileExtension:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanImportFileExtension (string extension)
		{
			if (extension is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (extension));
			var nsextension = CFString.CreateNative (extension);
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle (class_ptr, selCanImportFileExtension_XHandle, nsextension);
			CFString.ReleaseNative (nsextension);
			return ret != 0;
		}
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			if (IsDirectBinding) {
				ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCopyWithZone_XHandle, zone__handle__), true)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCopyWithZone_XHandle, zone__handle__), true)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (zone);
			return ret!;
		}
		/// <param name="url">To be added.</param><param name="error">To be added.</param><summary>Exports the data that is contained in the asset to the file at the specified URL.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("exportAssetToURL:error:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool ExportAssetToUrl (NSUrl url, out NSError error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, selExportAssetToURL_Error_XHandle, url__handle__, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_ref_NativeHandle (&__objc_super__, selExportAssetToURL_Error_XHandle, url__handle__, &errorValue);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		/// <param name="scene">To be added.</param><summary>Creates and returns a new Model IO asset from the provided Scene Kit scene.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("assetWithSCNScene:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLAsset FromScene (global::SceneKit.SCNScene scene)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			MDLAsset? ret;
			ret =  Runtime.GetNSObject<MDLAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selAssetWithSCNScene_XHandle, scene__handle__), false)!;
			GC.KeepAlive (scene);
			return ret!;
		}
		/// <param name="scene">To be added.</param><param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates and returns a new Model IO asset from the provided Scene Kit scene, using the specified buffer allocator.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("assetWithSCNScene:bufferAllocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLAsset FromScene (global::SceneKit.SCNScene scene, IMDLMeshBufferAllocator? bufferAllocator)
		{
			var scene__handle__ = scene!.GetNonNullHandle (nameof (scene));
			var bufferAllocator__handle__ = bufferAllocator.GetHandle ();
			MDLAsset? ret;
			ret =  Runtime.GetNSObject<MDLAsset> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selAssetWithSCNScene_BufferAllocator_XHandle, scene__handle__, bufferAllocator__handle__), false)!;
			GC.KeepAlive (scene);
			GC.KeepAlive (bufferAllocator);
			return ret!;
		}
		/// <param name="atTime">To be added.</param><summary>Gets the bounding box of the asset at the specified time.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("boundingBoxAtTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLAxisAlignedBoundingBox GetBoundingBox (double atTime)
		{
			MDLAxisAlignedBoundingBox ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_Double (this.Handle, selBoundingBoxAtTime_XHandle, atTime);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret_Double (this.Handle, selBoundingBoxAtTime_XHandle, atTime);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_Double (&__objc_super__, selBoundingBoxAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret_Double (&__objc_super__, selBoundingBoxAtTime_XHandle, atTime);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="objectClass">To be added.</param><summary>Gets the asset's child assets.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("childObjectsOfClass:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLObject[] GetChildObjects (Class objectClass)
		{
			var objectClass__handle__ = objectClass!.GetNonNullHandle (nameof (objectClass));
			MDLObject[]? ret;
			if (IsDirectBinding) {
				ret = CFArray.ArrayFromHandle<MDLObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selChildObjectsOfClass_XHandle, objectClass.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = CFArray.ArrayFromHandle<MDLObject>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selChildObjectsOfClass_XHandle, objectClass.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (objectClass);
			return ret!;
		}
		/// <param name="protocol">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("componentConformingToProtocol:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLComponent? GetComponent (Protocol protocol)
		{
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			IMDLComponent? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<IMDLComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selComponentConformingToProtocol_XHandle, protocol.Handle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<IMDLComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selComponentConformingToProtocol_XHandle, protocol.Handle), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (protocol);
			return ret!;
		}
		/// <param name="type">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMDLComponent? GetComponent (global::System.Type type)
		{
			return GetComponent (new Protocol (type!));
		}
		/// <param name="atPath">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectAtPath:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLObject GetObject (string atPath)
		{
			if (atPath is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (atPath));
			var nsatPath = CFString.CreateNative (atPath);
			MDLObject? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selObjectAtPath_XHandle, nsatPath), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selObjectAtPath_XHandle, nsatPath), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsatPath);
			return ret!;
		}
		/// <param name="index">To be added.</param><summary>Returns the object at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLObject GetObject (nuint index)
		{
			MDLObject ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selObjectAtIndex_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selObjectAtIndex_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>Returns the top-level <see cref="T:ModelIO.MDLObject" /> node in this asset's indexed list of <see cref="T:ModelIO.MDLObject" /> nodes, at the specified index.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("objectAtIndexedSubscript:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLObject? GetObjectAtIndexedSubscript (nuint index)
		{
			MDLObject ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr (this.Handle, selObjectAtIndexedSubscript_XHandle, index), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLObject> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr (&__objc_super__, selObjectAtIndexedSubscript_XHandle, index), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("loadTextures")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LoadTextures ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selLoadTexturesXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selLoadTexturesXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="density">To be added.</param><param name="type">To be added.</param><param name="dataSource">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("placeLightProbesWithDensity:heuristic:usingIrradianceDataSource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLLightProbe[] PlaceLightProbes (float density, MDLProbePlacement type, IMDLLightProbeIrradianceDataSource dataSource)
		{
			var dataSource__handle__ = dataSource!.GetNonNullHandle (nameof (dataSource));
			MDLLightProbe[]? ret;
			ret = CFArray.ArrayFromHandle<MDLLightProbe>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_IntPtr_NativeHandle (class_ptr, selPlaceLightProbesWithDensity_Heuristic_UsingIrradianceDataSource_XHandle, density, (IntPtr) (long) type, dataSource__handle__), false)!;
			GC.KeepAlive (dataSource);
			return ret!;
		}
		/// <param name="object">To be added.</param><summary>Removes the specified <see cref="T:ModelIO.MDLObject" />.</summary><remarks>To be added.</remarks>
		[Export ("removeObject:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveObject (MDLObject @object)
		{
			var @object__handle__ = @object!.GetNonNullHandle (nameof (@object));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveObject_XHandle, @object__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveObject_XHandle, @object__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (@object);
		}
		/// <param name="component">To be added.</param><param name="protocol">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setComponent:forProtocol:")]
		[EditorBrowsable (EditorBrowsableState.Never)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetComponent (IMDLComponent component, Protocol protocol)
		{
			var component__handle__ = component!.GetNonNullHandle (nameof (component));
			var protocol__handle__ = protocol!.GetNonNullHandle (nameof (protocol));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selSetComponent_ForProtocol_XHandle, component__handle__, protocol.Handle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selSetComponent_ForProtocol_XHandle, component__handle__, protocol.Handle);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (component);
			GC.KeepAlive (protocol);
		}
		/// <param name="component">To be added.</param><param name="type">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void SetComponent (IMDLComponent component, global::System.Type type)
		{
			SetComponent (component, new Protocol (type));
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IMDLObjectContainerComponent Animations {
			[Export ("animations", ArgumentSemantic.Retain)]
			get {
				IMDLObjectContainerComponent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAnimationsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAnimationsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setAnimations:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetAnimations_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetAnimations_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the smallest box that contains all of the objects in the asset.</summary><remarks>If any of the asset's contents contain timed information, application developers should use <see cref="M:ModelIO.MDLAsset.GetBoundingBox(System.Double)" />, instead.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLAxisAlignedBoundingBox BoundingBox {
			[Export ("boundingBox")]
			get {
				MDLAxisAlignedBoundingBox ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend (this.Handle, selBoundingBoxXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret (this.Handle, selBoundingBoxXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper (&__objc_super__, selBoundingBoxXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret (&__objc_super__, selBoundingBoxXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the allocator that the application developer specified when constructing the asset, or an internal allocator if none was specified.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBufferAllocator BufferAllocator {
			[Export ("bufferAllocator", ArgumentSemantic.Retain)]
			get {
				IMDLMeshBufferAllocator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selBufferAllocatorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selBufferAllocatorXHandle), false)!;
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
		public virtual IMDLComponent[] Components {
			[Export ("components", ArgumentSemantic.Copy)]
			get {
				IMDLComponent[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMDLComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selComponentsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMDLComponent>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selComponentsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the number of top-level <see cref="T:ModelIO.MDLObject" /> nodes that are indexed by the asset, each of which contains zero or more child <see cref="T:ModelIO.MDLObject" /> nodes.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Count {
			[Export ("count")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>Gets the timestamp of the last timed data item in the asset, which is the highest value to which all requested timed sample data are clamped.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double EndTime {
			[Export ("endTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selEndTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selEndTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setEndTime:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetEndTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetEndTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the frame interval for timed data in the asset.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double FrameInterval {
			[Export ("frameInterval")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selFrameIntervalXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selFrameIntervalXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setFrameInterval:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetFrameInterval_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetFrameInterval_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the underlying object that contains the asset's object hierarchy.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("ios15.0", "Use the 'Originals' property instead.")]
		[ObsoletedOSPlatform ("tvos15.0", "Use the 'Originals' property instead.")]
		[ObsoletedOSPlatform ("macos12.0", "Use the 'Originals' property instead.")]
		[ObsoletedOSPlatform ("maccatalyst15.0", "Use the 'Originals' property instead.")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IMDLObjectContainerComponent Masters {
			[Export ("masters", ArgumentSemantic.Retain)]
			get {
				IMDLObjectContainerComponent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selMastersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selMastersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setMasters:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetMasters_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetMasters_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		public virtual IMDLObjectContainerComponent Originals {
			[Export ("originals", ArgumentSemantic.Retain)]
			get {
				IMDLObjectContainerComponent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selOriginalsXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLObjectContainerComponent> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selOriginalsXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setOriginals:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetOriginals_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetOriginals_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IMDLAssetResolver? Resolver {
			[Export ("resolver", ArgumentSemantic.Retain)]
			get {
				IMDLAssetResolver? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLAssetResolver> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResolverXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLAssetResolver> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResolverXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setResolver:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetResolver_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetResolver_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the timestamp of the first timed data item in the asset, which is the lowest value to which all requested timed sample data are clamped.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual double StartTime {
			[Export ("startTime")]
			get {
				double ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.Double_objc_msgSend (this.Handle, selStartTimeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.Double_objc_msgSendSuper (&__objc_super__, selStartTimeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setStartTime:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_Double (this.Handle, selSetStartTime_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_Double (&__objc_super__, selSetStartTime_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual NVector3 UpAxis {
			[Export ("upAxis", ArgumentSemantic.Assign)]
			get {
				NVector3 ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector3_objc_msgSend (this.Handle, selUpAxisXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector3_objc_msgSendSuper (&__objc_super__, selUpAxisXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setUpAxis:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NVector3 (this.Handle, selSetUpAxis_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NVector3 (&__objc_super__, selSetUpAxis_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the URL from which the asset was loaded, or <see langword="null" /> if the asset was not loaded from a URL.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSUrl? Url {
			[Export ("URL", ArgumentSemantic.Retain)]
			get {
				NSUrl? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selURLXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSUrl> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selURLXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets or sets the description of in-memory vertex data.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLVertexDescriptor? VertexDescriptor {
			[Export ("vertexDescriptor", ArgumentSemantic.Retain)]
			get {
				MDLVertexDescriptor? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MDLVertexDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVertexDescriptorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<MDLVertexDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVertexDescriptorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
	} /* class MDLAsset */
}
