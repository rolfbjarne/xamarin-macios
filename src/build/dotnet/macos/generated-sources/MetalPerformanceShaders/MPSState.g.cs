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
namespace MetalPerformanceShaders {
	/// <summary>Temporary storage used by convolutional neural nets.</summary>
	[Register("MPSState", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MPSState : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBufferSizeAtIndex_X = "bufferSizeAtIndex:";
		static readonly NativeHandle selBufferSizeAtIndex_XHandle = Selector.GetHandle ("bufferSizeAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_X = "destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:";
		static readonly NativeHandle selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_XHandle = Selector.GetHandle ("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_BufferSize_X = "initWithDevice:bufferSize:";
		static readonly NativeHandle selInitWithDevice_BufferSize_XHandle = Selector.GetHandle ("initWithDevice:bufferSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_ResourceList_X = "initWithDevice:resourceList:";
		static readonly NativeHandle selInitWithDevice_ResourceList_XHandle = Selector.GetHandle ("initWithDevice:resourceList:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithDevice_TextureDescriptor_X = "initWithDevice:textureDescriptor:";
		static readonly NativeHandle selInitWithDevice_TextureDescriptor_XHandle = Selector.GetHandle ("initWithDevice:textureDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithResource_X = "initWithResource:";
		static readonly NativeHandle selInitWithResource_XHandle = Selector.GetHandle ("initWithResource:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithResources_X = "initWithResources:";
		static readonly NativeHandle selInitWithResources_XHandle = Selector.GetHandle ("initWithResources:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsTemporaryX = "isTemporary";
		static readonly NativeHandle selIsTemporaryXHandle = Selector.GetHandle ("isTemporary");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLabelX = "label";
		static readonly NativeHandle selLabelXHandle = Selector.GetHandle ("label");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReadCountX = "readCount";
		static readonly NativeHandle selReadCountXHandle = Selector.GetHandle ("readCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceX = "resource";
		static readonly NativeHandle selResourceXHandle = Selector.GetHandle ("resource");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceAtIndex_AllocateMemory_X = "resourceAtIndex:allocateMemory:";
		static readonly NativeHandle selResourceAtIndex_AllocateMemory_XHandle = Selector.GetHandle ("resourceAtIndex:allocateMemory:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceCountX = "resourceCount";
		static readonly NativeHandle selResourceCountXHandle = Selector.GetHandle ("resourceCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceSizeX = "resourceSize";
		static readonly NativeHandle selResourceSizeXHandle = Selector.GetHandle ("resourceSize");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selResourceTypeAtIndex_X = "resourceTypeAtIndex:";
		static readonly NativeHandle selResourceTypeAtIndex_XHandle = Selector.GetHandle ("resourceTypeAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetLabel_X = "setLabel:";
		static readonly NativeHandle selSetLabel_XHandle = Selector.GetHandle ("setLabel:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetReadCount_X = "setReadCount:";
		static readonly NativeHandle selSetReadCount_XHandle = Selector.GetHandle ("setReadCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSynchronizeOnCommandBuffer_X = "synchronizeOnCommandBuffer:";
		static readonly NativeHandle selSynchronizeOnCommandBuffer_XHandle = Selector.GetHandle ("synchronizeOnCommandBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryStateWithCommandBuffer_X = "temporaryStateWithCommandBuffer:";
		static readonly NativeHandle selTemporaryStateWithCommandBuffer_XHandle = Selector.GetHandle ("temporaryStateWithCommandBuffer:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryStateWithCommandBuffer_BufferSize_X = "temporaryStateWithCommandBuffer:bufferSize:";
		static readonly NativeHandle selTemporaryStateWithCommandBuffer_BufferSize_XHandle = Selector.GetHandle ("temporaryStateWithCommandBuffer:bufferSize:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryStateWithCommandBuffer_ResourceList_X = "temporaryStateWithCommandBuffer:resourceList:";
		static readonly NativeHandle selTemporaryStateWithCommandBuffer_ResourceList_XHandle = Selector.GetHandle ("temporaryStateWithCommandBuffer:resourceList:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTemporaryStateWithCommandBuffer_TextureDescriptor_X = "temporaryStateWithCommandBuffer:textureDescriptor:";
		static readonly NativeHandle selTemporaryStateWithCommandBuffer_TextureDescriptor_XHandle = Selector.GetHandle ("temporaryStateWithCommandBuffer:textureDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTextureInfoAtIndex_X = "textureInfoAtIndex:";
		static readonly NativeHandle selTextureInfoAtIndex_XHandle = Selector.GetHandle ("textureInfoAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSState");
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
		protected MPSState (NSObjectFlag t) : base (t)
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
		protected internal MPSState (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="device">To be added.</param><param name="bufferSize">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:bufferSize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSState (global::Metal.IMTLDevice device, nuint bufferSize)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selInitWithDevice_BufferSize_XHandle, device__handle__, bufferSize), "initWithDevice:bufferSize:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selInitWithDevice_BufferSize_XHandle, device__handle__, bufferSize), "initWithDevice:bufferSize:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
		}
		/// <param name="device">To be added.</param><param name="descriptor">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:textureDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSState (global::Metal.IMTLDevice device, global::Metal.MTLTextureDescriptor descriptor)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_TextureDescriptor_XHandle, device__handle__, descriptor__handle__), "initWithDevice:textureDescriptor:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_TextureDescriptor_XHandle, device__handle__, descriptor__handle__), "initWithDevice:textureDescriptor:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (descriptor);
		}
		/// <param name="resource">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithResource:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSState (global::Metal.IMTLResource? resource)
			: base (NSObjectFlag.Empty)
		{
			var resource__handle__ = resource.GetHandle ();
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithResource_XHandle, resource__handle__), "initWithResource:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithResource_XHandle, resource__handle__), "initWithResource:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (resource);
		}
		/// <param name="device">To be added.</param><param name="resourceList">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithDevice:resourceList:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSState (global::Metal.IMTLDevice device, MPSStateResourceList resourceList)
			: base (NSObjectFlag.Empty)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			var resourceList__handle__ = resourceList!.GetNonNullHandle (nameof (resourceList));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selInitWithDevice_ResourceList_XHandle, device__handle__, resourceList__handle__), "initWithDevice:resourceList:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selInitWithDevice_ResourceList_XHandle, device__handle__, resourceList__handle__), "initWithDevice:resourceList:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (device);
			GC.KeepAlive (resourceList);
		}
		/// <param name="resources">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithResources:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSState (global::Metal.IMTLResource[]? resources)
			: base (NSObjectFlag.Empty)
		{
			using var nsa_resources = resources is null ? null : NSArray.FromNSObjects (resources);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selInitWithResources_XHandle, nsa_resources.GetHandle ()), "initWithResources:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selInitWithResources_XHandle, nsa_resources.GetHandle ()), "initWithResources:");
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="commandBuffer">To be added.</param><param name="bufferSize">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryStateWithCommandBuffer:bufferSize:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSState CreateTemporaryState (global::Metal.IMTLCommandBuffer commandBuffer, nuint bufferSize)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			MPSState? ret;
			ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (class_ptr, selTemporaryStateWithCommandBuffer_BufferSize_XHandle, commandBuffer__handle__, bufferSize), false)!;
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="descriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryStateWithCommandBuffer:textureDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSState CreateTemporaryState (global::Metal.IMTLCommandBuffer commandBuffer, global::Metal.MTLTextureDescriptor descriptor)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			MPSState? ret;
			ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTemporaryStateWithCommandBuffer_TextureDescriptor_XHandle, commandBuffer__handle__, descriptor__handle__), false)!;
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryStateWithCommandBuffer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSState CreateTemporaryState (global::Metal.IMTLCommandBuffer commandBuffer)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			MPSState? ret;
			ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selTemporaryStateWithCommandBuffer_XHandle, commandBuffer__handle__), false)!;
			GC.KeepAlive (commandBuffer);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="resourceList">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("temporaryStateWithCommandBuffer:resourceList:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSState CreateTemporaryState (global::Metal.IMTLCommandBuffer commandBuffer, MPSStateResourceList resourceList)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var resourceList__handle__ = resourceList!.GetNonNullHandle (nameof (resourceList));
			MPSState? ret;
			ret =  Runtime.GetNSObject<MPSState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selTemporaryStateWithCommandBuffer_ResourceList_XHandle, commandBuffer__handle__, resourceList__handle__), false)!;
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (resourceList);
			return ret!;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("bufferSizeAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetBufferSize (nuint index)
		{
			nuint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selBufferSizeAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selBufferSizeAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="sourceImages">To be added.</param><param name="sourceStates">To be added.</param><param name="kernel">To be added.</param><param name="inDescriptor">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("destinationImageDescriptorForSourceImages:sourceStates:forKernel:suggestedDescriptor:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImageDescriptor GetDestinationImageDescriptor (NSArray<MPSImage> sourceImages, NSArray<MPSState>? sourceStates, MPSKernel kernel, MPSImageDescriptor inDescriptor)
		{
			var sourceImages__handle__ = sourceImages!.GetNonNullHandle (nameof (sourceImages));
			var sourceStates__handle__ = sourceStates.GetHandle ();
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			var inDescriptor__handle__ = inDescriptor!.GetNonNullHandle (nameof (inDescriptor));
			MPSImageDescriptor? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_XHandle, sourceImages__handle__, sourceStates__handle__, kernel__handle__, inDescriptor__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MPSImageDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selDestinationImageDescriptorForSourceImages_SourceStates_ForKernel_SuggestedDescriptor_XHandle, sourceImages__handle__, sourceStates__handle__, kernel__handle__, inDescriptor__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (sourceImages);
			GC.KeepAlive (sourceStates);
			GC.KeepAlive (kernel);
			GC.KeepAlive (inDescriptor);
			return ret!;
		}
		/// <param name="index">To be added.</param><param name="allocateMemory">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resourceAtIndex:allocateMemory:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::Metal.IMTLResource? GetResource (nuint index, bool allocateMemory)
		{
			global::Metal.IMTLResource ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetINativeObject<global::Metal.IMTLResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_UIntPtr_bool (this.Handle, selResourceAtIndex_AllocateMemory_XHandle, index, allocateMemory ? (byte) 1 : (byte) 0), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetINativeObject<global::Metal.IMTLResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_UIntPtr_bool (&__objc_super__, selResourceAtIndex_AllocateMemory_XHandle, index, allocateMemory ? (byte) 1 : (byte) 0), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("resourceTypeAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSStateResourceType GetResourceType (nuint index)
		{
			MPSStateResourceType ret;
			if (IsDirectBinding) {
				ret = (MetalPerformanceShaders.MPSStateResourceType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, selResourceTypeAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = (MetalPerformanceShaders.MPSStateResourceType) (ulong) global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (&__objc_super__, selResourceTypeAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret!;
		}
		/// <param name="index">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("textureInfoAtIndex:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSStateTextureInfo GetTextureInfo (nuint index)
		{
			MPSStateTextureInfo ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MPSStateTextureInfo_objc_msgSend_UIntPtr (this.Handle, selTextureInfoAtIndex_XHandle, index);
				} else {
					ret = global::ObjCRuntime.Messaging.MPSStateTextureInfo_objc_msgSend_stret_UIntPtr (this.Handle, selTextureInfoAtIndex_XHandle, index);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSStateTextureInfo_objc_msgSendSuper_UIntPtr (&__objc_super__, selTextureInfoAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.MPSStateTextureInfo_objc_msgSendSuper_stret_UIntPtr (&__objc_super__, selTextureInfoAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("synchronizeOnCommandBuffer:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Synchronize (global::Metal.IMTLCommandBuffer commandBuffer)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSynchronizeOnCommandBuffer_XHandle, commandBuffer__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSynchronizeOnCommandBuffer_XHandle, commandBuffer__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (commandBuffer);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsTemporary {
			[Export ("isTemporary")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsTemporaryXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsTemporaryXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Label {
			[Export ("label")]
			get {
				string ret;
				if (IsDirectBinding) {
					ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selLabelXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selLabelXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setLabel:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetLabel_XHandle, nsvalue);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetLabel_XHandle, nsvalue);
						GC.KeepAlive (this);
					}
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint ReadCount {
			[Export ("readCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selReadCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selReadCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setReadCount:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetReadCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetReadCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[ObsoletedOSPlatform ("tvos12.0", "Please use 'GetResource (nuint, bool)' instead.")]
		[ObsoletedOSPlatform ("ios12.0", "Please use 'GetResource (nuint, bool)' instead.")]
		[ObsoletedOSPlatform ("macos10.13.4", "Please use 'GetResource (nuint, bool)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Please use 'GetResource (nuint, bool)' instead.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual global::Metal.IMTLResource? Resource {
			[Export ("resource", ArgumentSemantic.Retain)]
			get {
				global::Metal.IMTLResource? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<global::Metal.IMTLResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selResourceXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<global::Metal.IMTLResource> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selResourceXHandle), false)!;
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
		public virtual nuint ResourceCount {
			[Export ("resourceCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selResourceCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selResourceCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual nuint ResourceSize {
			[Export ("resourceSize")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selResourceSizeXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selResourceSizeXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
		}
	} /* class MPSState */
}
