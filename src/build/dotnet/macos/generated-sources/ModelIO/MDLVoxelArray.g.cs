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
	/// <summary>Models a 3D object as a collection of volumetric elements, called voxels.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLVoxelArray_Class/index.html">Apple documentation for <c>MDLVoxelArray</c></related>
	[Register("MDLVoxelArray", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLVoxelArray : MDLObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingBoxX = "boundingBox";
		static readonly NativeHandle selBoundingBoxXHandle = Selector.GetHandle ("boundingBox");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoarseMeshX = "coarseMesh";
		static readonly NativeHandle selCoarseMeshXHandle = Selector.GetHandle ("coarseMesh");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoarseMeshUsingAllocator_X = "coarseMeshUsingAllocator:";
		static readonly NativeHandle selCoarseMeshUsingAllocator_XHandle = Selector.GetHandle ("coarseMeshUsingAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConvertToSignedShellFieldX = "convertToSignedShellField";
		static readonly NativeHandle selConvertToSignedShellFieldXHandle = Selector.GetHandle ("convertToSignedShellField");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCountX = "count";
		static readonly NativeHandle selCountXHandle = Selector.GetHandle ("count");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDifferenceWithVoxels_X = "differenceWithVoxels:";
		static readonly NativeHandle selDifferenceWithVoxels_XHandle = Selector.GetHandle ("differenceWithVoxels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIndexOfSpatialLocation_X = "indexOfSpatialLocation:";
		static readonly NativeHandle selIndexOfSpatialLocation_XHandle = Selector.GetHandle ("indexOfSpatialLocation:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_X = "initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:";
		static readonly NativeHandle selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_XHandle = Selector.GetHandle ("initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_X = "initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:";
		static readonly NativeHandle selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_XHandle = Selector.GetHandle ("initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithAsset_Divisions_PatchRadius_X = "initWithAsset:divisions:patchRadius:";
		static readonly NativeHandle selInitWithAsset_Divisions_PatchRadius_XHandle = Selector.GetHandle ("initWithAsset:divisions:patchRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithData_BoundingBox_VoxelExtent_X = "initWithData:boundingBox:voxelExtent:";
		static readonly NativeHandle selInitWithData_BoundingBox_VoxelExtent_XHandle = Selector.GetHandle ("initWithData:boundingBox:voxelExtent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIntersectWithVoxels_X = "intersectWithVoxels:";
		static readonly NativeHandle selIntersectWithVoxels_XHandle = Selector.GetHandle ("intersectWithVoxels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsValidSignedShellFieldX = "isValidSignedShellField";
		static readonly NativeHandle selIsValidSignedShellFieldXHandle = Selector.GetHandle ("isValidSignedShellField");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeshUsingAllocator_X = "meshUsingAllocator:";
		static readonly NativeHandle selMeshUsingAllocator_XHandle = Selector.GetHandle ("meshUsingAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShellFieldExteriorThickness_X = "setShellFieldExteriorThickness:";
		static readonly NativeHandle selSetShellFieldExteriorThickness_XHandle = Selector.GetHandle ("setShellFieldExteriorThickness:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetShellFieldInteriorThickness_X = "setShellFieldInteriorThickness:";
		static readonly NativeHandle selSetShellFieldInteriorThickness_XHandle = Selector.GetHandle ("setShellFieldInteriorThickness:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVoxelAtIndex_X = "setVoxelAtIndex:";
		static readonly NativeHandle selSetVoxelAtIndex_XHandle = Selector.GetHandle ("setVoxelAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_X = "setVoxelsForMesh:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:";
		static readonly NativeHandle selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_XHandle = Selector.GetHandle ("setVoxelsForMesh:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_X = "setVoxelsForMesh:divisions:interiorShells:exteriorShells:patchRadius:";
		static readonly NativeHandle selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_XHandle = Selector.GetHandle ("setVoxelsForMesh:divisions:interiorShells:exteriorShells:patchRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVoxelsForMesh_Divisions_PatchRadius_X = "setVoxelsForMesh:divisions:patchRadius:";
		static readonly NativeHandle selSetVoxelsForMesh_Divisions_PatchRadius_XHandle = Selector.GetHandle ("setVoxelsForMesh:divisions:patchRadius:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShellFieldExteriorThicknessX = "shellFieldExteriorThickness";
		static readonly NativeHandle selShellFieldExteriorThicknessXHandle = Selector.GetHandle ("shellFieldExteriorThickness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShellFieldInteriorThicknessX = "shellFieldInteriorThickness";
		static readonly NativeHandle selShellFieldInteriorThicknessXHandle = Selector.GetHandle ("shellFieldInteriorThickness");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpatialLocationOfIndex_X = "spatialLocationOfIndex:";
		static readonly NativeHandle selSpatialLocationOfIndex_XHandle = Selector.GetHandle ("spatialLocationOfIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUnionWithVoxels_X = "unionWithVoxels:";
		static readonly NativeHandle selUnionWithVoxels_XHandle = Selector.GetHandle ("unionWithVoxels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoxelBoundingBoxAtIndex_X = "voxelBoundingBoxAtIndex:";
		static readonly NativeHandle selVoxelBoundingBoxAtIndex_XHandle = Selector.GetHandle ("voxelBoundingBoxAtIndex:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_X = "voxelExistsAtIndex:allowAnyX:allowAnyY:allowAnyZ:allowAnyShell:";
		static readonly NativeHandle selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_XHandle = Selector.GetHandle ("voxelExistsAtIndex:allowAnyX:allowAnyY:allowAnyZ:allowAnyShell:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoxelIndexExtentX = "voxelIndexExtent";
		static readonly NativeHandle selVoxelIndexExtentXHandle = Selector.GetHandle ("voxelIndexExtent");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoxelIndicesX = "voxelIndices";
		static readonly NativeHandle selVoxelIndicesXHandle = Selector.GetHandle ("voxelIndices");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVoxelsWithinExtent_X = "voxelsWithinExtent:";
		static readonly NativeHandle selVoxelsWithinExtent_XHandle = Selector.GetHandle ("voxelsWithinExtent:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLVoxelArray");
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
		protected MDLVoxelArray (NSObjectFlag t) : base (t)
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
		protected internal MDLVoxelArray (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="asset">To be added.</param><param name="divisions">To be added.</param><param name="interiorShells">To be added.</param><param name="exteriorShells">To be added.</param><param name="patchRadius">To be added.</param><summary>Developers should not use this deprecated constructor. Developers should use 'new MDLVoxelArray (MDLAsset, int, float)'.</summary><remarks>To be added.</remarks>
		[Export ("initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:")]
		[ObsoletedOSPlatform ("macos10.12", "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos10.0", "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLVoxelArray (MDLAsset asset, int divisions, int interiorShells, int exteriorShells, float patchRadius)
			: base (NSObjectFlag.Empty)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_int_int_float (this.Handle, selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_XHandle, asset__handle__, divisions, interiorShells, exteriorShells, patchRadius), "initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_int_int_float (&__objc_super__, selInitWithAsset_Divisions_InteriorShells_ExteriorShells_PatchRadius_XHandle, asset__handle__, divisions, interiorShells, exteriorShells, patchRadius), "initWithAsset:divisions:interiorShells:exteriorShells:patchRadius:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (asset);
		}
		/// <param name="asset">To be added.</param><param name="divisions">To be added.</param><param name="interiorNBWidth">To be added.</param><param name="exteriorNBWidth">To be added.</param><param name="patchRadius">To be added.</param><summary>Creates a new MDLVoxelArray from the provided asset, with the specified number of divisions and the specified numbers of concentric interior and exterior shells of voxels.</summary><remarks>To be added.</remarks>
		[Export ("initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:")]
		[ObsoletedOSPlatform ("macos10.12", "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos10.0", "Use 'new MDLVoxelArray (MDLAsset, int, float)'.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLVoxelArray (MDLAsset asset, int divisions, float interiorNBWidth, float exteriorNBWidth, float patchRadius)
			: base (NSObjectFlag.Empty)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_float_float_float (this.Handle, selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_XHandle, asset__handle__, divisions, interiorNBWidth, exteriorNBWidth, patchRadius), "initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_float_float_float (&__objc_super__, selInitWithAsset_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_XHandle, asset__handle__, divisions, interiorNBWidth, exteriorNBWidth, patchRadius), "initWithAsset:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (asset);
		}
		/// <param name="asset">To be added.</param><param name="divisions">To be added.</param><param name="patchRadius">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithAsset:divisions:patchRadius:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLVoxelArray (MDLAsset asset, int divisions, float patchRadius)
			: base (NSObjectFlag.Empty)
		{
			var asset__handle__ = asset!.GetNonNullHandle (nameof (asset));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_int_float (this.Handle, selInitWithAsset_Divisions_PatchRadius_XHandle, asset__handle__, divisions, patchRadius), "initWithAsset:divisions:patchRadius:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_int_float (&__objc_super__, selInitWithAsset_Divisions_PatchRadius_XHandle, asset__handle__, divisions, patchRadius), "initWithAsset:divisions:patchRadius:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (asset);
		}
		/// <param name="voxelData">To be added.</param><param name="boundingBox">To be added.</param><param name="voxelExtent">To be added.</param><summary>Creates a new MDLVoxelArray from the provided voxel data, bounding box, and voxel extent.</summary><remarks>To be added.</remarks>
		[Export ("initWithData:boundingBox:voxelExtent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLVoxelArray (NSData voxelData, MDLAxisAlignedBoundingBox boundingBox, float voxelExtent)
			: base (NSObjectFlag.Empty)
		{
			var voxelData__handle__ = voxelData!.GetNonNullHandle (nameof (voxelData));
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_NativeHandle_MDLAxisAlignedBoundingBox_float (this.Handle, selInitWithData_BoundingBox_VoxelExtent_XHandle, voxelData__handle__, boundingBox, voxelExtent), "initWithData:boundingBox:voxelExtent:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_NativeHandle_MDLAxisAlignedBoundingBox_float (&__objc_super__, selInitWithData_BoundingBox_VoxelExtent_XHandle, voxelData__handle__, boundingBox, voxelExtent), "initWithData:boundingBox:voxelExtent:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (voxelData);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("convertToSignedShellField")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ConvertToSignedShellField ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selConvertToSignedShellFieldXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selConvertToSignedShellFieldXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="allocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Returns a mesh that encloses the voxels in the array.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("meshUsingAllocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMesh? CreateMesh (IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selMeshUsingAllocator_XHandle, allocator__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selMeshUsingAllocator_XHandle, allocator__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		/// <param name="voxels">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("differenceWithVoxels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DifferenceWith (MDLVoxelArray voxels)
		{
			var voxels__handle__ = voxels!.GetNonNullHandle (nameof (voxels));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selDifferenceWithVoxels_XHandle, voxels__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selDifferenceWithVoxels_XHandle, voxels__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (voxels);
		}
		/// <summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("coarseMesh")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMesh? GetCoarseMesh ()
		{
			MDLMesh ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selCoarseMeshXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selCoarseMeshXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="allocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("coarseMeshUsingAllocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLMesh? GetCoarseMeshUsingAllocator (IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selCoarseMeshUsingAllocator_XHandle, allocator__handle__), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selCoarseMeshUsingAllocator_XHandle, allocator__handle__), false)!;
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("indexOfSpatialLocation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NVector4i GetIndex (global::System.Numerics.Vector3 spatiallocation)
		{
			NVector4i ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector4i_objc_msgSend_Vector3 (this.Handle, selIndexOfSpatialLocation_XHandle, spatiallocation);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__NVector4i_objc_msgSendSuper_Vector3 (&__objc_super__, selIndexOfSpatialLocation_XHandle, spatiallocation);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("spatialLocationOfIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.Numerics.Vector3 GetSpatialLocation (NVector4i index)
		{
			global::System.Numerics.Vector3 ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSend_NVector4i (this.Handle, selSpatialLocationOfIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__Vector3_objc_msgSendSuper_NVector4i (&__objc_super__, selSpatialLocationOfIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		[Export ("voxelBoundingBoxAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLAxisAlignedBoundingBox GetVoxelBoundingBox (NVector4i index)
		{
			MDLAxisAlignedBoundingBox ret;
			if (IsDirectBinding) {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_NVector4i (this.Handle, selVoxelBoundingBoxAtIndex_XHandle, index);
				} else {
					ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret_NVector4i (this.Handle, selVoxelBoundingBoxAtIndex_XHandle, index);
				}
			} else {
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_NVector4i (&__objc_super__, selVoxelBoundingBoxAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret_NVector4i (&__objc_super__, selVoxelBoundingBoxAtIndex_XHandle, index);
						GC.KeepAlive (this);
					}
				}
			}
			return ret!;
		}
		/// <summary>Returns a list of all the voxel indices as an array of 4-component integer arrays.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("voxelIndices")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetVoxelIndices ()
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVoxelIndicesXHandle), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVoxelIndicesXHandle), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="withinExtent">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("voxelsWithinExtent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSData? GetVoxels (MDLVoxelIndexExtent withinExtent)
		{
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_MDLVoxelIndexExtent (this.Handle, selVoxelsWithinExtent_XHandle, withinExtent), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<NSData> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSendSuper_MDLVoxelIndexExtent (&__objc_super__, selVoxelsWithinExtent_XHandle, withinExtent), false)!;
					GC.KeepAlive (this);
				}
			}
			return ret;
		}
		/// <param name="voxels">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("intersectWithVoxels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void IntersectWith (MDLVoxelArray voxels)
		{
			var voxels__handle__ = voxels!.GetNonNullHandle (nameof (voxels));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selIntersectWithVoxels_XHandle, voxels__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selIntersectWithVoxels_XHandle, voxels__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (voxels);
		}
		[Export ("setVoxelAtIndex:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVoxel (NVector4i index)
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSend_NVector4i (this.Handle, selSetVoxelAtIndex_XHandle, index);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.xamarin_simd__void_objc_msgSendSuper_NVector4i (&__objc_super__, selSetVoxelAtIndex_XHandle, index);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="mesh">To be added.</param><param name="divisions">To be added.</param><param name="patchRadius">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVoxelsForMesh:divisions:patchRadius:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVoxels (MDLMesh mesh, int divisions, float patchRadius)
		{
			var mesh__handle__ = mesh!.GetNonNullHandle (nameof (mesh));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int_float (this.Handle, selSetVoxelsForMesh_Divisions_PatchRadius_XHandle, mesh__handle__, divisions, patchRadius);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_int_float (&__objc_super__, selSetVoxelsForMesh_Divisions_PatchRadius_XHandle, mesh__handle__, divisions, patchRadius);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mesh);
		}
		/// <param name="mesh">To be added.</param><param name="divisions">To be added.</param><param name="interiorShells">To be added.</param><param name="exteriorShells">To be added.</param><param name="patchRadius">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVoxelsForMesh:divisions:interiorShells:exteriorShells:patchRadius:")]
		[ObsoletedOSPlatform ("macos10.12", "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos10.0", "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVoxels (MDLMesh mesh, int divisions, int interiorShells, int exteriorShells, float patchRadius)
		{
			var mesh__handle__ = mesh!.GetNonNullHandle (nameof (mesh));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int_int_int_float (this.Handle, selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_XHandle, mesh__handle__, divisions, interiorShells, exteriorShells, patchRadius);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_int_int_int_float (&__objc_super__, selSetVoxelsForMesh_Divisions_InteriorShells_ExteriorShells_PatchRadius_XHandle, mesh__handle__, divisions, interiorShells, exteriorShells, patchRadius);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mesh);
		}
		/// <param name="mesh">To be added.</param><param name="divisions">To be added.</param><param name="interiorNBWidth">To be added.</param><param name="exteriorNBWidth">To be added.</param><param name="patchRadius">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("setVoxelsForMesh:divisions:interiorNBWidth:exteriorNBWidth:patchRadius:")]
		[ObsoletedOSPlatform ("macos10.12", "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[UnsupportedOSPlatform ("ios")]
		[UnsupportedOSPlatform ("tvos10.0", "Use 'SetVoxels (MDLMesh, int, float)' instead.")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVoxels (MDLMesh mesh, int divisions, float interiorNBWidth, float exteriorNBWidth, float patchRadius)
		{
			var mesh__handle__ = mesh!.GetNonNullHandle (nameof (mesh));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_int_float_float_float (this.Handle, selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_XHandle, mesh__handle__, divisions, interiorNBWidth, exteriorNBWidth, patchRadius);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_int_float_float_float (&__objc_super__, selSetVoxelsForMesh_Divisions_InteriorNBWidth_ExteriorNBWidth_PatchRadius_XHandle, mesh__handle__, divisions, interiorNBWidth, exteriorNBWidth, patchRadius);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mesh);
		}
		/// <param name="voxels">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("unionWithVoxels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UnionWith (MDLVoxelArray voxels)
		{
			var voxels__handle__ = voxels!.GetNonNullHandle (nameof (voxels));
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selUnionWithVoxels_XHandle, voxels__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selUnionWithVoxels_XHandle, voxels__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (voxels);
		}
		[Export ("voxelExistsAtIndex:allowAnyX:allowAnyY:allowAnyZ:allowAnyShell:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool VoxelExists (NVector4i atIndex, bool allowAnyX, bool allowAnyY, bool allowAnyZ, bool allowAnyShell)
		{
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__bool_objc_msgSend_NVector4i_bool_bool_bool_bool (this.Handle, selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_XHandle, atIndex, allowAnyX ? (byte) 1 : (byte) 0, allowAnyY ? (byte) 1 : (byte) 0, allowAnyZ ? (byte) 1 : (byte) 0, allowAnyShell ? (byte) 1 : (byte) 0);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__bool_objc_msgSendSuper_NVector4i_bool_bool_bool_bool (&__objc_super__, selVoxelExistsAtIndex_AllowAnyX_AllowAnyY_AllowAnyZ_AllowAnyShell_XHandle, atIndex, allowAnyX ? (byte) 1 : (byte) 0, allowAnyY ? (byte) 1 : (byte) 0, allowAnyZ ? (byte) 1 : (byte) 0, allowAnyShell ? (byte) 1 : (byte) 0);
					GC.KeepAlive (this);
				}
			}
			return ret != 0;
		}
		/// <summary>Gets the smallest box that contains all the voxels.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets the number of voxels in the array.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual bool IsValidSignedShellField {
			[Export ("isValidSignedShellField")]
			get {
				byte ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsValidSignedShellFieldXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper (&__objc_super__, selIsValidSignedShellFieldXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret != 0;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual float ShellFieldExteriorThickness {
			[Export ("shellFieldExteriorThickness")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selShellFieldExteriorThicknessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selShellFieldExteriorThicknessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShellFieldExteriorThickness:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetShellFieldExteriorThickness_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetShellFieldExteriorThickness_XHandle, value);
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
		public virtual float ShellFieldInteriorThickness {
			[Export ("shellFieldInteriorThickness")]
			get {
				float ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selShellFieldInteriorThicknessXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.float_objc_msgSendSuper (&__objc_super__, selShellFieldInteriorThicknessXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setShellFieldInteriorThickness:")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetShellFieldInteriorThickness_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_float (&__objc_super__, selSetShellFieldInteriorThickness_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the allowable ranges for the four components of a voxel index.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLVoxelIndexExtent VoxelIndexExtent {
			[Export ("voxelIndexExtent")]
			get {
				MDLVoxelIndexExtent ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLVoxelIndexExtent_objc_msgSend (this.Handle, selVoxelIndexExtentXHandle);
					} else {
						ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLVoxelIndexExtent_objc_msgSend_stret (this.Handle, selVoxelIndexExtentXHandle);
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLVoxelIndexExtent_objc_msgSendSuper (&__objc_super__, selVoxelIndexExtentXHandle);
							GC.KeepAlive (this);
						}
					} else {
						unsafe {
							var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
							ret = global::ObjCRuntime.Messaging.xamarin_simd__MDLVoxelIndexExtent_objc_msgSendSuper_stret (&__objc_super__, selVoxelIndexExtentXHandle);
							GC.KeepAlive (this);
						}
					}
				}
				return ret!;
			}
		}
	} /* class MDLVoxelArray */
}
