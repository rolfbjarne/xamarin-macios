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
namespace MetalPerformanceShadersGraph {
	[SupportedOSPlatform ("ios14.0")]
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphTensorShapeOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatchToSpaceTensor_SpatialAxes_BatchAxis_BlockDimensions_UsePixelShuffleOrder_Name_X = "batchToSpaceTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:";
		static readonly NativeHandle selBatchToSpaceTensor_SpatialAxes_BatchAxis_BlockDimensions_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("batchToSpaceTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBatchToSpaceTensor_SpatialAxesTensor_BatchAxisTensor_BlockDimensionsTensor_UsePixelShuffleOrder_Name_X = "batchToSpaceTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:";
		static readonly NativeHandle selBatchToSpaceTensor_SpatialAxesTensor_BatchAxisTensor_BlockDimensionsTensor_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("batchToSpaceTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBroadcastTensor_ToShape_Name_X = "broadcastTensor:toShape:name:";
		static readonly NativeHandle selBroadcastTensor_ToShape_Name_XHandle = Selector.GetHandle ("broadcastTensor:toShape:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBroadcastTensor_ToShapeTensor_Name_X = "broadcastTensor:toShapeTensor:name:";
		static readonly NativeHandle selBroadcastTensor_ToShapeTensor_Name_XHandle = Selector.GetHandle ("broadcastTensor:toShapeTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCastTensor_ToType_Name_X = "castTensor:toType:name:";
		static readonly NativeHandle selCastTensor_ToType_Name_XHandle = Selector.GetHandle ("castTensor:toType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConcatTensor_WithTensor_Dimension_Name_X = "concatTensor:withTensor:dimension:name:";
		static readonly NativeHandle selConcatTensor_WithTensor_Dimension_Name_XHandle = Selector.GetHandle ("concatTensor:withTensor:dimension:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConcatTensors_Dimension_Interleave_Name_X = "concatTensors:dimension:interleave:name:";
		static readonly NativeHandle selConcatTensors_Dimension_Interleave_Name_XHandle = Selector.GetHandle ("concatTensors:dimension:interleave:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConcatTensors_Dimension_Name_X = "concatTensors:dimension:name:";
		static readonly NativeHandle selConcatTensors_Dimension_Name_XHandle = Selector.GetHandle ("concatTensors:dimension:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateAlongAxis_WithShape_Name_X = "coordinateAlongAxis:withShape:name:";
		static readonly NativeHandle selCoordinateAlongAxis_WithShape_Name_XHandle = Selector.GetHandle ("coordinateAlongAxis:withShape:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateAlongAxis_WithShapeTensor_Name_X = "coordinateAlongAxis:withShapeTensor:name:";
		static readonly NativeHandle selCoordinateAlongAxis_WithShapeTensor_Name_XHandle = Selector.GetHandle ("coordinateAlongAxis:withShapeTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateAlongAxisTensor_WithShape_Name_X = "coordinateAlongAxisTensor:withShape:name:";
		static readonly NativeHandle selCoordinateAlongAxisTensor_WithShape_Name_XHandle = Selector.GetHandle ("coordinateAlongAxisTensor:withShape:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoordinateAlongAxisTensor_WithShapeTensor_Name_X = "coordinateAlongAxisTensor:withShapeTensor:name:";
		static readonly NativeHandle selCoordinateAlongAxisTensor_WithShapeTensor_Name_XHandle = Selector.GetHandle ("coordinateAlongAxisTensor:withShapeTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthToSpace2DTensor_WidthAxis_HeightAxis_DepthAxis_BlockSize_UsePixelShuffleOrder_Name_X = "depthToSpace2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:";
		static readonly NativeHandle selDepthToSpace2DTensor_WidthAxis_HeightAxis_DepthAxis_BlockSize_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("depthToSpace2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDepthToSpace2DTensor_WidthAxisTensor_HeightAxisTensor_DepthAxisTensor_BlockSize_UsePixelShuffleOrder_Name_X = "depthToSpace2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:";
		static readonly NativeHandle selDepthToSpace2DTensor_WidthAxisTensor_HeightAxisTensor_DepthAxisTensor_BlockSize_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("depthToSpace2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpandDimsOfTensor_Axes_Name_X = "expandDimsOfTensor:axes:name:";
		static readonly NativeHandle selExpandDimsOfTensor_Axes_Name_XHandle = Selector.GetHandle ("expandDimsOfTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpandDimsOfTensor_AxesTensor_Name_X = "expandDimsOfTensor:axesTensor:name:";
		static readonly NativeHandle selExpandDimsOfTensor_AxesTensor_Name_XHandle = Selector.GetHandle ("expandDimsOfTensor:axesTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExpandDimsOfTensor_Axis_Name_X = "expandDimsOfTensor:axis:name:";
		static readonly NativeHandle selExpandDimsOfTensor_Axis_Name_XHandle = Selector.GetHandle ("expandDimsOfTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlatten2DTensor_Axis_Name_X = "flatten2DTensor:axis:name:";
		static readonly NativeHandle selFlatten2DTensor_Axis_Name_XHandle = Selector.GetHandle ("flatten2DTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFlatten2DTensor_AxisTensor_Name_X = "flatten2DTensor:axisTensor:name:";
		static readonly NativeHandle selFlatten2DTensor_AxisTensor_Name_XHandle = Selector.GetHandle ("flatten2DTensor:axisTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPadGradientWithIncomingGradientTensor_SourceTensor_PaddingMode_LeftPadding_RightPadding_Name_X = "padGradientWithIncomingGradientTensor:sourceTensor:paddingMode:leftPadding:rightPadding:name:";
		static readonly NativeHandle selPadGradientWithIncomingGradientTensor_SourceTensor_PaddingMode_LeftPadding_RightPadding_Name_XHandle = Selector.GetHandle ("padGradientWithIncomingGradientTensor:sourceTensor:paddingMode:leftPadding:rightPadding:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPadTensor_WithPaddingMode_LeftPadding_RightPadding_ConstantValue_Name_X = "padTensor:withPaddingMode:leftPadding:rightPadding:constantValue:name:";
		static readonly NativeHandle selPadTensor_WithPaddingMode_LeftPadding_RightPadding_ConstantValue_Name_XHandle = Selector.GetHandle ("padTensor:withPaddingMode:leftPadding:rightPadding:constantValue:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReinterpretCastTensor_ToType_Name_X = "reinterpretCastTensor:toType:name:";
		static readonly NativeHandle selReinterpretCastTensor_ToType_Name_XHandle = Selector.GetHandle ("reinterpretCastTensor:toType:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReshapeTensor_WithShape_Name_X = "reshapeTensor:withShape:name:";
		static readonly NativeHandle selReshapeTensor_WithShape_Name_XHandle = Selector.GetHandle ("reshapeTensor:withShape:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReshapeTensor_WithShapeTensor_Name_X = "reshapeTensor:withShapeTensor:name:";
		static readonly NativeHandle selReshapeTensor_WithShapeTensor_Name_XHandle = Selector.GetHandle ("reshapeTensor:withShapeTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReverseTensor_Axes_Name_X = "reverseTensor:axes:name:";
		static readonly NativeHandle selReverseTensor_Axes_Name_XHandle = Selector.GetHandle ("reverseTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReverseTensor_AxesTensor_Name_X = "reverseTensor:axesTensor:name:";
		static readonly NativeHandle selReverseTensor_AxesTensor_Name_XHandle = Selector.GetHandle ("reverseTensor:axesTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReverseTensor_Name_X = "reverseTensor:name:";
		static readonly NativeHandle selReverseTensor_Name_XHandle = Selector.GetHandle ("reverseTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selShapeOfTensor_Name_X = "shapeOfTensor:name:";
		static readonly NativeHandle selShapeOfTensor_Name_XHandle = Selector.GetHandle ("shapeOfTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceGradientTensor_FwdInShapeTensor_StartTensor_EndTensor_StrideTensor_StartMask_EndMask_SqueezeMask_Name_X = "sliceGradientTensor:fwdInShapeTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:";
		static readonly NativeHandle selSliceGradientTensor_FwdInShapeTensor_StartTensor_EndTensor_StrideTensor_StartMask_EndMask_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceGradientTensor_FwdInShapeTensor_StartTensor_SizeTensor_SqueezeMask_Name_X = "sliceGradientTensor:fwdInShapeTensor:startTensor:sizeTensor:squeezeMask:name:";
		static readonly NativeHandle selSliceGradientTensor_FwdInShapeTensor_StartTensor_SizeTensor_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:startTensor:sizeTensor:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceGradientTensor_FwdInShapeTensor_Starts_Ends_Strides_Name_X = "sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:name:";
		static readonly NativeHandle selSliceGradientTensor_FwdInShapeTensor_Starts_Ends_Strides_Name_XHandle = Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceGradientTensor_FwdInShapeTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_X = "sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:";
		static readonly NativeHandle selSliceGradientTensor_FwdInShapeTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceTensor_Dimension_Start_Length_Name_X = "sliceTensor:dimension:start:length:name:";
		static readonly NativeHandle selSliceTensor_Dimension_Start_Length_Name_XHandle = Selector.GetHandle ("sliceTensor:dimension:start:length:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceTensor_StartTensor_EndTensor_StrideTensor_StartMask_EndMask_SqueezeMask_Name_X = "sliceTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:";
		static readonly NativeHandle selSliceTensor_StartTensor_EndTensor_StrideTensor_StartMask_EndMask_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceTensor_StartTensor_SizeTensor_SqueezeMask_Name_X = "sliceTensor:startTensor:sizeTensor:squeezeMask:name:";
		static readonly NativeHandle selSliceTensor_StartTensor_SizeTensor_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceTensor:startTensor:sizeTensor:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceTensor_Starts_Ends_Strides_Name_X = "sliceTensor:starts:ends:strides:name:";
		static readonly NativeHandle selSliceTensor_Starts_Ends_Strides_Name_XHandle = Selector.GetHandle ("sliceTensor:starts:ends:strides:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_X = "sliceTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:";
		static readonly NativeHandle selSliceTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceUpdateDataTensor_UpdateTensor_Starts_Ends_Strides_Name_X = "sliceUpdateDataTensor:updateTensor:starts:ends:strides:name:";
		static readonly NativeHandle selSliceUpdateDataTensor_UpdateTensor_Starts_Ends_Strides_Name_XHandle = Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceUpdateDataTensor_UpdateTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_X = "sliceUpdateDataTensor:updateTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:";
		static readonly NativeHandle selSliceUpdateDataTensor_UpdateTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceUpdateDataTensor_UpdateTensor_StartsTensor_EndsTensor_StridesTensor_Name_X = "sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:name:";
		static readonly NativeHandle selSliceUpdateDataTensor_UpdateTensor_StartsTensor_EndsTensor_StridesTensor_Name_XHandle = Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSliceUpdateDataTensor_UpdateTensor_StartsTensor_EndsTensor_StridesTensor_StartMask_EndMask_SqueezeMask_Name_X = "sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:startMask:endMask:squeezeMask:name:";
		static readonly NativeHandle selSliceUpdateDataTensor_UpdateTensor_StartsTensor_EndsTensor_StridesTensor_StartMask_EndMask_SqueezeMask_Name_XHandle = Selector.GetHandle ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:startMask:endMask:squeezeMask:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpaceToBatchTensor_SpatialAxes_BatchAxis_BlockDimensions_UsePixelShuffleOrder_Name_X = "spaceToBatchTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:";
		static readonly NativeHandle selSpaceToBatchTensor_SpatialAxes_BatchAxis_BlockDimensions_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("spaceToBatchTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpaceToBatchTensor_SpatialAxesTensor_BatchAxisTensor_BlockDimensionsTensor_UsePixelShuffleOrder_Name_X = "spaceToBatchTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:";
		static readonly NativeHandle selSpaceToBatchTensor_SpatialAxesTensor_BatchAxisTensor_BlockDimensionsTensor_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("spaceToBatchTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpaceToDepth2DTensor_WidthAxis_HeightAxis_DepthAxis_BlockSize_UsePixelShuffleOrder_Name_X = "spaceToDepth2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:";
		static readonly NativeHandle selSpaceToDepth2DTensor_WidthAxis_HeightAxis_DepthAxis_BlockSize_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("spaceToDepth2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSpaceToDepth2DTensor_WidthAxisTensor_HeightAxisTensor_DepthAxisTensor_BlockSize_UsePixelShuffleOrder_Name_X = "spaceToDepth2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:";
		static readonly NativeHandle selSpaceToDepth2DTensor_WidthAxisTensor_HeightAxisTensor_DepthAxisTensor_BlockSize_UsePixelShuffleOrder_Name_XHandle = Selector.GetHandle ("spaceToDepth2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitTensor_NumSplits_Axis_Name_X = "splitTensor:numSplits:axis:name:";
		static readonly NativeHandle selSplitTensor_NumSplits_Axis_Name_XHandle = Selector.GetHandle ("splitTensor:numSplits:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitTensor_SplitSizes_Axis_Name_X = "splitTensor:splitSizes:axis:name:";
		static readonly NativeHandle selSplitTensor_SplitSizes_Axis_Name_XHandle = Selector.GetHandle ("splitTensor:splitSizes:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSplitTensor_SplitSizesTensor_Axis_Name_X = "splitTensor:splitSizesTensor:axis:name:";
		static readonly NativeHandle selSplitTensor_SplitSizesTensor_Axis_Name_XHandle = Selector.GetHandle ("splitTensor:splitSizesTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSqueezeTensor_Axes_Name_X = "squeezeTensor:axes:name:";
		static readonly NativeHandle selSqueezeTensor_Axes_Name_XHandle = Selector.GetHandle ("squeezeTensor:axes:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSqueezeTensor_AxesTensor_Name_X = "squeezeTensor:axesTensor:name:";
		static readonly NativeHandle selSqueezeTensor_AxesTensor_Name_XHandle = Selector.GetHandle ("squeezeTensor:axesTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSqueezeTensor_Axis_Name_X = "squeezeTensor:axis:name:";
		static readonly NativeHandle selSqueezeTensor_Axis_Name_XHandle = Selector.GetHandle ("squeezeTensor:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSqueezeTensor_Name_X = "squeezeTensor:name:";
		static readonly NativeHandle selSqueezeTensor_Name_XHandle = Selector.GetHandle ("squeezeTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selStackTensors_Axis_Name_X = "stackTensors:axis:name:";
		static readonly NativeHandle selStackTensors_Axis_Name_XHandle = Selector.GetHandle ("stackTensors:axis:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileGradientWithIncomingGradientTensor_SourceTensor_WithMultiplier_Name_X = "tileGradientWithIncomingGradientTensor:sourceTensor:withMultiplier:name:";
		static readonly NativeHandle selTileGradientWithIncomingGradientTensor_SourceTensor_WithMultiplier_Name_XHandle = Selector.GetHandle ("tileGradientWithIncomingGradientTensor:sourceTensor:withMultiplier:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTileTensor_WithMultiplier_Name_X = "tileTensor:withMultiplier:name:";
		static readonly NativeHandle selTileTensor_WithMultiplier_Name_XHandle = Selector.GetHandle ("tileTensor:withMultiplier:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransposeTensor_Dimension_WithDimension_Name_X = "transposeTensor:dimension:withDimension:name:";
		static readonly NativeHandle selTransposeTensor_Dimension_WithDimension_Name_XHandle = Selector.GetHandle ("transposeTensor:dimension:withDimension:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTransposeTensor_Permutation_Name_X = "transposeTensor:permutation:name:";
		static readonly NativeHandle selTransposeTensor_Permutation_Name_XHandle = Selector.GetHandle ("transposeTensor:permutation:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("batchToSpaceTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BatchToSpace (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] spatialAxes, nint batchAxis, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] blockDimensions, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (spatialAxes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spatialAxes));
			if (blockDimensions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockDimensions));
			using var nsb_spatialAxes = NSArray.FromNSObjects (o => new NSNumber (o), spatialAxes);
			using var nsb_blockDimensions = NSArray.FromNSObjects (o => new NSNumber (o), blockDimensions);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_bool_NativeHandle (This.Handle, selBatchToSpaceTensor_SpatialAxes_BatchAxis_BlockDimensions_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, nsb_spatialAxes.GetHandle (), batchAxis, nsb_blockDimensions.GetHandle (), usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("batchToSpaceTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BatchToSpace (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor spatialAxesTensor, MPSGraphTensor batchAxisTensor, MPSGraphTensor blockDimensionsTensor, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var spatialAxesTensor__handle__ = spatialAxesTensor!.GetNonNullHandle (nameof (spatialAxesTensor));
			var batchAxisTensor__handle__ = batchAxisTensor!.GetNonNullHandle (nameof (batchAxisTensor));
			var blockDimensionsTensor__handle__ = blockDimensionsTensor!.GetNonNullHandle (nameof (blockDimensionsTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, selBatchToSpaceTensor_SpatialAxesTensor_BatchAxisTensor_BlockDimensionsTensor_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, spatialAxesTensor__handle__, batchAxisTensor__handle__, blockDimensionsTensor__handle__, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (spatialAxesTensor);
			GC.KeepAlive (batchAxisTensor);
			GC.KeepAlive (blockDimensionsTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("broadcastTensor:toShape:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Broadcast (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBroadcastTensor_ToShape_Name_XHandle, tensor__handle__, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("broadcastTensor:toShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Broadcast (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor shapeTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBroadcastTensor_ToShapeTensor_Name_XHandle, tensor__handle__, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("castTensor:toType:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Cast (this MPSGraph This, MPSGraphTensor tensor, global::MetalPerformanceShaders.MPSDataType type, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt32_NativeHandle (This.Handle, selCastTensor_ToType_Name_XHandle, tensor__handle__, (UInt32)type, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("concatTensor:withTensor:dimension:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Concat (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor tensor2, nint dimensionIndex, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var tensor2__handle__ = tensor2!.GetNonNullHandle (nameof (tensor2));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, selConcatTensor_WithTensor_Dimension_Name_XHandle, tensor__handle__, tensor2__handle__, dimensionIndex, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (tensor2);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("concatTensors:dimension:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConcatTensors (this MPSGraph This, MPSGraphTensor[] tensors, nint dimensionIndex, string? name)
		{
			if (tensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tensors));
			using var nsa_tensors = NSArray.FromNSObjects (tensors);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selConcatTensors_Dimension_Name_XHandle, nsa_tensors.Handle, dimensionIndex, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("concatTensors:dimension:interleave:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ConcatTensors (this MPSGraph This, MPSGraphTensor[] tensors, nint dimensionIndex, bool interleave, string? name)
		{
			if (tensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (tensors));
			using var nsa_tensors = NSArray.FromNSObjects (tensors);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_bool_NativeHandle (This.Handle, selConcatTensors_Dimension_Interleave_Name_XHandle, nsa_tensors.Handle, dimensionIndex, interleave ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxis:withShape:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, nint axis, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (This.Handle, selCoordinateAlongAxis_WithShape_Name_XHandle, axis, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxisTensor:withShape:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, MPSGraphTensor axisTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selCoordinateAlongAxisTensor_WithShape_Name_XHandle, axisTensor__handle__, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxis:withShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, nint axis, MPSGraphTensor shapeTensor, string? name)
		{
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_IntPtr_NativeHandle_NativeHandle (This.Handle, selCoordinateAlongAxis_WithShapeTensor_Name_XHandle, axis, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coordinateAlongAxisTensor:withShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor CoordinateAlongAxis (this MPSGraph This, MPSGraphTensor axisTensor, MPSGraphTensor shapeTensor, string? name)
		{
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selCoordinateAlongAxisTensor_WithShapeTensor_Name_XHandle, axisTensor__handle__, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (axisTensor);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthToSpace2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthToSpace2D (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor widthAxisTensor, MPSGraphTensor heightAxisTensor, MPSGraphTensor depthAxisTensor, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var widthAxisTensor__handle__ = widthAxisTensor!.GetNonNullHandle (nameof (widthAxisTensor));
			var heightAxisTensor__handle__ = heightAxisTensor!.GetNonNullHandle (nameof (heightAxisTensor));
			var depthAxisTensor__handle__ = depthAxisTensor!.GetNonNullHandle (nameof (depthAxisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_bool_NativeHandle (This.Handle, selDepthToSpace2DTensor_WidthAxisTensor_HeightAxisTensor_DepthAxisTensor_BlockSize_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, widthAxisTensor__handle__, heightAxisTensor__handle__, depthAxisTensor__handle__, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (widthAxisTensor);
			GC.KeepAlive (heightAxisTensor);
			GC.KeepAlive (depthAxisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("depthToSpace2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DepthToSpace2D (this MPSGraph This, MPSGraphTensor tensor, nuint widthAxis, nuint heightAxis, nuint depthAxis, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr_bool_NativeHandle (This.Handle, selDepthToSpace2DTensor_WidthAxis_HeightAxis_DepthAxis_BlockSize_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, widthAxis, heightAxis, depthAxis, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expandDimsOfTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExpandDims (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selExpandDimsOfTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expandDimsOfTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExpandDims (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selExpandDimsOfTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("expandDimsOfTensor:axesTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExpandDims (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selExpandDimsOfTensor_AxesTensor_Name_XHandle, tensor__handle__, axesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("flatten2DTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Flatten2D (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selFlatten2DTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("flatten2DTensor:axisTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Flatten2D (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axisTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axisTensor__handle__ = axisTensor!.GetNonNullHandle (nameof (axisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selFlatten2DTensor_AxisTensor_Name_XHandle, tensor__handle__, axisTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("padTensor:withPaddingMode:leftPadding:rightPadding:constantValue:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Pad (this MPSGraph This, MPSGraphTensor tensor, MPSGraphPaddingMode paddingMode, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] leftPadding, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] rightPadding, double constantValue, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (leftPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leftPadding));
			if (rightPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rightPadding));
			using var nsb_leftPadding = NSArray.FromNSObjects (o => new NSNumber (o), leftPadding);
			using var nsb_rightPadding = NSArray.FromNSObjects (o => new NSNumber (o), rightPadding);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle_NativeHandle_Double_NativeHandle (This.Handle, selPadTensor_WithPaddingMode_LeftPadding_RightPadding_ConstantValue_Name_XHandle, tensor__handle__, (IntPtr) (long) paddingMode, nsb_leftPadding.GetHandle (), nsb_rightPadding.GetHandle (), constantValue, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("padGradientWithIncomingGradientTensor:sourceTensor:paddingMode:leftPadding:rightPadding:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor PadGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor sourceTensor, MPSGraphPaddingMode paddingMode, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] leftPadding, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] rightPadding, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			if (leftPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (leftPadding));
			if (rightPadding is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (rightPadding));
			using var nsb_leftPadding = NSArray.FromNSObjects (o => new NSNumber (o), leftPadding);
			using var nsb_rightPadding = NSArray.FromNSObjects (o => new NSNumber (o), rightPadding);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_NativeHandle_NativeHandle (This.Handle, selPadGradientWithIncomingGradientTensor_SourceTensor_PaddingMode_LeftPadding_RightPadding_Name_XHandle, incomingGradientTensor__handle__, sourceTensor__handle__, (IntPtr) (long) paddingMode, nsb_leftPadding.GetHandle (), nsb_rightPadding.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (sourceTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reinterpretCastTensor:toType:name:")]
		[SupportedOSPlatform ("tvos16.3")]
		[SupportedOSPlatform ("macos13.2")]
		[SupportedOSPlatform ("ios16.3")]
		[SupportedOSPlatform ("maccatalyst16.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReinterpretCast (this MPSGraph This, MPSGraphTensor tensor, global::MetalPerformanceShaders.MPSDataType type, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UInt32_NativeHandle (This.Handle, selReinterpretCastTensor_ToType_Name_XHandle, tensor__handle__, (UInt32)type, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reshapeTensor:withShape:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reshape (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] shape, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (shape is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (shape));
			using var nsb_shape = NSArray.FromNSObjects (o => new NSNumber (o), shape);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReshapeTensor_WithShape_Name_XHandle, tensor__handle__, nsb_shape.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reshapeTensor:withShapeTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reshape (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor shapeTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var shapeTensor__handle__ = shapeTensor!.GetNonNullHandle (nameof (shapeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReshapeTensor_WithShapeTensor_Name_XHandle, tensor__handle__, shapeTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (shapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseTensor:axesTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reverse (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReverseTensor_AxesTensor_Name_XHandle, tensor__handle__, axesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reverse (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selReverseTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reverse (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selReverseTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("shapeOfTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Shape (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selShapeOfTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:dimension:start:length:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, nuint dimensionIndex, nint start, nint length, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_IntPtr_NativeHandle (This.Handle, selSliceTensor_Dimension_Start_Length_Name_XHandle, tensor__handle__, dimensionIndex, start, length, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:starts:ends:strides:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSliceTensor_Starts_Ends_Strides_Name_XHandle, tensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, selSliceTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_XHandle, tensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor startTensor, MPSGraphTensor endTensor, MPSGraphTensor strideTensor, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var endTensor__handle__ = endTensor!.GetNonNullHandle (nameof (endTensor));
			var strideTensor__handle__ = strideTensor!.GetNonNullHandle (nameof (strideTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, selSliceTensor_StartTensor_EndTensor_StrideTensor_StartMask_EndMask_SqueezeMask_Name_XHandle, tensor__handle__, startTensor__handle__, endTensor__handle__, strideTensor__handle__, startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (endTensor);
			GC.KeepAlive (strideTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceTensor:startTensor:sizeTensor:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Slice (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor startTensor, MPSGraphTensor sizeTensor, uint squeezeMask, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var sizeTensor__handle__ = sizeTensor!.GetNonNullHandle (nameof (sizeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, selSliceTensor_StartTensor_SizeTensor_SqueezeMask_Name_XHandle, tensor__handle__, startTensor__handle__, sizeTensor__handle__, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (sizeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSliceGradientTensor_FwdInShapeTensor_Starts_Ends_Strides_Name_XHandle, inputGradientTensor__handle__, fwdInShapeTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, selSliceGradientTensor_FwdInShapeTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_XHandle, inputGradientTensor__handle__, fwdInShapeTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:startTensor:endTensor:strideTensor:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, MPSGraphTensor startTensor, MPSGraphTensor endTensor, MPSGraphTensor strideTensor, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var endTensor__handle__ = endTensor!.GetNonNullHandle (nameof (endTensor));
			var strideTensor__handle__ = strideTensor!.GetNonNullHandle (nameof (strideTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, selSliceGradientTensor_FwdInShapeTensor_StartTensor_EndTensor_StrideTensor_StartMask_EndMask_SqueezeMask_Name_XHandle, inputGradientTensor__handle__, fwdInShapeTensor__handle__, startTensor__handle__, endTensor__handle__, strideTensor__handle__, startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (endTensor);
			GC.KeepAlive (strideTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceGradientTensor:fwdInShapeTensor:startTensor:sizeTensor:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos18.2")]
		[SupportedOSPlatform ("maccatalyst18.2")]
		[SupportedOSPlatform ("macos15.2")]
		[SupportedOSPlatform ("ios18.2")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceGradient (this MPSGraph This, MPSGraphTensor inputGradientTensor, MPSGraphTensor fwdInShapeTensor, MPSGraphTensor startTensor, MPSGraphTensor sizeTensor, uint squeezeMask, string? name)
		{
			var inputGradientTensor__handle__ = inputGradientTensor!.GetNonNullHandle (nameof (inputGradientTensor));
			var fwdInShapeTensor__handle__ = fwdInShapeTensor!.GetNonNullHandle (nameof (fwdInShapeTensor));
			var startTensor__handle__ = startTensor!.GetNonNullHandle (nameof (startTensor));
			var sizeTensor__handle__ = sizeTensor!.GetNonNullHandle (nameof (sizeTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_NativeHandle (This.Handle, selSliceGradientTensor_FwdInShapeTensor_StartTensor_SizeTensor_SqueezeMask_Name_XHandle, inputGradientTensor__handle__, fwdInShapeTensor__handle__, startTensor__handle__, sizeTensor__handle__, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (inputGradientTensor);
			GC.KeepAlive (fwdInShapeTensor);
			GC.KeepAlive (startTensor);
			GC.KeepAlive (sizeTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updateTensor, MPSGraphTensor startsTensor, MPSGraphTensor endsTensor, MPSGraphTensor stridesTensor, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updateTensor__handle__ = updateTensor!.GetNonNullHandle (nameof (updateTensor));
			var startsTensor__handle__ = startsTensor!.GetNonNullHandle (nameof (startsTensor));
			var endsTensor__handle__ = endsTensor!.GetNonNullHandle (nameof (endsTensor));
			var stridesTensor__handle__ = stridesTensor!.GetNonNullHandle (nameof (stridesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, selSliceUpdateDataTensor_UpdateTensor_StartsTensor_EndsTensor_StridesTensor_StartMask_EndMask_SqueezeMask_Name_XHandle, dataTensor__handle__, updateTensor__handle__, startsTensor__handle__, endsTensor__handle__, stridesTensor__handle__, startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updateTensor);
			GC.KeepAlive (startsTensor);
			GC.KeepAlive (endsTensor);
			GC.KeepAlive (stridesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:startMask:endMask:squeezeMask:name:")]
		[SupportedOSPlatform ("tvos17.4")]
		[SupportedOSPlatform ("macos14.4")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updateTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, uint startMask, uint endMask, uint squeezeMask, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updateTensor__handle__ = updateTensor!.GetNonNullHandle (nameof (updateTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UInt32_UInt32_UInt32_NativeHandle (This.Handle, selSliceUpdateDataTensor_UpdateTensor_Starts_Ends_Strides_StartMask_EndMask_SqueezeMask_Name_XHandle, dataTensor__handle__, updateTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), startMask, endMask, squeezeMask, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updateTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:startsTensor:endsTensor:stridesTensor:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updatesTensor, MPSGraphTensor startsTensor, MPSGraphTensor endsTensor, MPSGraphTensor stridesTensor, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			var startsTensor__handle__ = startsTensor!.GetNonNullHandle (nameof (startsTensor));
			var endsTensor__handle__ = endsTensor!.GetNonNullHandle (nameof (endsTensor));
			var stridesTensor__handle__ = stridesTensor!.GetNonNullHandle (nameof (stridesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSliceUpdateDataTensor_UpdateTensor_StartsTensor_EndsTensor_StridesTensor_Name_XHandle, dataTensor__handle__, updatesTensor__handle__, startsTensor__handle__, endsTensor__handle__, stridesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updatesTensor);
			GC.KeepAlive (startsTensor);
			GC.KeepAlive (endsTensor);
			GC.KeepAlive (stridesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sliceUpdateDataTensor:updateTensor:starts:ends:strides:name:")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SliceUpdateData (this MPSGraph This, MPSGraphTensor dataTensor, MPSGraphTensor updatesTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] starts, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] ends, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] strides, string? name)
		{
			var dataTensor__handle__ = dataTensor!.GetNonNullHandle (nameof (dataTensor));
			var updatesTensor__handle__ = updatesTensor!.GetNonNullHandle (nameof (updatesTensor));
			if (starts is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (starts));
			if (ends is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (ends));
			if (strides is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strides));
			using var nsb_starts = NSArray.FromNSObjects (o => new NSNumber (o), starts);
			using var nsb_ends = NSArray.FromNSObjects (o => new NSNumber (o), ends);
			using var nsb_strides = NSArray.FromNSObjects (o => new NSNumber (o), strides);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSliceUpdateDataTensor_UpdateTensor_Starts_Ends_Strides_Name_XHandle, dataTensor__handle__, updatesTensor__handle__, nsb_starts.GetHandle (), nsb_ends.GetHandle (), nsb_strides.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (dataTensor);
			GC.KeepAlive (updatesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToBatchTensor:spatialAxes:batchAxis:blockDimensions:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToBatch (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] spatialAxes, nint batchAxis, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] blockDimensions, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (spatialAxes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spatialAxes));
			if (blockDimensions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (blockDimensions));
			using var nsb_spatialAxes = NSArray.FromNSObjects (o => new NSNumber (o), spatialAxes);
			using var nsb_blockDimensions = NSArray.FromNSObjects (o => new NSNumber (o), blockDimensions);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle_bool_NativeHandle (This.Handle, selSpaceToBatchTensor_SpatialAxes_BatchAxis_BlockDimensions_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, nsb_spatialAxes.GetHandle (), batchAxis, nsb_blockDimensions.GetHandle (), usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToBatchTensor:spatialAxesTensor:batchAxisTensor:blockDimensionsTensor:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToBatch (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor spatialAxesTensor, MPSGraphTensor batchAxisTensor, MPSGraphTensor blockDimensionsTensor, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var spatialAxesTensor__handle__ = spatialAxesTensor!.GetNonNullHandle (nameof (spatialAxesTensor));
			var batchAxisTensor__handle__ = batchAxisTensor!.GetNonNullHandle (nameof (batchAxisTensor));
			var blockDimensionsTensor__handle__ = blockDimensionsTensor!.GetNonNullHandle (nameof (blockDimensionsTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_bool_NativeHandle (This.Handle, selSpaceToBatchTensor_SpatialAxesTensor_BatchAxisTensor_BlockDimensionsTensor_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, spatialAxesTensor__handle__, batchAxisTensor__handle__, blockDimensionsTensor__handle__, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (spatialAxesTensor);
			GC.KeepAlive (batchAxisTensor);
			GC.KeepAlive (blockDimensionsTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToDepth2DTensor:widthAxisTensor:heightAxisTensor:depthAxisTensor:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToDepth2D (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor widthAxisTensor, MPSGraphTensor heightAxisTensor, MPSGraphTensor depthAxisTensor, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var widthAxisTensor__handle__ = widthAxisTensor!.GetNonNullHandle (nameof (widthAxisTensor));
			var heightAxisTensor__handle__ = heightAxisTensor!.GetNonNullHandle (nameof (heightAxisTensor));
			var depthAxisTensor__handle__ = depthAxisTensor!.GetNonNullHandle (nameof (depthAxisTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_UIntPtr_bool_NativeHandle (This.Handle, selSpaceToDepth2DTensor_WidthAxisTensor_HeightAxisTensor_DepthAxisTensor_BlockSize_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, widthAxisTensor__handle__, heightAxisTensor__handle__, depthAxisTensor__handle__, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (widthAxisTensor);
			GC.KeepAlive (heightAxisTensor);
			GC.KeepAlive (depthAxisTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("spaceToDepth2DTensor:widthAxis:heightAxis:depthAxis:blockSize:usePixelShuffleOrder:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SpaceToDepth2D (this MPSGraph This, MPSGraphTensor tensor, nuint widthAxis, nuint heightAxis, nuint depthAxis, nuint blockSize, bool usePixelShuffleOrder, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_UIntPtr_UIntPtr_bool_NativeHandle (This.Handle, selSpaceToDepth2DTensor_WidthAxis_HeightAxis_DepthAxis_BlockSize_UsePixelShuffleOrder_Name_XHandle, tensor__handle__, widthAxis, heightAxis, depthAxis, blockSize, usePixelShuffleOrder ? (byte) 1 : (byte) 0, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("splitTensor:splitSizes:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Split (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] splitSizes, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (splitSizes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (splitSizes));
			using var nsb_splitSizes = NSArray.FromNSObjects (o => new NSNumber (o), splitSizes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, selSplitTensor_SplitSizes_Axis_Name_XHandle, tensor__handle__, nsb_splitSizes.GetHandle (), axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("splitTensor:splitSizesTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Split (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor splitSizesTensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var splitSizesTensor__handle__ = splitSizesTensor!.GetNonNullHandle (nameof (splitSizesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_IntPtr_NativeHandle (This.Handle, selSplitTensor_SplitSizesTensor_Axis_Name_XHandle, tensor__handle__, splitSizesTensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (splitSizesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("splitTensor:numSplits:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor[] Split (this MPSGraph This, MPSGraphTensor tensor, nuint numSplits, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_IntPtr_NativeHandle (This.Handle, selSplitTensor_NumSplits_Axis_Name_XHandle, tensor__handle__, numSplits, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSqueezeTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, nint axis, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selSqueezeTensor_Axis_Name_XHandle, tensor__handle__, axis, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:axes:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] axes, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (axes is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (axes));
			using var nsb_axes = NSArray.FromNSObjects (o => new NSNumber (o), axes);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSqueezeTensor_Axes_Name_XHandle, tensor__handle__, nsb_axes.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squeezeTensor:axesTensor:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Squeeze (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor axesTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var axesTensor__handle__ = axesTensor!.GetNonNullHandle (nameof (axesTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSqueezeTensor_AxesTensor_Name_XHandle, tensor__handle__, axesTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (axesTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("stackTensors:axis:name:")]
		[SupportedOSPlatform ("tvos15.4")]
		[SupportedOSPlatform ("macos12.3")]
		[SupportedOSPlatform ("ios15.4")]
		[SupportedOSPlatform ("maccatalyst15.4")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Stack (this MPSGraph This, MPSGraphTensor[] inputTensors, nint axis, string? name)
		{
			if (inputTensors is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputTensors));
			using var nsa_inputTensors = NSArray.FromNSObjects (inputTensors);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_IntPtr_NativeHandle (This.Handle, selStackTensors_Axis_Name_XHandle, nsa_inputTensors.Handle, axis, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tileTensor:withMultiplier:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Tile (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] multiplier, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (multiplier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (multiplier));
			using var nsb_multiplier = NSArray.FromNSObjects (o => new NSNumber (o), multiplier);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selTileTensor_WithMultiplier_Name_XHandle, tensor__handle__, nsb_multiplier.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tileGradientWithIncomingGradientTensor:sourceTensor:withMultiplier:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor TileGradient (this MPSGraph This, MPSGraphTensor incomingGradientTensor, MPSGraphTensor sourceTensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] multiplier, string? name)
		{
			var incomingGradientTensor__handle__ = incomingGradientTensor!.GetNonNullHandle (nameof (incomingGradientTensor));
			var sourceTensor__handle__ = sourceTensor!.GetNonNullHandle (nameof (sourceTensor));
			if (multiplier is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (multiplier));
			using var nsb_multiplier = NSArray.FromNSObjects (o => new NSNumber (o), multiplier);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selTileGradientWithIncomingGradientTensor_SourceTensor_WithMultiplier_Name_XHandle, incomingGradientTensor__handle__, sourceTensor__handle__, nsb_multiplier.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (incomingGradientTensor);
			GC.KeepAlive (sourceTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("transposeTensor:dimension:withDimension:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Transpose (this MPSGraph This, MPSGraphTensor tensor, nuint dimensionIndex, nuint dimensionIndex2, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_NativeHandle (This.Handle, selTransposeTensor_Dimension_WithDimension_Name_XHandle, tensor__handle__, dimensionIndex, dimensionIndex2, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("transposeTensor:permutation:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Transpose (this MPSGraph This, MPSGraphTensor tensor, [BindAs (typeof (int[]), OriginalType = typeof (NSNumber[]))] int[] permutation, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			if (permutation is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (permutation));
			using var nsb_permutation = NSArray.FromNSObjects (o => new NSNumber (o), permutation);
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selTransposeTensor_Permutation_Name_XHandle, tensor__handle__, nsb_permutation.GetHandle (), nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphTensorShapeOps */
}
