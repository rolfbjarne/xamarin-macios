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
	/// <summary>A collection of <see cref="T:ModelIO.MDLSubmesh" /> objects that, together, define the geometric and material properties for rendering a 3D object.</summary><related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ModelIO/Reference/MDLMesh_Class/index.html">Apple documentation for <c>MDLMesh</c></related>
	[Register("MDLMesh", true)]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public unsafe partial class MDLMesh : MDLObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAttributeWithName_Format_X = "addAttributeWithName:format:";
		static readonly NativeHandle selAddAttributeWithName_Format_XHandle = Selector.GetHandle ("addAttributeWithName:format:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAttributeWithName_Format_Type_Data_Stride_X = "addAttributeWithName:format:type:data:stride:";
		static readonly NativeHandle selAddAttributeWithName_Format_Type_Data_Stride_XHandle = Selector.GetHandle ("addAttributeWithName:format:type:data:stride:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddAttributeWithName_Format_Type_Data_Stride_Time_X = "addAttributeWithName:format:type:data:stride:time:";
		static readonly NativeHandle selAddAttributeWithName_Format_Type_Data_Stride_Time_XHandle = Selector.GetHandle ("addAttributeWithName:format:type:data:stride:time:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddNormalsWithAttributeNamed_CreaseThreshold_X = "addNormalsWithAttributeNamed:creaseThreshold:";
		static readonly NativeHandle selAddNormalsWithAttributeNamed_CreaseThreshold_XHandle = Selector.GetHandle ("addNormalsWithAttributeNamed:creaseThreshold:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_X = "addOrthTanBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:";
		static readonly NativeHandle selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_XHandle = Selector.GetHandle ("addOrthTanBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_X = "addTangentBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:";
		static readonly NativeHandle selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_XHandle = Selector.GetHandle ("addTangentBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_X = "addTangentBasisForTextureCoordinateAttributeNamed:tangentAttributeNamed:bitangentAttributeNamed:";
		static readonly NativeHandle selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_XHandle = Selector.GetHandle ("addTangentBasisForTextureCoordinateAttributeNamed:tangentAttributeNamed:bitangentAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAddUnwrappedTextureCoordinatesForAttributeNamed_X = "addUnwrappedTextureCoordinatesForAttributeNamed:";
		static readonly NativeHandle selAddUnwrappedTextureCoordinatesForAttributeNamed_XHandle = Selector.GetHandle ("addUnwrappedTextureCoordinatesForAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAllocatorX = "allocator";
		static readonly NativeHandle selAllocatorXHandle = Selector.GetHandle ("allocator");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBoundingBoxX = "boundingBox";
		static readonly NativeHandle selBoundingBoxXHandle = Selector.GetHandle ("boundingBox");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlipTextureCoordinatesInAttributeNamed_X = "flipTextureCoordinatesInAttributeNamed:";
		static readonly NativeHandle selFlipTextureCoordinatesInAttributeNamed_XHandle = Selector.GetHandle ("flipTextureCoordinatesInAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_X = "generateAmbientOcclusionTextureWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";
		static readonly NativeHandle selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle = Selector.GetHandle ("generateAmbientOcclusionTextureWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_X = "generateAmbientOcclusionTextureWithSize:raysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";
		static readonly NativeHandle selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle = Selector.GetHandle ("generateAmbientOcclusionTextureWithSize:raysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_X = "generateAmbientOcclusionVertexColorsWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:";
		static readonly NativeHandle selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_XHandle = Selector.GetHandle ("generateAmbientOcclusionVertexColorsWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_X = "generateAmbientOcclusionVertexColorsWithRaysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:";
		static readonly NativeHandle selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_XHandle = Selector.GetHandle ("generateAmbientOcclusionVertexColorsWithRaysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_X = "generateLightMapTextureWithQuality:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";
		static readonly NativeHandle selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle = Selector.GetHandle ("generateLightMapTextureWithQuality:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_X = "generateLightMapTextureWithTextureSize:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:";
		static readonly NativeHandle selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle = Selector.GetHandle ("generateLightMapTextureWithTextureSize:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_X = "generateLightMapVertexColorsWithLightsToConsider:objectsToConsider:vertexAttributeNamed:";
		static readonly NativeHandle selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_XHandle = Selector.GetHandle ("generateLightMapVertexColorsWithLightsToConsider:objectsToConsider:vertexAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_X = "initBoxWithExtent:segments:inwardNormals:geometryType:allocator:";
		static readonly NativeHandle selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_XHandle = Selector.GetHandle ("initBoxWithExtent:segments:inwardNormals:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_X = "initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:";
		static readonly NativeHandle selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_XHandle = Selector.GetHandle ("initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_X = "initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:";
		static readonly NativeHandle selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_XHandle = Selector.GetHandle ("initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_X = "initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:";
		static readonly NativeHandle selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_XHandle = Selector.GetHandle ("initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_X = "initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:";
		static readonly NativeHandle selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_XHandle = Selector.GetHandle ("initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_X = "initIcosahedronWithExtent:inwardNormals:geometryType:allocator:";
		static readonly NativeHandle selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_XHandle = Selector.GetHandle ("initIcosahedronWithExtent:inwardNormals:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_X = "initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:";
		static readonly NativeHandle selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_XHandle = Selector.GetHandle ("initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitPlaneWithExtent_Segments_GeometryType_Allocator_X = "initPlaneWithExtent:segments:geometryType:allocator:";
		static readonly NativeHandle selInitPlaneWithExtent_Segments_GeometryType_Allocator_XHandle = Selector.GetHandle ("initPlaneWithExtent:segments:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_X = "initSphereWithExtent:segments:inwardNormals:geometryType:allocator:";
		static readonly NativeHandle selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_XHandle = Selector.GetHandle ("initSphereWithExtent:segments:inwardNormals:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithBufferAllocator_X = "initWithBufferAllocator:";
		static readonly NativeHandle selInitWithBufferAllocator_XHandle = Selector.GetHandle ("initWithBufferAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_X = "initWithVertexBuffer:vertexCount:descriptor:submeshes:";
		static readonly NativeHandle selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_XHandle = Selector.GetHandle ("initWithVertexBuffer:vertexCount:descriptor:submeshes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_X = "initWithVertexBuffers:vertexCount:descriptor:submeshes:";
		static readonly NativeHandle selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_XHandle = Selector.GetHandle ("initWithVertexBuffers:vertexCount:descriptor:submeshes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeVerticesUniqueX = "makeVerticesUnique";
		static readonly NativeHandle selMakeVerticesUniqueXHandle = Selector.GetHandle ("makeVerticesUnique");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMakeVerticesUniqueAndReturnError_X = "makeVerticesUniqueAndReturnError:";
		static readonly NativeHandle selMakeVerticesUniqueAndReturnError_XHandle = Selector.GetHandle ("makeVerticesUniqueAndReturnError:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeshWithSCNGeometry_X = "meshWithSCNGeometry:";
		static readonly NativeHandle selMeshWithSCNGeometry_XHandle = Selector.GetHandle ("meshWithSCNGeometry:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMeshWithSCNGeometry_BufferAllocator_X = "meshWithSCNGeometry:bufferAllocator:";
		static readonly NativeHandle selMeshWithSCNGeometry_BufferAllocator_XHandle = Selector.GetHandle ("meshWithSCNGeometry:bufferAllocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewBoxWithDimensions_Segments_GeometryType_InwardNormals_Allocator_X = "newBoxWithDimensions:segments:geometryType:inwardNormals:allocator:";
		static readonly NativeHandle selNewBoxWithDimensions_Segments_GeometryType_InwardNormals_Allocator_XHandle = Selector.GetHandle ("newBoxWithDimensions:segments:geometryType:inwardNormals:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewCapsuleWithHeight_Radii_RadialSegments_VerticalSegments_HemisphereSegments_GeometryType_InwardNormals_Allocator_X = "newCapsuleWithHeight:radii:radialSegments:verticalSegments:hemisphereSegments:geometryType:inwardNormals:allocator:";
		static readonly NativeHandle selNewCapsuleWithHeight_Radii_RadialSegments_VerticalSegments_HemisphereSegments_GeometryType_InwardNormals_Allocator_XHandle = Selector.GetHandle ("newCapsuleWithHeight:radii:radialSegments:verticalSegments:hemisphereSegments:geometryType:inwardNormals:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewCylinderWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_X = "newCylinderWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:";
		static readonly NativeHandle selNewCylinderWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_XHandle = Selector.GetHandle ("newCylinderWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewEllipsoidWithRadii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Hemisphere_Allocator_X = "newEllipsoidWithRadii:radialSegments:verticalSegments:geometryType:inwardNormals:hemisphere:allocator:";
		static readonly NativeHandle selNewEllipsoidWithRadii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Hemisphere_Allocator_XHandle = Selector.GetHandle ("newEllipsoidWithRadii:radialSegments:verticalSegments:geometryType:inwardNormals:hemisphere:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewEllipticalConeWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_X = "newEllipticalConeWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:";
		static readonly NativeHandle selNewEllipticalConeWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_XHandle = Selector.GetHandle ("newEllipticalConeWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewIcosahedronWithRadius_InwardNormals_Allocator_X = "newIcosahedronWithRadius:inwardNormals:allocator:";
		static readonly NativeHandle selNewIcosahedronWithRadius_InwardNormals_Allocator_XHandle = Selector.GetHandle ("newIcosahedronWithRadius:inwardNormals:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewIcosahedronWithRadius_InwardNormals_GeometryType_Allocator_X = "newIcosahedronWithRadius:inwardNormals:geometryType:allocator:";
		static readonly NativeHandle selNewIcosahedronWithRadius_InwardNormals_GeometryType_Allocator_XHandle = Selector.GetHandle ("newIcosahedronWithRadius:inwardNormals:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewPlaneWithDimensions_Segments_GeometryType_Allocator_X = "newPlaneWithDimensions:segments:geometryType:allocator:";
		static readonly NativeHandle selNewPlaneWithDimensions_Segments_GeometryType_Allocator_XHandle = Selector.GetHandle ("newPlaneWithDimensions:segments:geometryType:allocator:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNewSubdividedMesh_SubmeshIndex_SubdivisionLevels_X = "newSubdividedMesh:submeshIndex:subdivisionLevels:";
		static readonly NativeHandle selNewSubdividedMesh_SubmeshIndex_SubdivisionLevels_XHandle = Selector.GetHandle ("newSubdividedMesh:submeshIndex:subdivisionLevels:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRemoveAttributeNamed_X = "removeAttributeNamed:";
		static readonly NativeHandle selRemoveAttributeNamed_XHandle = Selector.GetHandle ("removeAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReplaceAttributeNamed_WithData_X = "replaceAttributeNamed:withData:";
		static readonly NativeHandle selReplaceAttributeNamed_WithData_XHandle = Selector.GetHandle ("replaceAttributeNamed:withData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetSubmeshes_X = "setSubmeshes:";
		static readonly NativeHandle selSetSubmeshes_XHandle = Selector.GetHandle ("setSubmeshes:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVertexBuffers_X = "setVertexBuffers:";
		static readonly NativeHandle selSetVertexBuffers_XHandle = Selector.GetHandle ("setVertexBuffers:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVertexCount_X = "setVertexCount:";
		static readonly NativeHandle selSetVertexCount_XHandle = Selector.GetHandle ("setVertexCount:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSetVertexDescriptor_X = "setVertexDescriptor:";
		static readonly NativeHandle selSetVertexDescriptor_XHandle = Selector.GetHandle ("setVertexDescriptor:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubmeshesX = "submeshes";
		static readonly NativeHandle selSubmeshesXHandle = Selector.GetHandle ("submeshes");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selUpdateAttributeNamed_WithData_X = "updateAttributeNamed:withData:";
		static readonly NativeHandle selUpdateAttributeNamed_WithData_XHandle = Selector.GetHandle ("updateAttributeNamed:withData:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVertexAttributeDataForAttributeNamed_X = "vertexAttributeDataForAttributeNamed:";
		static readonly NativeHandle selVertexAttributeDataForAttributeNamed_XHandle = Selector.GetHandle ("vertexAttributeDataForAttributeNamed:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVertexAttributeDataForAttributeNamed_AsFormat_X = "vertexAttributeDataForAttributeNamed:asFormat:";
		static readonly NativeHandle selVertexAttributeDataForAttributeNamed_AsFormat_XHandle = Selector.GetHandle ("vertexAttributeDataForAttributeNamed:asFormat:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVertexBuffersX = "vertexBuffers";
		static readonly NativeHandle selVertexBuffersXHandle = Selector.GetHandle ("vertexBuffers");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVertexCountX = "vertexCount";
		static readonly NativeHandle selVertexCountXHandle = Selector.GetHandle ("vertexCount");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selVertexDescriptorX = "vertexDescriptor";
		static readonly NativeHandle selVertexDescriptorXHandle = Selector.GetHandle ("vertexDescriptor");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MDLMesh");
		/// <summary>The Objective-C class handle for this class.</summary>
		/// <value>The pointer to the Objective-C class.</value>
		/// <remarks>
		///     Each managed class mirrors an unmanaged Objective-C class.
		///     This value contains the pointer to the Objective-C class.
		///     It is similar to calling the managed <see cref="ObjCRuntime.Class.GetHandle(string)" /> or the native <see href="https://developer.apple.com/documentation/objectivec/1418952-objc_getclass">objc_getClass</see> method with the type name.
		/// </remarks>
		public override NativeHandle ClassHandle { get { return class_ptr; } }
		/// <summary>Creates a new <see cref="MDLMesh" /> with default values.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MDLMesh () : base (NSObjectFlag.Empty)
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
		protected MDLMesh (NSObjectFlag t) : base (t)
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
		protected internal MDLMesh (NativeHandle handle) : base (handle)
		{
		}

		/// <param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a new Model IO mesh with the specified buffer allocator.</summary><remarks>To be added.</remarks>
		[Export ("initWithBufferAllocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLMesh (IMDLMeshBufferAllocator? bufferAllocator)
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
		/// <param name="vertexBuffer">To be added.</param><param name="vertexCount">To be added.</param><param name="descriptor">To be added.</param><param name="submeshes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithVertexBuffer:vertexCount:descriptor:submeshes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLMesh (IMDLMeshBuffer vertexBuffer, nuint vertexCount, MDLVertexDescriptor descriptor, MDLSubmesh[] submeshes)
			: base (NSObjectFlag.Empty)
		{
			var vertexBuffer__handle__ = vertexBuffer!.GetNonNullHandle (nameof (vertexBuffer));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (submeshes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (submeshes));
			using var nsa_submeshes = NSArray.FromNSObjects (submeshes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle (this.Handle, selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_XHandle, vertexBuffer__handle__, vertexCount, descriptor__handle__, nsa_submeshes.Handle), "initWithVertexBuffer:vertexCount:descriptor:submeshes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selInitWithVertexBuffer_VertexCount_Descriptor_Submeshes_XHandle, vertexBuffer__handle__, vertexCount, descriptor__handle__, nsa_submeshes.Handle), "initWithVertexBuffer:vertexCount:descriptor:submeshes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (vertexBuffer);
			GC.KeepAlive (descriptor);
		}
		/// <param name="vertexBuffers">To be added.</param><param name="vertexCount">To be added.</param><param name="descriptor">To be added.</param><param name="submeshes">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("initWithVertexBuffers:vertexCount:descriptor:submeshes:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MDLMesh (IMDLMeshBuffer[] vertexBuffers, nuint vertexCount, MDLVertexDescriptor descriptor, MDLSubmesh[] submeshes)
			: base (NSObjectFlag.Empty)
		{
			if (vertexBuffers is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexBuffers));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (submeshes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (submeshes));
			using var nsa_vertexBuffers = NSArray.FromNSObjects (vertexBuffers);
			using var nsa_submeshes = NSArray.FromNSObjects (submeshes);
			if (IsDirectBinding) {
				InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle (this.Handle, selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_XHandle, nsa_vertexBuffers.Handle, vertexCount, descriptor__handle__, nsa_submeshes.Handle), "initWithVertexBuffers:vertexCount:descriptor:submeshes:");
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					InitializeHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_NativeHandle (&__objc_super__, selInitWithVertexBuffers_VertexCount_Descriptor_Submeshes_XHandle, nsa_vertexBuffers.Handle, vertexCount, descriptor__handle__, nsa_submeshes.Handle), "initWithVertexBuffers:vertexCount:descriptor:submeshes:");
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (descriptor);
		}
		/// <param name="name">To be added.</param><param name="format">To be added.</param><summary>Adds the <paramref name="format" /> attribute, indexed by the keyword <paramref name="name" />.</summary><remarks>To be added.</remarks>
		[Export ("addAttributeWithName:format:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAttribute (string name, MDLVertexFormat format)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selAddAttributeWithName_Format_XHandle, nsname, (UIntPtr) (ulong) format);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selAddAttributeWithName_Format_XHandle, nsname, (UIntPtr) (ulong) format);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name">To be added.</param><param name="format">To be added.</param><param name="type">The mesh vector type.</param><param name="data">To be added.</param><param name="stride">To be added.</param><summary>Adds a vertex attribute and a corresponding empty vertex buffer.</summary><remarks>To be added.</remarks>
		[Export ("addAttributeWithName:format:type:data:stride:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAttribute (string name, MDLVertexFormat format, string type, NSData data, nint stride)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var nsname = CFString.CreateNative (name);
			var nstype = CFString.CreateNative (type);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle_IntPtr (this.Handle, selAddAttributeWithName_Format_Type_Data_Stride_XHandle, nsname, (UIntPtr) (ulong) format, nstype, data__handle__, stride);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_NativeHandle_IntPtr (&__objc_super__, selAddAttributeWithName_Format_Type_Data_Stride_XHandle, nsname, (UIntPtr) (ulong) format, nstype, data__handle__, stride);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="name">To be added.</param><param name="format">To be added.</param><param name="type">To be added.</param><param name="data">To be added.</param><param name="stride">To be added.</param><param name="time">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addAttributeWithName:format:type:data:stride:time:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddAttribute (string name, MDLVertexFormat format, string type, NSData data, nint stride, double time)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			if (type is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (type));
			var data__handle__ = data!.GetNonNullHandle (nameof (data));
			var nsname = CFString.CreateNative (name);
			var nstype = CFString.CreateNative (type);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_NativeHandle_IntPtr_Double (this.Handle, selAddAttributeWithName_Format_Type_Data_Stride_Time_XHandle, nsname, (UIntPtr) (ulong) format, nstype, data__handle__, stride, time);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_UIntPtr_NativeHandle_NativeHandle_IntPtr_Double (&__objc_super__, selAddAttributeWithName_Format_Type_Data_Stride_Time_XHandle, nsname, (UIntPtr) (ulong) format, nstype, data__handle__, stride, time);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (data);
			CFString.ReleaseNative (nsname);
			CFString.ReleaseNative (nstype);
		}
		/// <param name="name"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><param name="creaseThreshold">To be added.</param><summary>Generates surface normals for a mesh, interpolating between adjacent faces when the dot product of their unit normals is greater than <paramref name="creaseThreshold" />.</summary><remarks>To be added.</remarks>
		[Export ("addNormalsWithAttributeNamed:creaseThreshold:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddNormals (string? name, float creaseThreshold)
		{
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_float (this.Handle, selAddNormalsWithAttributeNamed_CreaseThreshold_XHandle, nsname, creaseThreshold);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_float (&__objc_super__, selAddNormalsWithAttributeNamed_CreaseThreshold_XHandle, nsname, creaseThreshold);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="textureCoordinateAttributeName">To be added.</param><param name="normalAttributeName">To be added.</param><param name="tangentAttributeName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addOrthTanBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddOrthTanBasis (string textureCoordinateAttributeName, string normalAttributeName, string tangentAttributeName)
		{
			if (textureCoordinateAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textureCoordinateAttributeName));
			if (normalAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (normalAttributeName));
			if (tangentAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tangentAttributeName));
			var nstextureCoordinateAttributeName = CFString.CreateNative (textureCoordinateAttributeName);
			var nsnormalAttributeName = CFString.CreateNative (normalAttributeName);
			var nstangentAttributeName = CFString.CreateNative (tangentAttributeName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_XHandle, nstextureCoordinateAttributeName, nsnormalAttributeName, nstangentAttributeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddOrthTanBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_XHandle, nstextureCoordinateAttributeName, nsnormalAttributeName, nstangentAttributeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstextureCoordinateAttributeName);
			CFString.ReleaseNative (nsnormalAttributeName);
			CFString.ReleaseNative (nstangentAttributeName);
		}
		/// <param name="textureCoordinateAttributeName">To be added.</param><param name="tangentAttributeName">To be added.</param><param name="bitangentAttributeName"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Reads texture coordinates from the buffer that is specified by <paramref name="textureCoordinateAttributeName" />, calculates tangents and bitangents, and stores them in the specified buffers.</summary><remarks>To be added.</remarks>
		[Export ("addTangentBasisForTextureCoordinateAttributeNamed:tangentAttributeNamed:bitangentAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTangentBasis (string textureCoordinateAttributeName, string tangentAttributeName, string? bitangentAttributeName)
		{
			if (textureCoordinateAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textureCoordinateAttributeName));
			if (tangentAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tangentAttributeName));
			var nstextureCoordinateAttributeName = CFString.CreateNative (textureCoordinateAttributeName);
			var nstangentAttributeName = CFString.CreateNative (tangentAttributeName);
			var nsbitangentAttributeName = CFString.CreateNative (bitangentAttributeName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_XHandle, nstextureCoordinateAttributeName, nstangentAttributeName, nsbitangentAttributeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddTangentBasisForTextureCoordinateAttributeNamed_TangentAttributeNamed_BitangentAttributeNamed_XHandle, nstextureCoordinateAttributeName, nstangentAttributeName, nsbitangentAttributeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstextureCoordinateAttributeName);
			CFString.ReleaseNative (nstangentAttributeName);
			CFString.ReleaseNative (nsbitangentAttributeName);
		}
		/// <param name="textureCoordinateAttributeName">To be added.</param><param name="normalAttributeName">To be added.</param><param name="tangentAttributeName">To be added.</param><summary>Reads surface normals from the buffer that is specified by <paramref name="textureCoordinateAttributeName" />, calculates tangents and bitangents, and stores them in the specified buffers.</summary><remarks>To be added.</remarks>
		[Export ("addTangentBasisForTextureCoordinateAttributeNamed:normalAttributeNamed:tangentAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddTangentBasisWithNormals (string textureCoordinateAttributeName, string normalAttributeName, string tangentAttributeName)
		{
			if (textureCoordinateAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textureCoordinateAttributeName));
			if (normalAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (normalAttributeName));
			if (tangentAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tangentAttributeName));
			var nstextureCoordinateAttributeName = CFString.CreateNative (textureCoordinateAttributeName);
			var nsnormalAttributeName = CFString.CreateNative (normalAttributeName);
			var nstangentAttributeName = CFString.CreateNative (tangentAttributeName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_XHandle, nstextureCoordinateAttributeName, nsnormalAttributeName, nstangentAttributeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selAddTangentBasisForTextureCoordinateAttributeNamed_NormalAttributeNamed_TangentAttributeNamed_XHandle, nstextureCoordinateAttributeName, nsnormalAttributeName, nstangentAttributeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstextureCoordinateAttributeName);
			CFString.ReleaseNative (nsnormalAttributeName);
			CFString.ReleaseNative (nstangentAttributeName);
		}
		/// <param name="textureCoordinateAttributeName">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("addUnwrappedTextureCoordinatesForAttributeNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AddUnwrappedTextureCoordinates (string textureCoordinateAttributeName)
		{
			if (textureCoordinateAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (textureCoordinateAttributeName));
			var nstextureCoordinateAttributeName = CFString.CreateNative (textureCoordinateAttributeName);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selAddUnwrappedTextureCoordinatesForAttributeNamed_XHandle, nstextureCoordinateAttributeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selAddUnwrappedTextureCoordinatesForAttributeNamed_XHandle, nstextureCoordinateAttributeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nstextureCoordinateAttributeName);
		}
		/// <param name="height">The height of the capsule.</param><param name="radii">The radii of the capsule.</param><param name="radialSegments">The number of radial segments to generate.</param><param name="verticalSegments">The number of vertical segments to generate in the cylinder.</param><param name="hemisphereSegments">The number segments to generate in the caps.</param><param name="geometryType">Whether to create triangles, quadrilaterals, or lines.</param><param name="inwardNormals">Whether to generate inward-pointing normals.</param><param name="allocator"><para>The allocator to use instead of the default, internal allocator.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a capsule from the width and radii, with the specified number of segments and geometry kind.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newCapsuleWithHeight:radii:radialSegments:verticalSegments:hemisphereSegments:geometryType:inwardNormals:allocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh CreateCapsule (float height, global::System.Numerics.Vector2 radii, nuint radialSegments, nuint verticalSegments, nuint hemisphereSegments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_float_Vector2_UIntPtr_UIntPtr_UIntPtr_IntPtr_bool_NativeHandle (class_ptr, selNewCapsuleWithHeight_Radii_RadialSegments_VerticalSegments_HemisphereSegments_GeometryType_InwardNormals_Allocator_XHandle, height, radii, radialSegments, verticalSegments, hemisphereSegments, (IntPtr) (long) geometryType, inwardNormals ? (byte) 1 : (byte) 0, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("newCylinderWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh CreateCylindroid (float height, global::System.Numerics.Vector2 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_float_Vector2_UIntPtr_UIntPtr_IntPtr_bool_NativeHandle (class_ptr, selNewCylinderWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_XHandle, height, radii, radialSegments, verticalSegments, (IntPtr) (long) geometryType, inwardNormals ? (byte) 1 : (byte) 0, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("newEllipsoidWithRadii:radialSegments:verticalSegments:geometryType:inwardNormals:hemisphere:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh CreateEllipsoid (global::System.Numerics.Vector3 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, bool hemisphere, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_Vector3_UIntPtr_UIntPtr_IntPtr_bool_bool_NativeHandle (class_ptr, selNewEllipsoidWithRadii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Hemisphere_Allocator_XHandle, radii, radialSegments, verticalSegments, (IntPtr) (long) geometryType, inwardNormals ? (byte) 1 : (byte) 0, hemisphere ? (byte) 1 : (byte) 0, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("newEllipticalConeWithHeight:radii:radialSegments:verticalSegments:geometryType:inwardNormals:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh CreateEllipticalCone (float height, global::System.Numerics.Vector2 radii, nuint radialSegments, nuint verticalSegments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_float_Vector2_UIntPtr_UIntPtr_IntPtr_bool_NativeHandle (class_ptr, selNewEllipticalConeWithHeight_Radii_RadialSegments_VerticalSegments_GeometryType_InwardNormals_Allocator_XHandle, height, radii, radialSegments, verticalSegments, (IntPtr) (long) geometryType, inwardNormals ? (byte) 1 : (byte) 0, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		/// <param name="radius">The radius of the icosahedron.</param><param name="inwardNormals">Whether to generate inward-pointing normals.</param><param name="allocator"><para>The allocator to use instead of the default, internal allocator.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a regular icosohedron with the specified radius.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newIcosahedronWithRadius:inwardNormals:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh CreateIcosahedron (float radius, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_bool_NativeHandle (class_ptr, selNewIcosahedronWithRadius_InwardNormals_Allocator_XHandle, radius, inwardNormals ? (byte) 1 : (byte) 0, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		/// <param name="radius">The radius of the icosahedron.</param><param name="inwardNormals">Whether to generate inward-pointing normals.</param><param name="geometryType">Whether to create triangles, quadrilaterals, or lines.</param><param name="allocator"><para>The allocator to use instead of the default, internal allocator.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>Creates a regular icosahedron from the specified parameters.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newIcosahedronWithRadius:inwardNormals:geometryType:allocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh CreateIcosahedron (float radius, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_float_bool_IntPtr_NativeHandle (class_ptr, selNewIcosahedronWithRadius_InwardNormals_GeometryType_Allocator_XHandle, radius, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("newPlaneWithDimensions:segments:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh CreatePlane (global::System.Numerics.Vector2 dimensions, NVector2i segments, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_Vector2_NVector2i_IntPtr_NativeHandle (class_ptr, selNewPlaneWithDimensions_Segments_GeometryType_Allocator_XHandle, dimensions, segments, (IntPtr) (long) geometryType, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		/// <param name="mesh">To be added.</param><param name="submeshIndex">To be added.</param><param name="subdivisionLevels">To be added.</param><summary>Subdivides the indexed submesh within the specified mesh, the specified number of times.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("newSubdividedMesh:submeshIndex:subdivisionLevels:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh? CreateSubdividedMesh (MDLMesh mesh, nuint submeshIndex, nuint subdivisionLevels)
		{
			var mesh__handle__ = mesh!.GetNonNullHandle (nameof (mesh));
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr (class_ptr, selNewSubdividedMesh_SubmeshIndex_SubdivisionLevels_XHandle, mesh__handle__, submeshIndex, subdivisionLevels), false)!;
			GC.KeepAlive (mesh);
			return ret!;
		}
		/// <param name="inTextureCoordinateAttributeNamed">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("flipTextureCoordinatesInAttributeNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FlipTextureCoordinates (string inTextureCoordinateAttributeNamed)
		{
			if (inTextureCoordinateAttributeNamed is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inTextureCoordinateAttributeNamed));
			var nsinTextureCoordinateAttributeNamed = CFString.CreateNative (inTextureCoordinateAttributeNamed);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selFlipTextureCoordinatesInAttributeNamed_XHandle, nsinTextureCoordinateAttributeNamed);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selFlipTextureCoordinatesInAttributeNamed_XHandle, nsinTextureCoordinateAttributeNamed);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsinTextureCoordinateAttributeNamed);
		}
		/// <param name="geometry">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("meshWithSCNGeometry:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh FromGeometry (global::SceneKit.SCNGeometry geometry)
		{
			var geometry__handle__ = geometry!.GetNonNullHandle (nameof (geometry));
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (class_ptr, selMeshWithSCNGeometry_XHandle, geometry__handle__), false)!;
			GC.KeepAlive (geometry);
			return ret!;
		}
		/// <param name="geometry">To be added.</param><param name="bufferAllocator"><para>To be added.</para><para tool="nullallowed">This parameter can be <see langword="null" />.</para></param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("meshWithSCNGeometry:bufferAllocator:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MDLMesh FromGeometry (global::SceneKit.SCNGeometry geometry, IMDLMeshBufferAllocator? bufferAllocator)
		{
			var geometry__handle__ = geometry!.GetNonNullHandle (nameof (geometry));
			var bufferAllocator__handle__ = bufferAllocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (class_ptr, selMeshWithSCNGeometry_BufferAllocator_XHandle, geometry__handle__, bufferAllocator__handle__), false)!;
			GC.KeepAlive (geometry);
			GC.KeepAlive (bufferAllocator);
			return ret!;
		}
		[Export ("generateAmbientOcclusionTextureWithSize:raysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GenerateAmbientOcclusionTexture (NVector2i textureSize, nint raysPerSample, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
		{
			if (objectsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectsToConsider));
			if (vertexAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexAttributeName));
			if (materialPropertyName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (materialPropertyName));
			using var nsa_objectsToConsider = NSArray.FromNSObjects (objectsToConsider);
			var nsvertexAttributeName = CFString.CreateNative (vertexAttributeName);
			var nsmaterialPropertyName = CFString.CreateNative (materialPropertyName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__bool_objc_msgSend_NVector2i_IntPtr_float_NativeHandle_NativeHandle_NativeHandle (this.Handle, selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, textureSize, raysPerSample, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__bool_objc_msgSendSuper_NVector2i_IntPtr_float_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selGenerateAmbientOcclusionTextureWithSize_RaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, textureSize, raysPerSample, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvertexAttributeName);
			CFString.ReleaseNative (nsmaterialPropertyName);
			return ret != 0;
		}
		/// <param name="bakeQuality">To be added.</param><param name="attenuationFactor">To be added.</param><param name="objectsToConsider">To be added.</param><param name="vertexAttributeName">To be added.</param><param name="materialPropertyName">To be added.</param><summary>Generates a texture that is used to simulate the occlusion of ambient light from recesses in the mesh.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("generateAmbientOcclusionTextureWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GenerateAmbientOcclusionTexture (float bakeQuality, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
		{
			if (objectsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectsToConsider));
			if (vertexAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexAttributeName));
			if (materialPropertyName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (materialPropertyName));
			using var nsa_objectsToConsider = NSArray.FromNSObjects (objectsToConsider);
			var nsvertexAttributeName = CFString.CreateNative (vertexAttributeName);
			var nsmaterialPropertyName = CFString.CreateNative (materialPropertyName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_float_float_NativeHandle_NativeHandle_NativeHandle (this.Handle, selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, bakeQuality, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_float_float_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selGenerateAmbientOcclusionTextureWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, bakeQuality, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvertexAttributeName);
			CFString.ReleaseNative (nsmaterialPropertyName);
			return ret != 0;
		}
		/// <param name="raysPerSample">To be added.</param><param name="attenuationFactor">To be added.</param><param name="objectsToConsider">To be added.</param><param name="vertexAttributeName">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("generateAmbientOcclusionVertexColorsWithRaysPerSample:attenuationFactor:objectsToConsider:vertexAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GenerateAmbientOcclusionVertexColors (nint raysPerSample, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName)
		{
			if (objectsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectsToConsider));
			if (vertexAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexAttributeName));
			using var nsa_objectsToConsider = NSArray.FromNSObjects (objectsToConsider);
			var nsvertexAttributeName = CFString.CreateNative (vertexAttributeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_float_NativeHandle_NativeHandle (this.Handle, selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_XHandle, raysPerSample, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_float_NativeHandle_NativeHandle (&__objc_super__, selGenerateAmbientOcclusionVertexColorsWithRaysPerSample_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_XHandle, raysPerSample, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvertexAttributeName);
			return ret != 0;
		}
		/// <param name="bakeQuality">To be added.</param><param name="attenuationFactor">To be added.</param><param name="objectsToConsider">To be added.</param><param name="vertexAttributeName">To be added.</param><summary>Generates vertex color data that is used to simulate the occlusion of ambient light from recesses in the mesh.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("generateAmbientOcclusionVertexColorsWithQuality:attenuationFactor:objectsToConsider:vertexAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GenerateAmbientOcclusionVertexColors (float bakeQuality, float attenuationFactor, MDLObject[] objectsToConsider, string vertexAttributeName)
		{
			if (objectsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectsToConsider));
			if (vertexAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexAttributeName));
			using var nsa_objectsToConsider = NSArray.FromNSObjects (objectsToConsider);
			var nsvertexAttributeName = CFString.CreateNative (vertexAttributeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_float_float_NativeHandle_NativeHandle (this.Handle, selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_XHandle, bakeQuality, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_float_float_NativeHandle_NativeHandle (&__objc_super__, selGenerateAmbientOcclusionVertexColorsWithQuality_AttenuationFactor_ObjectsToConsider_VertexAttributeNamed_XHandle, bakeQuality, attenuationFactor, nsa_objectsToConsider.Handle, nsvertexAttributeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvertexAttributeName);
			return ret != 0;
		}
		[Export ("generateLightMapTextureWithTextureSize:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GenerateLightMapTexture (NVector2i textureSize, MDLLight[] lightsToConsider, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
		{
			if (lightsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (lightsToConsider));
			if (objectsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectsToConsider));
			if (vertexAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexAttributeName));
			if (materialPropertyName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (materialPropertyName));
			using var nsa_lightsToConsider = NSArray.FromNSObjects (lightsToConsider);
			using var nsa_objectsToConsider = NSArray.FromNSObjects (objectsToConsider);
			var nsvertexAttributeName = CFString.CreateNative (vertexAttributeName);
			var nsmaterialPropertyName = CFString.CreateNative (materialPropertyName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__bool_objc_msgSend_NVector2i_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, textureSize, nsa_lightsToConsider.Handle, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__bool_objc_msgSendSuper_NVector2i_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selGenerateLightMapTextureWithTextureSize_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, textureSize, nsa_lightsToConsider.Handle, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvertexAttributeName);
			CFString.ReleaseNative (nsmaterialPropertyName);
			return ret != 0;
		}
		/// <param name="bakeQuality">To be added.</param><param name="lightsToConsider">To be added.</param><param name="objectsToConsider">To be added.</param><param name="vertexAttributeName">To be added.</param><param name="materialPropertyName">To be added.</param><summary>Generates a map that represents the computed result of shading from the specified lights, obstructed by the specified objects.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("generateLightMapTextureWithQuality:lightsToConsider:objectsToConsider:vertexAttributeNamed:materialPropertyNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GenerateLightMapTexture (float bakeQuality, MDLLight[] lightsToConsider, MDLObject[] objectsToConsider, string vertexAttributeName, string materialPropertyName)
		{
			if (lightsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (lightsToConsider));
			if (objectsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectsToConsider));
			if (vertexAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexAttributeName));
			if (materialPropertyName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (materialPropertyName));
			using var nsa_lightsToConsider = NSArray.FromNSObjects (lightsToConsider);
			using var nsa_objectsToConsider = NSArray.FromNSObjects (objectsToConsider);
			var nsvertexAttributeName = CFString.CreateNative (vertexAttributeName);
			var nsmaterialPropertyName = CFString.CreateNative (materialPropertyName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_float_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, bakeQuality, nsa_lightsToConsider.Handle, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_float_NativeHandle_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selGenerateLightMapTextureWithQuality_LightsToConsider_ObjectsToConsider_VertexAttributeNamed_MaterialPropertyNamed_XHandle, bakeQuality, nsa_lightsToConsider.Handle, nsa_objectsToConsider.Handle, nsvertexAttributeName, nsmaterialPropertyName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvertexAttributeName);
			CFString.ReleaseNative (nsmaterialPropertyName);
			return ret != 0;
		}
		/// <param name="lightsToConsider">To be added.</param><param name="objectsToConsider">To be added.</param><param name="vertexAttributeName">To be added.</param><summary>Generates vertex color data that represent the computed result of shading from the specified lights, obstructed by the specified objects.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("generateLightMapVertexColorsWithLightsToConsider:objectsToConsider:vertexAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GenerateLightMapVertexColors (MDLLight[] lightsToConsider, MDLObject[] objectsToConsider, string vertexAttributeName)
		{
			if (lightsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (lightsToConsider));
			if (objectsToConsider is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (objectsToConsider));
			if (vertexAttributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (vertexAttributeName));
			using var nsa_lightsToConsider = NSArray.FromNSObjects (lightsToConsider);
			using var nsa_objectsToConsider = NSArray.FromNSObjects (objectsToConsider);
			var nsvertexAttributeName = CFString.CreateNative (vertexAttributeName);
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_XHandle, nsa_lightsToConsider.Handle, nsa_objectsToConsider.Handle, nsvertexAttributeName);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_NativeHandle_NativeHandle_NativeHandle (&__objc_super__, selGenerateLightMapVertexColorsWithLightsToConsider_ObjectsToConsider_VertexAttributeNamed_XHandle, nsa_lightsToConsider.Handle, nsa_objectsToConsider.Handle, nsvertexAttributeName);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsvertexAttributeName);
			return ret != 0;
		}
		/// <param name="attributeName">To be added.</param><param name="format">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("vertexAttributeDataForAttributeNamed:asFormat:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLVertexAttributeData? GetVertexAttributeData (string attributeName, MDLVertexFormat format)
		{
			if (attributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributeName));
			var nsattributeName = CFString.CreateNative (attributeName);
			MDLVertexAttributeData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLVertexAttributeData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, selVertexAttributeDataForAttributeNamed_AsFormat_XHandle, nsattributeName, (UIntPtr) (ulong) format), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLVertexAttributeData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle_UIntPtr (&__objc_super__, selVertexAttributeDataForAttributeNamed_AsFormat_XHandle, nsattributeName, (UIntPtr) (ulong) format), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsattributeName);
			return ret!;
		}
		[Export ("vertexAttributeDataForAttributeNamed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual MDLVertexAttributeData? GetVertexAttributeDataForAttribute (string attributeName)
		{
			if (attributeName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (attributeName));
			var nsattributeName = CFString.CreateNative (attributeName);
			MDLVertexAttributeData? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MDLVertexAttributeData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, selVertexAttributeDataForAttributeNamed_XHandle, nsattributeName), false)!;
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret =  Runtime.GetNSObject<MDLVertexAttributeData> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper_NativeHandle (&__objc_super__, selVertexAttributeDataForAttributeNamed_XHandle, nsattributeName), false)!;
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsattributeName);
			return ret!;
		}
		[Export ("initBoxWithExtent:segments:inwardNormals:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitBox (global::System.Numerics.Vector3 extent, NVector3i segments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_NVector3i_bool_IntPtr_NativeHandle (this.Handle, selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_NVector3i_bool_IntPtr_NativeHandle (&__objc_super__, selInitBoxWithExtent_Segments_InwardNormals_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initCapsuleWithExtent:cylinderSegments:hemisphereSegments:inwardNormals:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitCapsule (global::System.Numerics.Vector3 extent, NVector2i segments, int hemisphereSegments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_NVector2i_int_bool_IntPtr_NativeHandle (this.Handle, selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_XHandle, extent, segments, hemisphereSegments, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_NVector2i_int_bool_IntPtr_NativeHandle (&__objc_super__, selInitCapsuleWithExtent_CylinderSegments_HemisphereSegments_InwardNormals_GeometryType_Allocator_XHandle, extent, segments, hemisphereSegments, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initConeWithExtent:segments:inwardNormals:cap:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitCone (global::System.Numerics.Vector3 extent, NVector2i segments, bool inwardNormals, bool cap, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_NVector2i_bool_bool_IntPtr_NativeHandle (this.Handle, selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, cap ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_NVector2i_bool_bool_IntPtr_NativeHandle (&__objc_super__, selInitConeWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, cap ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initCylinderWithExtent:segments:inwardNormals:topCap:bottomCap:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitCylinder (global::System.Numerics.Vector3 extent, NVector2i segments, bool inwardNormals, bool topCap, bool bottomCap, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_NVector2i_bool_bool_bool_IntPtr_NativeHandle (this.Handle, selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, topCap ? (byte) 1 : (byte) 0, bottomCap ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_NVector2i_bool_bool_bool_IntPtr_NativeHandle (&__objc_super__, selInitCylinderWithExtent_Segments_InwardNormals_TopCap_BottomCap_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, topCap ? (byte) 1 : (byte) 0, bottomCap ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initHemisphereWithExtent:segments:inwardNormals:cap:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitHemisphere (global::System.Numerics.Vector3 extent, NVector2i segments, bool inwardNormals, bool cap, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_NVector2i_bool_bool_IntPtr_NativeHandle (this.Handle, selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, cap ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_NVector2i_bool_bool_IntPtr_NativeHandle (&__objc_super__, selInitHemisphereWithExtent_Segments_InwardNormals_Cap_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, cap ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initIcosahedronWithExtent:inwardNormals:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitIcosahedron (global::System.Numerics.Vector3 extent, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_bool_IntPtr_NativeHandle (this.Handle, selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_XHandle, extent, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_bool_IntPtr_NativeHandle (&__objc_super__, selInitIcosahedronWithExtent_InwardNormals_GeometryType_Allocator_XHandle, extent, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initMeshBySubdividingMesh:submeshIndex:subdivisionLevels:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitMesh (MDLMesh mesh, int submeshIndex, uint subdivisionLevels, IMDLMeshBufferAllocator? allocator)
		{
			var mesh__handle__ = mesh!.GetNonNullHandle (nameof (mesh));
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_NativeHandle_int_UInt32_NativeHandle (this.Handle, selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_XHandle, mesh__handle__, submeshIndex, subdivisionLevels, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_NativeHandle_int_UInt32_NativeHandle (&__objc_super__, selInitMeshBySubdividingMesh_SubmeshIndex_SubdivisionLevels_Allocator_XHandle, mesh__handle__, submeshIndex, subdivisionLevels, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (mesh);
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initPlaneWithExtent:segments:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitPlane (global::System.Numerics.Vector3 extent, NVector2i segments, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_NVector2i_IntPtr_NativeHandle (this.Handle, selInitPlaneWithExtent_Segments_GeometryType_Allocator_XHandle, extent, segments, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_NVector2i_IntPtr_NativeHandle (&__objc_super__, selInitPlaneWithExtent_Segments_GeometryType_Allocator_XHandle, extent, segments, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		[Export ("initSphereWithExtent:segments:inwardNormals:geometryType:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal virtual nint InitSphere (global::System.Numerics.Vector3 extent, NVector2i segments, bool inwardNormals, MDLGeometryType geometryType, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			nint ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSend_Vector3_NVector2i_bool_IntPtr_NativeHandle (this.Handle, selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_NVector2i_bool_IntPtr_NativeHandle (&__objc_super__, selInitSphereWithExtent_Segments_InwardNormals_GeometryType_Allocator_XHandle, extent, segments, inwardNormals ? (byte) 1 : (byte) 0, (IntPtr) (long) geometryType, allocator__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (allocator);
			return ret!;
		}
		/// <summary>Developers should not use this deprecated method. Developers should use the 'NSError' overload.</summary><remarks>To be added.</remarks>
		[Export ("makeVerticesUnique")]
		[ObsoletedOSPlatform ("ios11.0", "Use the 'NSError' overload.")]
		[ObsoletedOSPlatform ("macos10.13", "Use the 'NSError' overload.")]
		[ObsoletedOSPlatform ("tvos11.0", "Use the 'NSError' overload.")]
		[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'NSError' overload.")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MakeVerticesUnique ()
		{
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selMakeVerticesUniqueXHandle);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper (&__objc_super__, selMakeVerticesUniqueXHandle);
					GC.KeepAlive (this);
				}
			}
		}
		/// <param name="error">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("makeVerticesUniqueAndReturnError:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual bool MakeVerticesUnique (out NSError error)
		{
			NativeHandle errorValue = IntPtr.Zero;
			byte ret;
			if (IsDirectBinding) {
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend_ref_NativeHandle (this.Handle, selMakeVerticesUniqueAndReturnError_XHandle, &errorValue);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					ret = global::ObjCRuntime.Messaging.bool_objc_msgSendSuper_ref_NativeHandle (&__objc_super__, selMakeVerticesUniqueAndReturnError_XHandle, &errorValue);
					GC.KeepAlive (this);
				}
			}
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret != 0;
		}
		[Export ("newBoxWithDimensions:segments:geometryType:inwardNormals:allocator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MDLMesh NewBoxWithDimensions (global::System.Numerics.Vector3 dimensions, NVector3i segments, MDLGeometryType geometryType, bool inwardNormals, IMDLMeshBufferAllocator? allocator)
		{
			var allocator__handle__ = allocator.GetHandle ();
			MDLMesh? ret;
			ret =  Runtime.GetNSObject<MDLMesh> (global::ObjCRuntime.Messaging.xamarin_simd__NativeHandle_objc_msgSend_Vector3_NVector3i_IntPtr_bool_NativeHandle (class_ptr, selNewBoxWithDimensions_Segments_GeometryType_InwardNormals_Allocator_XHandle, dimensions, segments, (IntPtr) (long) geometryType, inwardNormals ? (byte) 1 : (byte) 0, allocator__handle__), false)!;
			GC.KeepAlive (allocator);
			return ret!;
		}
		/// <param name="name">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("removeAttributeNamed:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoveAttribute (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selRemoveAttributeNamed_XHandle, nsname);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selRemoveAttributeNamed_XHandle, nsname);
					GC.KeepAlive (this);
				}
			}
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name">To be added.</param><param name="newData">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("replaceAttributeNamed:withData:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ReplaceAttribute (string name, MDLVertexAttributeData newData)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var newData__handle__ = newData!.GetNonNullHandle (nameof (newData));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selReplaceAttributeNamed_WithData_XHandle, nsname, newData__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selReplaceAttributeNamed_WithData_XHandle, nsname, newData__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newData);
			CFString.ReleaseNative (nsname);
		}
		/// <param name="name">To be added.</param><param name="newData">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("updateAttributeNamed:withData:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UpdateAttribute (string name, MDLVertexAttributeData newData)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var newData__handle__ = newData!.GetNonNullHandle (nameof (newData));
			var nsname = CFString.CreateNative (name);
			if (IsDirectBinding) {
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_NativeHandle (this.Handle, selUpdateAttributeNamed_WithData_XHandle, nsname, newData__handle__);
			} else {
				unsafe {
					var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
					global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle_NativeHandle (&__objc_super__, selUpdateAttributeNamed_WithData_XHandle, nsname, newData__handle__);
					GC.KeepAlive (this);
				}
			}
			GC.KeepAlive (newData);
			CFString.ReleaseNative (nsname);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public virtual IMDLMeshBufferAllocator Allocator {
			[Export ("allocator", ArgumentSemantic.Retain)]
			get {
				IMDLMeshBufferAllocator? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selAllocatorXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetINativeObject<IMDLMeshBufferAllocator> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selAllocatorXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
		}
		/// <summary>Gets the smallest box that contains all of the vertices in the mesh.</summary><value>To be added.</value><remarks>To be added.</remarks>
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
		/// <summary>Gets the array of submeshes for this mesh.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSMutableArray<MDLSubmesh>? Submeshes {
			[Export ("submeshes", ArgumentSemantic.Copy)]
			get {
				NSMutableArray<MDLSubmesh>? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSMutableArray<MDLSubmesh>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selSubmeshesXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret =  Runtime.GetNSObject<NSMutableArray<MDLSubmesh>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selSubmeshesXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setSubmeshes:", ArgumentSemantic.Copy)]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetSubmeshes_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetSubmeshes_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
		/// <summary>Gets the buffers that contain the vertex data for the mesh.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMDLMeshBuffer[] VertexBuffers {
			[Export ("vertexBuffers", ArgumentSemantic.Retain)]
			get {
				IMDLMeshBuffer[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<IMDLMeshBuffer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, selVertexBuffersXHandle), false)!;
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = CFArray.ArrayFromHandle<IMDLMeshBuffer>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSendSuper (&__objc_super__, selVertexBuffersXHandle), false)!;
						GC.KeepAlive (this);
					}
				}
				return ret!;
			}
			[Export ("setVertexBuffers:", ArgumentSemantic.Retain)]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				using var nsa_value = NSArray.FromNSObjects (value);
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVertexBuffers_XHandle, nsa_value.Handle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVertexBuffers_XHandle, nsa_value.Handle);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets the number of vertices in the entire mesh.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint VertexCount {
			[Export ("vertexCount")]
			get {
				nuint ret;
				if (IsDirectBinding) {
					ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, selVertexCountXHandle);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSendSuper (&__objc_super__, selVertexCountXHandle);
						GC.KeepAlive (this);
					}
				}
				return ret;
			}
			[Export ("setVertexCount:")]
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos")]
			set {
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr (this.Handle, selSetVertexCount_XHandle, value);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_UIntPtr (&__objc_super__, selSetVertexCount_XHandle, value);
						GC.KeepAlive (this);
					}
				}
			}
		}
		/// <summary>Gets or sets the description of the in-memory layout of vertices in a mesh.</summary><value><para>(More documentation for this node is coming)</para><para tool="nullallowed">This value can be <see langword="null" />.</para></value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MDLVertexDescriptor VertexDescriptor {
			[Export ("vertexDescriptor", ArgumentSemantic.Copy)]
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
			[Export ("setVertexDescriptor:", ArgumentSemantic.Copy)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, selSetVertexDescriptor_XHandle, value__handle__);
				} else {
					unsafe {
						var __objc_super__ = new global::ObjCRuntime.ObjCSuper (this);
						global::ObjCRuntime.Messaging.void_objc_msgSendSuper_NativeHandle (&__objc_super__, selSetVertexDescriptor_XHandle, value__handle__);
						GC.KeepAlive (this);
					}
				}
				GC.KeepAlive (value);
			}
		}
	} /* class MDLMesh */
}
