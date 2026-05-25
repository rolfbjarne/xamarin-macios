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
	[SupportedOSPlatform ("tvos15.0")]
	[SupportedOSPlatform ("ios15.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public unsafe static partial class MPSGraph_MPSGraphControlFlowOps  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selControlDependencyWithOperations_DependentBlock_Name_X = "controlDependencyWithOperations:dependentBlock:name:";
		static readonly NativeHandle selControlDependencyWithOperations_DependentBlock_Name_XHandle = Selector.GetHandle ("controlDependencyWithOperations:dependentBlock:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForLoopWithLowerBound_UpperBound_Step_InitialBodyArguments_Body_Name_X = "forLoopWithLowerBound:upperBound:step:initialBodyArguments:body:name:";
		static readonly NativeHandle selForLoopWithLowerBound_UpperBound_Step_InitialBodyArguments_Body_Name_XHandle = Selector.GetHandle ("forLoopWithLowerBound:upperBound:step:initialBodyArguments:body:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selForLoopWithNumberOfIterations_InitialBodyArguments_Body_Name_X = "forLoopWithNumberOfIterations:initialBodyArguments:body:name:";
		static readonly NativeHandle selForLoopWithNumberOfIterations_InitialBodyArguments_Body_Name_XHandle = Selector.GetHandle ("forLoopWithNumberOfIterations:initialBodyArguments:body:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selIfWithPredicateTensor_ThenBlock_ElseBlock_Name_X = "ifWithPredicateTensor:thenBlock:elseBlock:name:";
		static readonly NativeHandle selIfWithPredicateTensor_ThenBlock_ElseBlock_Name_XHandle = Selector.GetHandle ("ifWithPredicateTensor:thenBlock:elseBlock:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		const string selWhileWithInitialInputs_Before_After_Name_X = "whileWithInitialInputs:before:after:name:";
		static readonly NativeHandle selWhileWithInitialInputs_Before_After_Name_XHandle = Selector.GetHandle ("whileWithInitialInputs:before:after:name:");
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly NativeHandle class_ptr = Class.GetHandle ("MPSGraph");
		[Export ("controlDependencyWithOperations:dependentBlock:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSGraphTensor[] ControlDependency (this MPSGraph This, MPSGraphOperation[] operations, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGraphControlFlowDependencyBlock))]MPSGraphControlFlowDependencyBlock dependentBlock, string? name)
		{
			if (operations is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (operations));
			if (dependentBlock is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (dependentBlock));
			using var nsa_operations = NSArray.FromNSObjects (operations);
			using var block_dependentBlock = Trampolines.SDMPSGraphControlFlowDependencyBlock.CreateBlock (dependentBlock);
			BlockLiteral *block_ptr_dependentBlock = &block_dependentBlock;
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, selControlDependencyWithOperations_DependentBlock_Name_XHandle, nsa_operations.Handle, (IntPtr) block_ptr_dependentBlock, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("forLoopWithLowerBound:upperBound:step:initialBodyArguments:body:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSGraphTensor[] For (this MPSGraph This, MPSGraphTensor lowerBound, MPSGraphTensor upperBound, MPSGraphTensor step, MPSGraphTensor[] initialBodyArguments, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGraphForLoopBodyBlock))]MPSGraphForLoopBodyBlock body, string? name)
		{
			var lowerBound__handle__ = lowerBound!.GetNonNullHandle (nameof (lowerBound));
			var upperBound__handle__ = upperBound!.GetNonNullHandle (nameof (upperBound));
			var step__handle__ = step!.GetNonNullHandle (nameof (step));
			if (initialBodyArguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (initialBodyArguments));
			if (body is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (body));
			using var nsa_initialBodyArguments = NSArray.FromNSObjects (initialBodyArguments);
			using var block_body = Trampolines.SDMPSGraphForLoopBodyBlock.CreateBlock (body);
			BlockLiteral *block_ptr_body = &block_body;
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selForLoopWithLowerBound_UpperBound_Step_InitialBodyArguments_Body_Name_XHandle, lowerBound__handle__, upperBound__handle__, step__handle__, nsa_initialBodyArguments.Handle, (IntPtr) block_ptr_body, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (lowerBound);
			GC.KeepAlive (upperBound);
			GC.KeepAlive (step);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("forLoopWithNumberOfIterations:initialBodyArguments:body:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSGraphTensor[] For (this MPSGraph This, MPSGraphTensor numberOfIterations, MPSGraphTensor[] initialBodyArguments, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGraphForLoopBodyBlock))]MPSGraphForLoopBodyBlock body, string? name)
		{
			var numberOfIterations__handle__ = numberOfIterations!.GetNonNullHandle (nameof (numberOfIterations));
			if (initialBodyArguments is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (initialBodyArguments));
			if (body is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (body));
			using var nsa_initialBodyArguments = NSArray.FromNSObjects (initialBodyArguments);
			using var block_body = Trampolines.SDMPSGraphForLoopBodyBlock.CreateBlock (body);
			BlockLiteral *block_ptr_body = &block_body;
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selForLoopWithNumberOfIterations_InitialBodyArguments_Body_Name_XHandle, numberOfIterations__handle__, nsa_initialBodyArguments.Handle, (IntPtr) block_ptr_body, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (numberOfIterations);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("ifWithPredicateTensor:thenBlock:elseBlock:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSGraphTensor[] If (this MPSGraph This, MPSGraphTensor predicateTensor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGraphIfThenElseBlock))]MPSGraphIfThenElseBlock thenBlock, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGraphIfThenElseBlock))]MPSGraphIfThenElseBlock? elseBlock, string? name)
		{
			var predicateTensor__handle__ = predicateTensor!.GetNonNullHandle (nameof (predicateTensor));
			if (thenBlock is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (thenBlock));
			using var block_thenBlock = Trampolines.SDMPSGraphIfThenElseBlock.CreateBlock (thenBlock);
			BlockLiteral *block_ptr_thenBlock = &block_thenBlock;
			using var block_elseBlock = Trampolines.SDMPSGraphIfThenElseBlock.CreateNullableBlock (elseBlock);
			BlockLiteral *block_ptr_elseBlock = null;
			if (elseBlock is not null)
				block_ptr_elseBlock = &block_elseBlock;
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selIfWithPredicateTensor_ThenBlock_ElseBlock_Name_XHandle, predicateTensor__handle__, (IntPtr) block_ptr_thenBlock, (IntPtr) block_ptr_elseBlock, nsname), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (predicateTensor);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("whileWithInitialInputs:before:after:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static MPSGraphTensor[] While (this MPSGraph This, MPSGraphTensor[] initialInputs, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGraphWhileBeforeBlock))]MPSGraphWhileBeforeBlock before, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMPSGraphWhileAfterBlock))]MPSGraphWhileAfterBlock after, string? name)
		{
			if (initialInputs is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (initialInputs));
			if (before is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (before));
			if (after is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (after));
			using var nsa_initialInputs = NSArray.FromNSObjects (initialInputs);
			using var block_before = Trampolines.SDMPSGraphWhileBeforeBlock.CreateBlock (before);
			BlockLiteral *block_ptr_before = &block_before;
			using var block_after = Trampolines.SDMPSGraphWhileAfterBlock.CreateBlock (after);
			BlockLiteral *block_ptr_after = &block_after;
			var nsname = CFString.CreateNative (name);
			MPSGraphTensor[]? ret;
			ret = CFArray.ArrayFromHandle<MPSGraphTensor>(global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, selWhileWithInitialInputs_Before_After_Name_XHandle, nsa_initialInputs.Handle, (IntPtr) block_ptr_before, (IntPtr) block_ptr_after, nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
	} /* class MPSGraph_MPSGraphControlFlowOps */
}
