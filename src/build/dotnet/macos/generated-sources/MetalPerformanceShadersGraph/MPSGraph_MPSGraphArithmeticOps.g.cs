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
	public unsafe static partial class MPSGraph_MPSGraphArithmeticOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteSquareWithTensor_Name_X = "absoluteSquareWithTensor:name:";
		static readonly NativeHandle selAbsoluteSquareWithTensor_Name_XHandle = Selector.GetHandle ("absoluteSquareWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAbsoluteWithTensor_Name_X = "absoluteWithTensor:name:";
		static readonly NativeHandle selAbsoluteWithTensor_Name_XHandle = Selector.GetHandle ("absoluteWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcosWithTensor_Name_X = "acosWithTensor:name:";
		static readonly NativeHandle selAcosWithTensor_Name_XHandle = Selector.GetHandle ("acosWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAcoshWithTensor_Name_X = "acoshWithTensor:name:";
		static readonly NativeHandle selAcoshWithTensor_Name_XHandle = Selector.GetHandle ("acoshWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAdditionWithPrimaryTensor_SecondaryTensor_Name_X = "additionWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selAdditionWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("additionWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAsinWithTensor_Name_X = "asinWithTensor:name:";
		static readonly NativeHandle selAsinWithTensor_Name_XHandle = Selector.GetHandle ("asinWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAsinhWithTensor_Name_X = "asinhWithTensor:name:";
		static readonly NativeHandle selAsinhWithTensor_Name_XHandle = Selector.GetHandle ("asinhWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAtan2WithPrimaryTensor_SecondaryTensor_Name_X = "atan2WithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selAtan2WithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("atan2WithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAtanWithTensor_Name_X = "atanWithTensor:name:";
		static readonly NativeHandle selAtanWithTensor_Name_XHandle = Selector.GetHandle ("atanWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selAtanhWithTensor_Name_X = "atanhWithTensor:name:";
		static readonly NativeHandle selAtanhWithTensor_Name_XHandle = Selector.GetHandle ("atanhWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitwiseANDWithPrimaryTensor_SecondaryTensor_Name_X = "bitwiseANDWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selBitwiseANDWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("bitwiseANDWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitwiseLeftShiftWithPrimaryTensor_SecondaryTensor_Name_X = "bitwiseLeftShiftWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selBitwiseLeftShiftWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("bitwiseLeftShiftWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitwiseNOTWithTensor_Name_X = "bitwiseNOTWithTensor:name:";
		static readonly NativeHandle selBitwiseNOTWithTensor_Name_XHandle = Selector.GetHandle ("bitwiseNOTWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitwiseORWithPrimaryTensor_SecondaryTensor_Name_X = "bitwiseORWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selBitwiseORWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("bitwiseORWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitwisePopulationCountWithTensor_Name_X = "bitwisePopulationCountWithTensor:name:";
		static readonly NativeHandle selBitwisePopulationCountWithTensor_Name_XHandle = Selector.GetHandle ("bitwisePopulationCountWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitwiseRightShiftWithPrimaryTensor_SecondaryTensor_Name_X = "bitwiseRightShiftWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selBitwiseRightShiftWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("bitwiseRightShiftWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selBitwiseXORWithPrimaryTensor_SecondaryTensor_Name_X = "bitwiseXORWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selBitwiseXORWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("bitwiseXORWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCeilWithTensor_Name_X = "ceilWithTensor:name:";
		static readonly NativeHandle selCeilWithTensor_Name_XHandle = Selector.GetHandle ("ceilWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selClampWithTensor_MinValueTensor_MaxValueTensor_Name_X = "clampWithTensor:minValueTensor:maxValueTensor:name:";
		static readonly NativeHandle selClampWithTensor_MinValueTensor_MaxValueTensor_Name_XHandle = Selector.GetHandle ("clampWithTensor:minValueTensor:maxValueTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selComplexTensorWithRealTensor_ImaginaryTensor_Name_X = "complexTensorWithRealTensor:imaginaryTensor:name:";
		static readonly NativeHandle selComplexTensorWithRealTensor_ImaginaryTensor_Name_XHandle = Selector.GetHandle ("complexTensorWithRealTensor:imaginaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selConjugateWithTensor_Name_X = "conjugateWithTensor:name:";
		static readonly NativeHandle selConjugateWithTensor_Name_XHandle = Selector.GetHandle ("conjugateWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCosWithTensor_Name_X = "cosWithTensor:name:";
		static readonly NativeHandle selCosWithTensor_Name_XHandle = Selector.GetHandle ("cosWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selCoshWithTensor_Name_X = "coshWithTensor:name:";
		static readonly NativeHandle selCoshWithTensor_Name_XHandle = Selector.GetHandle ("coshWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDivisionNoNaNWithPrimaryTensor_SecondaryTensor_Name_X = "divisionNoNaNWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selDivisionNoNaNWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("divisionNoNaNWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selDivisionWithPrimaryTensor_SecondaryTensor_Name_X = "divisionWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selDivisionWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("divisionWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selEqualWithPrimaryTensor_SecondaryTensor_Name_X = "equalWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selEqualWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("equalWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selErfWithTensor_Name_X = "erfWithTensor:name:";
		static readonly NativeHandle selErfWithTensor_Name_XHandle = Selector.GetHandle ("erfWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExponentBase10WithTensor_Name_X = "exponentBase10WithTensor:name:";
		static readonly NativeHandle selExponentBase10WithTensor_Name_XHandle = Selector.GetHandle ("exponentBase10WithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExponentBase2WithTensor_Name_X = "exponentBase2WithTensor:name:";
		static readonly NativeHandle selExponentBase2WithTensor_Name_XHandle = Selector.GetHandle ("exponentBase2WithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selExponentWithTensor_Name_X = "exponentWithTensor:name:";
		static readonly NativeHandle selExponentWithTensor_Name_XHandle = Selector.GetHandle ("exponentWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloorModuloWithPrimaryTensor_SecondaryTensor_Name_X = "floorModuloWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selFloorModuloWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("floorModuloWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selFloorWithTensor_Name_X = "floorWithTensor:name:";
		static readonly NativeHandle selFloorWithTensor_Name_XHandle = Selector.GetHandle ("floorWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGreaterThanOrEqualToWithPrimaryTensor_SecondaryTensor_Name_X = "greaterThanOrEqualToWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selGreaterThanOrEqualToWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("greaterThanOrEqualToWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selGreaterThanWithPrimaryTensor_SecondaryTensor_Name_X = "greaterThanWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selGreaterThanWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("greaterThanWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIdentityWithTensor_Name_X = "identityWithTensor:name:";
		static readonly NativeHandle selIdentityWithTensor_Name_XHandle = Selector.GetHandle ("identityWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selImaginaryPartOfTensor_Name_X = "imaginaryPartOfTensor:name:";
		static readonly NativeHandle selImaginaryPartOfTensor_Name_XHandle = Selector.GetHandle ("imaginaryPartOfTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsFiniteWithTensor_Name_X = "isFiniteWithTensor:name:";
		static readonly NativeHandle selIsFiniteWithTensor_Name_XHandle = Selector.GetHandle ("isFiniteWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsInfiniteWithTensor_Name_X = "isInfiniteWithTensor:name:";
		static readonly NativeHandle selIsInfiniteWithTensor_Name_XHandle = Selector.GetHandle ("isInfiniteWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIsNaNWithTensor_Name_X = "isNaNWithTensor:name:";
		static readonly NativeHandle selIsNaNWithTensor_Name_XHandle = Selector.GetHandle ("isNaNWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLessThanOrEqualToWithPrimaryTensor_SecondaryTensor_Name_X = "lessThanOrEqualToWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLessThanOrEqualToWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("lessThanOrEqualToWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLessThanWithPrimaryTensor_SecondaryTensor_Name_X = "lessThanWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLessThanWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("lessThanWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogarithmBase10WithTensor_Name_X = "logarithmBase10WithTensor:name:";
		static readonly NativeHandle selLogarithmBase10WithTensor_Name_XHandle = Selector.GetHandle ("logarithmBase10WithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogarithmBase2WithTensor_Name_X = "logarithmBase2WithTensor:name:";
		static readonly NativeHandle selLogarithmBase2WithTensor_Name_XHandle = Selector.GetHandle ("logarithmBase2WithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogarithmWithTensor_Name_X = "logarithmWithTensor:name:";
		static readonly NativeHandle selLogarithmWithTensor_Name_XHandle = Selector.GetHandle ("logarithmWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogicalANDWithPrimaryTensor_SecondaryTensor_Name_X = "logicalANDWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLogicalANDWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("logicalANDWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogicalNANDWithPrimaryTensor_SecondaryTensor_Name_X = "logicalNANDWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLogicalNANDWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("logicalNANDWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogicalNORWithPrimaryTensor_SecondaryTensor_Name_X = "logicalNORWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLogicalNORWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("logicalNORWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogicalORWithPrimaryTensor_SecondaryTensor_Name_X = "logicalORWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLogicalORWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("logicalORWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogicalXNORWithPrimaryTensor_SecondaryTensor_Name_X = "logicalXNORWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLogicalXNORWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("logicalXNORWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selLogicalXORWithPrimaryTensor_SecondaryTensor_Name_X = "logicalXORWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selLogicalXORWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("logicalXORWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumWithNaNPropagationWithPrimaryTensor_SecondaryTensor_Name_X = "maximumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selMaximumWithNaNPropagationWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("maximumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMaximumWithPrimaryTensor_SecondaryTensor_Name_X = "maximumWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selMaximumWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("maximumWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumWithNaNPropagationWithPrimaryTensor_SecondaryTensor_Name_X = "minimumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selMinimumWithNaNPropagationWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("minimumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMinimumWithPrimaryTensor_SecondaryTensor_Name_X = "minimumWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selMinimumWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("minimumWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selModuloWithPrimaryTensor_SecondaryTensor_Name_X = "moduloWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selModuloWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("moduloWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selMultiplicationWithPrimaryTensor_SecondaryTensor_Name_X = "multiplicationWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selMultiplicationWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("multiplicationWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNegativeWithTensor_Name_X = "negativeWithTensor:name:";
		static readonly NativeHandle selNegativeWithTensor_Name_XHandle = Selector.GetHandle ("negativeWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotEqualWithPrimaryTensor_SecondaryTensor_Name_X = "notEqualWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selNotEqualWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("notEqualWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selNotWithTensor_Name_X = "notWithTensor:name:";
		static readonly NativeHandle selNotWithTensor_Name_XHandle = Selector.GetHandle ("notWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPlanarTensorWithComplexTensor_Name_X = "planarTensorWithComplexTensor:name:";
		static readonly NativeHandle selPlanarTensorWithComplexTensor_Name_XHandle = Selector.GetHandle ("planarTensorWithComplexTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selPowerWithPrimaryTensor_SecondaryTensor_Name_X = "powerWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selPowerWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("powerWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRealPartOfTensor_Name_X = "realPartOfTensor:name:";
		static readonly NativeHandle selRealPartOfTensor_Name_XHandle = Selector.GetHandle ("realPartOfTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReciprocalSquareRootWithTensor_Name_X = "reciprocalSquareRootWithTensor:name:";
		static readonly NativeHandle selReciprocalSquareRootWithTensor_Name_XHandle = Selector.GetHandle ("reciprocalSquareRootWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReciprocalWithTensor_Name_X = "reciprocalWithTensor:name:";
		static readonly NativeHandle selReciprocalWithTensor_Name_XHandle = Selector.GetHandle ("reciprocalWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selReverseSquareRootWithTensor_Name_X = "reverseSquareRootWithTensor:name:";
		static readonly NativeHandle selReverseSquareRootWithTensor_Name_XHandle = Selector.GetHandle ("reverseSquareRootWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRintWithTensor_Name_X = "rintWithTensor:name:";
		static readonly NativeHandle selRintWithTensor_Name_XHandle = Selector.GetHandle ("rintWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selRoundWithTensor_Name_X = "roundWithTensor:name:";
		static readonly NativeHandle selRoundWithTensor_Name_XHandle = Selector.GetHandle ("roundWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSelectWithPredicateTensor_TruePredicateTensor_FalsePredicateTensor_Name_X = "selectWithPredicateTensor:truePredicateTensor:falsePredicateTensor:name:";
		static readonly NativeHandle selSelectWithPredicateTensor_TruePredicateTensor_FalsePredicateTensor_Name_XHandle = Selector.GetHandle ("selectWithPredicateTensor:truePredicateTensor:falsePredicateTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignWithTensor_Name_X = "signWithTensor:name:";
		static readonly NativeHandle selSignWithTensor_Name_XHandle = Selector.GetHandle ("signWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSignbitWithTensor_Name_X = "signbitWithTensor:name:";
		static readonly NativeHandle selSignbitWithTensor_Name_XHandle = Selector.GetHandle ("signbitWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSinWithTensor_Name_X = "sinWithTensor:name:";
		static readonly NativeHandle selSinWithTensor_Name_XHandle = Selector.GetHandle ("sinWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSinhWithTensor_Name_X = "sinhWithTensor:name:";
		static readonly NativeHandle selSinhWithTensor_Name_XHandle = Selector.GetHandle ("sinhWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSquareRootWithTensor_Name_X = "squareRootWithTensor:name:";
		static readonly NativeHandle selSquareRootWithTensor_Name_XHandle = Selector.GetHandle ("squareRootWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSquareWithTensor_Name_X = "squareWithTensor:name:";
		static readonly NativeHandle selSquareWithTensor_Name_XHandle = Selector.GetHandle ("squareWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selSubtractionWithPrimaryTensor_SecondaryTensor_Name_X = "subtractionWithPrimaryTensor:secondaryTensor:name:";
		static readonly NativeHandle selSubtractionWithPrimaryTensor_SecondaryTensor_Name_XHandle = Selector.GetHandle ("subtractionWithPrimaryTensor:secondaryTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTanWithTensor_Name_X = "tanWithTensor:name:";
		static readonly NativeHandle selTanWithTensor_Name_XHandle = Selector.GetHandle ("tanWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTanhWithTensor_Name_X = "tanhWithTensor:name:";
		static readonly NativeHandle selTanhWithTensor_Name_XHandle = Selector.GetHandle ("tanhWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selTruncateWithTensor_Name_X = "truncateWithTensor:name:";
		static readonly NativeHandle selTruncateWithTensor_Name_XHandle = Selector.GetHandle ("truncateWithTensor:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("absoluteWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Absolute (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAbsoluteWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("absoluteSquareWithTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor AbsoluteSquare (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAbsoluteSquareWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("acosWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Acos (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAcosWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("acoshWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Acosh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAcoshWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("additionWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Addition (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selAdditionWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("asinWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Asin (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAsinWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("asinhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Asinh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAsinhWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("atanWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Atan (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAtanWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("atan2WithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Atan2 (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selAtan2WithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("atanhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Atanh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selAtanhWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseANDWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseAnd (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBitwiseANDWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseLeftShiftWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseLeftShift (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBitwiseLeftShiftWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseNOTWithTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseNot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selBitwiseNOTWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseORWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseOr (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBitwiseORWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwisePopulationCountWithTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwisePopulationCount (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selBitwisePopulationCountWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseRightShiftWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseRightShift (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBitwiseRightShiftWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("bitwiseXORWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos16.1")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.1")]
		[SupportedOSPlatform ("maccatalyst16.1")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor BitwiseXor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selBitwiseXORWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("ceilWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Ceil (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selCeilWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("clampWithTensor:minValueTensor:maxValueTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Clamp (this MPSGraph This, MPSGraphTensor tensor, MPSGraphTensor minValueTensor, MPSGraphTensor maxValueTensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var minValueTensor__handle__ = minValueTensor!.GetNonNullHandle (nameof (minValueTensor));
			var maxValueTensor__handle__ = maxValueTensor!.GetNonNullHandle (nameof (maxValueTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selClampWithTensor_MinValueTensor_MaxValueTensor_Name_XHandle, tensor__handle__, minValueTensor__handle__, maxValueTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			GC.KeepAlive (minValueTensor);
			GC.KeepAlive (maxValueTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("complexTensorWithRealTensor:imaginaryTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ComplexTensor (this MPSGraph This, MPSGraphTensor realTensor, MPSGraphTensor imaginaryTensor, string? name)
		{
			var realTensor__handle__ = realTensor!.GetNonNullHandle (nameof (realTensor));
			var imaginaryTensor__handle__ = imaginaryTensor!.GetNonNullHandle (nameof (imaginaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selComplexTensorWithRealTensor_ImaginaryTensor_Name_XHandle, realTensor__handle__, imaginaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (realTensor);
			GC.KeepAlive (imaginaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("conjugateWithTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Conjugate (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selConjugateWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("cosWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Cos (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selCosWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("coshWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Cosh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selCoshWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("divisionWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Division (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selDivisionWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("divisionNoNaNWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor DivisionNoNaN (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selDivisionNoNaNWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("equalWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor EqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selEqualWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("erfWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Erf (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selErfWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("exponentWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Exponent (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selExponentWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("exponentBase10WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExponentBase10 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selExponentBase10WithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("exponentBase2WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ExponentBase2 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selExponentBase2WithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("floorWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Floor (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selFloorWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("floorModuloWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor FloorModulo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selFloorModuloWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("greaterThanWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor GreaterThan (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selGreaterThanWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("greaterThanOrEqualToWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor GreaterThanOrEqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selGreaterThanOrEqualToWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("identityWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Identity (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selIdentityWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("imaginaryPartOfTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ImaginaryPart (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selImaginaryPartOfTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("isFiniteWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor IsFinite (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selIsFiniteWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("isInfiniteWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor IsInfinite (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selIsInfiniteWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("isNaNWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor IsNaN (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selIsNaNWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("lessThanWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LessThan (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLessThanWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("lessThanOrEqualToWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LessThanOrEqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLessThanOrEqualToWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logarithmWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Logarithm (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selLogarithmWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logarithmBase10WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogarithmBase10 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selLogarithmBase10WithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logarithmBase2WithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogarithmBase2 (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selLogarithmBase2WithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalANDWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalAnd (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLogicalANDWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalNANDWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalNand (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLogicalNANDWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalNORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalNor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLogicalNORWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalOr (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLogicalORWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalXNORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalXnor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLogicalXNORWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("logicalXORWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor LogicalXor (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selLogicalXORWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maximumWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Maximum (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selMaximumWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("maximumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MaximumWithNaNPropagation (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selMaximumWithNaNPropagationWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("minimumWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Minimum (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selMinimumWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("minimumWithNaNPropagationWithPrimaryTensor:secondaryTensor:name:")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor MinimumWithNaNPropagation (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selMinimumWithNaNPropagationWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("moduloWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Modulo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selModuloWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("multiplicationWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Multiplication (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selMultiplicationWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("negativeWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Negative (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selNegativeWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("notWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Not (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selNotWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("notEqualWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor NotEqualTo (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selNotEqualWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		/// <summary>Creates a planar tensor from a complex tensor, extracting the real and imaginary parts into a planar format.</summary>
		[Export ("planarTensorWithComplexTensor:name:")]
		[SupportedOSPlatform ("tvos26.3")]
		[SupportedOSPlatform ("macos26.3")]
		[SupportedOSPlatform ("ios26.3")]
		[SupportedOSPlatform ("maccatalyst26.3")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor PlanarTensor (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selPlanarTensorWithComplexTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("powerWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Power (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selPowerWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("realPartOfTensor:name:")]
		[SupportedOSPlatform ("tvos17.0")]
		[SupportedOSPlatform ("macos14.0")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor RealPart (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selRealPartOfTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reciprocalWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Reciprocal (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selReciprocalWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reciprocalSquareRootWithTensor:name:")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReciprocalSquareRoot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selReciprocalSquareRootWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("reverseSquareRootWithTensor:name:")]
		[ObsoletedOSPlatform ("ios18.0", "Use 'ReciprocalSquareRoot' instead.")]
		[ObsoletedOSPlatform ("tvos18.0", "Use 'ReciprocalSquareRoot' instead.")]
		[ObsoletedOSPlatform ("maccatalyst18.0", "Use 'ReciprocalSquareRoot' instead.")]
		[ObsoletedOSPlatform ("macos15.0", "Use 'ReciprocalSquareRoot' instead.")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos14.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor ReverseSquareRoot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selReverseSquareRootWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("rintWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Rint (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selRintWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("roundWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Round (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selRoundWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("selectWithPredicateTensor:truePredicateTensor:falsePredicateTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Select (this MPSGraph This, MPSGraphTensor predicateTensor, MPSGraphTensor truePredicateTensor, MPSGraphTensor falseSelectTensor, string? name)
		{
			var predicateTensor__handle__ = predicateTensor!.GetNonNullHandle (nameof (predicateTensor));
			var truePredicateTensor__handle__ = truePredicateTensor!.GetNonNullHandle (nameof (truePredicateTensor));
			var falseSelectTensor__handle__ = falseSelectTensor!.GetNonNullHandle (nameof (falseSelectTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSelectWithPredicateTensor_TruePredicateTensor_FalsePredicateTensor_Name_XHandle, predicateTensor__handle__, truePredicateTensor__handle__, falseSelectTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (predicateTensor);
			GC.KeepAlive (truePredicateTensor);
			GC.KeepAlive (falseSelectTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("signWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sign (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSignWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("signbitWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Signbit (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSignbitWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sinWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sin (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSinWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("sinhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Sinh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSinhWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squareWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Square (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSquareWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("squareRootWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor SquareRoot (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selSquareRootWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("subtractionWithPrimaryTensor:secondaryTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Subtraction (this MPSGraph This, MPSGraphTensor primaryTensor, MPSGraphTensor secondaryTensor, string? name)
		{
			var primaryTensor__handle__ = primaryTensor!.GetNonNullHandle (nameof (primaryTensor));
			var secondaryTensor__handle__ = secondaryTensor!.GetNonNullHandle (nameof (secondaryTensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selSubtractionWithPrimaryTensor_SecondaryTensor_Name_XHandle, primaryTensor__handle__, secondaryTensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (primaryTensor);
			GC.KeepAlive (secondaryTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tanWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Tan (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selTanWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("tanhWithTensor:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Tanh (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selTanhWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("truncateWithTensor:name:")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MPSGraphTensor Truncate (this MPSGraph This, MPSGraphTensor tensor, string? name)
		{
			var tensor__handle__ = tensor!.GetNonNullHandle (nameof (tensor));
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor? ret;
			ret =  Runtime.GetNSObject<MPSGraphTensor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, selTruncateWithTensor_Name_XHandle, tensor__handle__, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (tensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphArithmeticOps */
}
