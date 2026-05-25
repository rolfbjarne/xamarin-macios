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
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>System protocol for encoding the state of a rendering pipeline.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLRenderPipelineState", WrapperType = typeof (MTLRenderPipelineStateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImageblockMemoryLength", Selector = "imageblockMemoryLengthForDimensions:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (MTLSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "FunctionHandleWithFunction", Selector = "functionHandleWithFunction:stage:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (IMTLFunction), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NewVisibleFunctionTableWithDescriptor", Selector = "newVisibleFunctionTableWithDescriptor:stage:", ReturnType = typeof (IMTLVisibleFunctionTable), ParameterType = new Type [] { typeof (MTLVisibleFunctionTableDescriptor), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NewIntersectionFunctionTableWithDescriptor", Selector = "newIntersectionFunctionTableWithDescriptor:stage:", ReturnType = typeof (IMTLIntersectionFunctionTable), ParameterType = new Type [] { typeof (MTLIntersectionFunctionTableDescriptor), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "NewRenderPipelineStateWithAdditionalBinaryFunctions", Selector = "newRenderPipelineStateWithAdditionalBinaryFunctions:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTLRenderPipelineFunctionsDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionHandle", Selector = "functionHandleWithName:stage:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (string), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionHandle", Selector = "functionHandleWithBinaryFunction:stage:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (IMTL4BinaryFunction), typeof (MTLRenderStages) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithBinaryFunctions:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTL4RenderPipelineBinaryFunctionsDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineDescriptorForSpecialization", Selector = "newRenderPipelineDescriptorForSpecialization", ReturnType = typeof (MTL4PipelineDescriptor))]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxTotalThreadsPerThreadgroup", Selector = "maxTotalThreadsPerThreadgroup", PropertyType = typeof (UIntPtr), GetterSelector = "maxTotalThreadsPerThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ThreadgroupSizeMatchesTileSize", Selector = "threadgroupSizeMatchesTileSize", PropertyType = typeof (bool), GetterSelector = "threadgroupSizeMatchesTileSize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ImageblockSampleLength", Selector = "imageblockSampleLength", PropertyType = typeof (UIntPtr), GetterSelector = "imageblockSampleLength", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportIndirectCommandBuffers", Selector = "supportIndirectCommandBuffers", PropertyType = typeof (bool), GetterSelector = "supportIndirectCommandBuffers", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MeshThreadExecutionWidth", Selector = "meshThreadExecutionWidth", PropertyType = typeof (UIntPtr), GetterSelector = "meshThreadExecutionWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxTotalThreadgroupsPerMeshGrid", Selector = "maxTotalThreadgroupsPerMeshGrid", PropertyType = typeof (UIntPtr), GetterSelector = "maxTotalThreadgroupsPerMeshGrid", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuResourceId", Selector = "gpuResourceID", PropertyType = typeof (MTLResourceId), GetterSelector = "gpuResourceID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxTotalThreadsPerMeshThreadgroup", Selector = "maxTotalThreadsPerMeshThreadgroup", PropertyType = typeof (UIntPtr), GetterSelector = "maxTotalThreadsPerMeshThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxTotalThreadsPerObjectThreadgroup", Selector = "maxTotalThreadsPerObjectThreadgroup", PropertyType = typeof (UIntPtr), GetterSelector = "maxTotalThreadsPerObjectThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ObjectThreadExecutionWidth", Selector = "objectThreadExecutionWidth", PropertyType = typeof (UIntPtr), GetterSelector = "objectThreadExecutionWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShaderValidation", Selector = "shaderValidation", PropertyType = typeof (MTLShaderValidation), GetterSelector = "shaderValidation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Reflection", Selector = "reflection", PropertyType = typeof (MTLRenderPipelineReflection), GetterSelector = "reflection", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RequiredThreadsPerTileThreadgroup", Selector = "requiredThreadsPerTileThreadgroup", PropertyType = typeof (MTLSize), GetterSelector = "requiredThreadsPerTileThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RequiredThreadsPerObjectThreadgroup", Selector = "requiredThreadsPerObjectThreadgroup", PropertyType = typeof (MTLSize), GetterSelector = "requiredThreadsPerObjectThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RequiredThreadsPerMeshThreadgroup", Selector = "requiredThreadsPerMeshThreadgroup", PropertyType = typeof (MTLSize), GetterSelector = "requiredThreadsPerMeshThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLRenderPipelineState : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("imageblockMemoryLengthForDimensions:")]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint GetImageblockMemoryLength (MTLSize imageblockDimensions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetImageblockMemoryLength (IMTLRenderPipelineState This, MTLSize imageblockDimensions)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_MTLSize (This.Handle, Selector.GetHandle ("imageblockMemoryLengthForDimensions:"), imageblockDimensions);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithFunction:stage:")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle? FunctionHandleWithFunction (IMTLFunction function, MTLRenderStages stage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle? _FunctionHandleWithFunction (IMTLRenderPipelineState This, IMTLFunction function, MTLRenderStages stage)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("functionHandleWithFunction:stage:"), function__handle__, (UIntPtr) (ulong) stage), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newVisibleFunctionTableWithDescriptor:stage:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLVisibleFunctionTable? NewVisibleFunctionTableWithDescriptor (MTLVisibleFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLVisibleFunctionTable? _NewVisibleFunctionTableWithDescriptor (IMTLRenderPipelineState This, MTLVisibleFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLVisibleFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLVisibleFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newVisibleFunctionTableWithDescriptor:stage:"), descriptor__handle__, (UIntPtr) (ulong) stage), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newIntersectionFunctionTableWithDescriptor:stage:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLIntersectionFunctionTable? NewIntersectionFunctionTableWithDescriptor (MTLIntersectionFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLIntersectionFunctionTable? _NewIntersectionFunctionTableWithDescriptor (IMTLRenderPipelineState This, MTLIntersectionFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIntersectionFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLIntersectionFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newIntersectionFunctionTableWithDescriptor:stage:"), descriptor__handle__, (UIntPtr) (ulong) stage), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithAdditionalBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? NewRenderPipelineStateWithAdditionalBinaryFunctions (MTLRenderPipelineFunctionsDescriptor additionalBinaryFunctions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _NewRenderPipelineStateWithAdditionalBinaryFunctions (IMTLRenderPipelineState This, MTLRenderPipelineFunctionsDescriptor additionalBinaryFunctions, out NSError? error)
		{
			var additionalBinaryFunctions__handle__ = additionalBinaryFunctions!.GetNonNullHandle (nameof (additionalBinaryFunctions));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithAdditionalBinaryFunctions:error:"), additionalBinaryFunctions__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (additionalBinaryFunctions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithName:stage:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle? CreateFunctionHandle (string name, MTLRenderStages stage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle? _CreateFunctionHandle (IMTLRenderPipelineState This, string name, MTLRenderStages stage)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("functionHandleWithName:stage:"), nsname, (UIntPtr) (ulong) stage), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithBinaryFunction:stage:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle? CreateFunctionHandle (IMTL4BinaryFunction function, MTLRenderStages stage)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle? _CreateFunctionHandle (IMTLRenderPipelineState This, IMTL4BinaryFunction function, MTLRenderStages stage)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("functionHandleWithBinaryFunction:stage:"), function__handle__, (UIntPtr) (ulong) stage), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineState (MTL4RenderPipelineBinaryFunctionsDescriptor binaryFunctionsDescriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineState (IMTLRenderPipelineState This, MTL4RenderPipelineBinaryFunctionsDescriptor binaryFunctionsDescriptor, out NSError? error)
		{
			var binaryFunctionsDescriptor__handle__ = binaryFunctionsDescriptor!.GetNonNullHandle (nameof (binaryFunctionsDescriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithBinaryFunctions:error:"), binaryFunctionsDescriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (binaryFunctionsDescriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineDescriptorForSpecialization")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MTL4PipelineDescriptor CreateRenderPipelineDescriptorForSpecialization ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTL4PipelineDescriptor _CreateRenderPipelineDescriptorForSpecialization (IMTLRenderPipelineState This)
		{
			MTL4PipelineDescriptor? ret;
			ret =  Runtime.GetNSObject<MTL4PipelineDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("newRenderPipelineDescriptorForSpecialization")), true)!;
			GC.KeepAlive (This);
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateFunctionHandle(Metal.IMTL4BinaryFunction,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("CreateFunctionHandle(System.String,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineDescriptorForSpecialization()")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTL4RenderPipelineBinaryFunctionsDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("FunctionHandleWithFunction(Metal.IMTLFunction,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("GetImageblockMemoryLength(Metal.MTLSize)")]
		[DynamicDependencyAttribute ("GpuResourceId")]
		[DynamicDependencyAttribute ("ImageblockSampleLength")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("MaxTotalThreadgroupsPerMeshGrid")]
		[DynamicDependencyAttribute ("MaxTotalThreadsPerMeshThreadgroup")]
		[DynamicDependencyAttribute ("MaxTotalThreadsPerObjectThreadgroup")]
		[DynamicDependencyAttribute ("MaxTotalThreadsPerThreadgroup")]
		[DynamicDependencyAttribute ("MeshThreadExecutionWidth")]
		[DynamicDependencyAttribute ("NewIntersectionFunctionTableWithDescriptor(Metal.MTLIntersectionFunctionTableDescriptor,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("NewRenderPipelineStateWithAdditionalBinaryFunctions(Metal.MTLRenderPipelineFunctionsDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("NewVisibleFunctionTableWithDescriptor(Metal.MTLVisibleFunctionTableDescriptor,Metal.MTLRenderStages)")]
		[DynamicDependencyAttribute ("ObjectThreadExecutionWidth")]
		[DynamicDependencyAttribute ("Reflection")]
		[DynamicDependencyAttribute ("RequiredThreadsPerMeshThreadgroup")]
		[DynamicDependencyAttribute ("RequiredThreadsPerObjectThreadgroup")]
		[DynamicDependencyAttribute ("RequiredThreadsPerTileThreadgroup")]
		[DynamicDependencyAttribute ("ShaderValidation")]
		[DynamicDependencyAttribute ("SupportIndirectCommandBuffers")]
		[DynamicDependencyAttribute ("ThreadgroupSizeMatchesTileSize")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLRenderPipelineStateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLRenderPipelineState ()
		{
			GC.KeepAlive (null);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTLRenderPipelineState This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTLRenderPipelineState This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxTotalThreadsPerThreadgroup {
			[Export ("maxTotalThreadsPerThreadgroup")]
			get {
				return _GetMaxTotalThreadsPerThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxTotalThreadsPerThreadgroup (IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxTotalThreadsPerThreadgroup"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool ThreadgroupSizeMatchesTileSize {
			[Export ("threadgroupSizeMatchesTileSize")]
			get {
				return _GetThreadgroupSizeMatchesTileSize (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetThreadgroupSizeMatchesTileSize (IMTLRenderPipelineState This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("threadgroupSizeMatchesTileSize"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual nuint ImageblockSampleLength {
			[Export ("imageblockSampleLength")]
			get {
				return _GetImageblockSampleLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetImageblockSampleLength (IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("imageblockSampleLength"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportIndirectCommandBuffers {
			[Export ("supportIndirectCommandBuffers")]
			get {
				return _GetSupportIndirectCommandBuffers (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportIndirectCommandBuffers (IMTLRenderPipelineState This)
		{
			byte ret;
			ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("supportIndirectCommandBuffers"));
			GC.KeepAlive (This);
			return ret != 0;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual nuint MeshThreadExecutionWidth {
			[Export ("meshThreadExecutionWidth")]
			get {
				return _GetMeshThreadExecutionWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMeshThreadExecutionWidth (IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("meshThreadExecutionWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxTotalThreadgroupsPerMeshGrid {
			[Export ("maxTotalThreadgroupsPerMeshGrid")]
			get {
				return _GetMaxTotalThreadgroupsPerMeshGrid (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxTotalThreadgroupsPerMeshGrid (IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxTotalThreadgroupsPerMeshGrid"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				return _GetGpuResourceId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _GetGpuResourceId (IMTLRenderPipelineState This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxTotalThreadsPerMeshThreadgroup {
			[Export ("maxTotalThreadsPerMeshThreadgroup")]
			get {
				return _GetMaxTotalThreadsPerMeshThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxTotalThreadsPerMeshThreadgroup (IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxTotalThreadsPerMeshThreadgroup"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxTotalThreadsPerObjectThreadgroup {
			[Export ("maxTotalThreadsPerObjectThreadgroup")]
			get {
				return _GetMaxTotalThreadsPerObjectThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxTotalThreadsPerObjectThreadgroup (IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxTotalThreadsPerObjectThreadgroup"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[global::Foundation.RequiredMember]
		public virtual nuint ObjectThreadExecutionWidth {
			[Export ("objectThreadExecutionWidth")]
			get {
				return _GetObjectThreadExecutionWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetObjectThreadExecutionWidth (IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("objectThreadExecutionWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLShaderValidation ShaderValidation {
			[Export ("shaderValidation")]
			get {
				return _GetShaderValidation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLShaderValidation _GetShaderValidation (IMTLRenderPipelineState This)
		{
			MTLShaderValidation ret;
			ret = (MTLShaderValidation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("shaderValidation"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLRenderPipelineReflection? Reflection {
			[Export ("reflection")]
			get {
				return _GetReflection (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLRenderPipelineReflection _GetReflection (IMTLRenderPipelineState This)
		{
			MTLRenderPipelineReflection ret;
			ret =  Runtime.GetNSObject<MTLRenderPipelineReflection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("reflection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLSize RequiredThreadsPerTileThreadgroup {
			[Export ("requiredThreadsPerTileThreadgroup")]
			get {
				return _GetRequiredThreadsPerTileThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetRequiredThreadsPerTileThreadgroup (IMTLRenderPipelineState This)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (This.Handle, Selector.GetHandle ("requiredThreadsPerTileThreadgroup"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (This.Handle, Selector.GetHandle ("requiredThreadsPerTileThreadgroup"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLSize RequiredThreadsPerObjectThreadgroup {
			[Export ("requiredThreadsPerObjectThreadgroup")]
			get {
				return _GetRequiredThreadsPerObjectThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetRequiredThreadsPerObjectThreadgroup (IMTLRenderPipelineState This)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (This.Handle, Selector.GetHandle ("requiredThreadsPerObjectThreadgroup"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (This.Handle, Selector.GetHandle ("requiredThreadsPerObjectThreadgroup"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLSize RequiredThreadsPerMeshThreadgroup {
			[Export ("requiredThreadsPerMeshThreadgroup")]
			get {
				return _GetRequiredThreadsPerMeshThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetRequiredThreadsPerMeshThreadgroup (IMTLRenderPipelineState This)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (This.Handle, Selector.GetHandle ("requiredThreadsPerMeshThreadgroup"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (This.Handle, Selector.GetHandle ("requiredThreadsPerMeshThreadgroup"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLRenderPipelineState" /> interface to support all the methods from the MTLRenderPipelineState protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLRenderPipelineState" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLRenderPipelineState protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLRenderPipelineState_Extensions {
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLFunctionHandle? FunctionHandleWithFunction (this IMTLRenderPipelineState This, IMTLFunction function, MTLRenderStages stage)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("functionHandleWithFunction:stage:"), function__handle__, (UIntPtr) (ulong) stage), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLVisibleFunctionTable? NewVisibleFunctionTableWithDescriptor (this IMTLRenderPipelineState This, MTLVisibleFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLVisibleFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLVisibleFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newVisibleFunctionTableWithDescriptor:stage:"), descriptor__handle__, (UIntPtr) (ulong) stage), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLIntersectionFunctionTable? NewIntersectionFunctionTableWithDescriptor (this IMTLRenderPipelineState This, MTLIntersectionFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIntersectionFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLIntersectionFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("newIntersectionFunctionTableWithDescriptor:stage:"), descriptor__handle__, (UIntPtr) (ulong) stage), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMTLRenderPipelineState? NewRenderPipelineStateWithAdditionalBinaryFunctions (this IMTLRenderPipelineState This, MTLRenderPipelineFunctionsDescriptor additionalBinaryFunctions, out NSError? error)
		{
			var additionalBinaryFunctions__handle__ = additionalBinaryFunctions!.GetNonNullHandle (nameof (additionalBinaryFunctions));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithAdditionalBinaryFunctions:error:"), additionalBinaryFunctions__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (additionalBinaryFunctions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetMaxTotalThreadsPerMeshThreadgroup (this IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxTotalThreadsPerMeshThreadgroup"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetMaxTotalThreadsPerObjectThreadgroup (this IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxTotalThreadsPerObjectThreadgroup"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint GetObjectThreadExecutionWidth (this IMTLRenderPipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("objectThreadExecutionWidth"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLRenderPipelineStateWrapper : BaseWrapper, IMTLRenderPipelineState {
		public MTLRenderPipelineStateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLRenderPipelineStateWrapper))]
		static MTLRenderPipelineStateWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("imageblockMemoryLengthForDimensions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint GetImageblockMemoryLength (MTLSize imageblockDimensions)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_MTLSize (this.Handle, Selector.GetHandle ("imageblockMemoryLengthForDimensions:"), imageblockDimensions);
			return ret;
		}
		[Export ("functionHandleWithFunction:stage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle? FunctionHandleWithFunction (IMTLFunction function, MTLRenderStages stage)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("functionHandleWithFunction:stage:"), function__handle__, (UIntPtr) (ulong) stage), false)!;
			GC.KeepAlive (function);
			return ret!;
		}
		[Export ("newVisibleFunctionTableWithDescriptor:stage:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLVisibleFunctionTable? NewVisibleFunctionTableWithDescriptor (MTLVisibleFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLVisibleFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLVisibleFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("newVisibleFunctionTableWithDescriptor:stage:"), descriptor__handle__, (UIntPtr) (ulong) stage), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newIntersectionFunctionTableWithDescriptor:stage:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLIntersectionFunctionTable? NewIntersectionFunctionTableWithDescriptor (MTLIntersectionFunctionTableDescriptor descriptor, MTLRenderStages stage)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIntersectionFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLIntersectionFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("newIntersectionFunctionTableWithDescriptor:stage:"), descriptor__handle__, (UIntPtr) (ulong) stage), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newRenderPipelineStateWithAdditionalBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? NewRenderPipelineStateWithAdditionalBinaryFunctions (MTLRenderPipelineFunctionsDescriptor additionalBinaryFunctions, out NSError? error)
		{
			var additionalBinaryFunctions__handle__ = additionalBinaryFunctions!.GetNonNullHandle (nameof (additionalBinaryFunctions));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithAdditionalBinaryFunctions:error:"), additionalBinaryFunctions__handle__, &errorValue), true)!;
			GC.KeepAlive (additionalBinaryFunctions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("functionHandleWithName:stage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle? CreateFunctionHandle (string name, MTLRenderStages stage)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("functionHandleWithName:stage:"), nsname, (UIntPtr) (ulong) stage), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("functionHandleWithBinaryFunction:stage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle? CreateFunctionHandle (IMTL4BinaryFunction function, MTLRenderStages stage)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("functionHandleWithBinaryFunction:stage:"), function__handle__, (UIntPtr) (ulong) stage), false)!;
			GC.KeepAlive (function);
			return ret!;
		}
		[Export ("newRenderPipelineStateWithBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineState (MTL4RenderPipelineBinaryFunctionsDescriptor binaryFunctionsDescriptor, out NSError? error)
		{
			var binaryFunctionsDescriptor__handle__ = binaryFunctionsDescriptor!.GetNonNullHandle (nameof (binaryFunctionsDescriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithBinaryFunctions:error:"), binaryFunctionsDescriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (binaryFunctionsDescriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineDescriptorForSpecialization")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MTL4PipelineDescriptor CreateRenderPipelineDescriptorForSpecialization ()
		{
			MTL4PipelineDescriptor? ret;
			ret =  Runtime.GetNSObject<MTL4PipelineDescriptor> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("newRenderPipelineDescriptorForSpecialization")), true)!;
			return ret!;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLDevice Device {
			[Export ("device")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public nuint MaxTotalThreadsPerThreadgroup {
			[Export ("maxTotalThreadsPerThreadgroup")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxTotalThreadsPerThreadgroup"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public bool ThreadgroupSizeMatchesTileSize {
			[Export ("threadgroupSizeMatchesTileSize")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("threadgroupSizeMatchesTileSize"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos14.5")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public nuint ImageblockSampleLength {
			[Export ("imageblockSampleLength")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("imageblockSampleLength"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public bool SupportIndirectCommandBuffers {
			[Export ("supportIndirectCommandBuffers")]
			get {
				byte ret;
				ret = global::ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("supportIndirectCommandBuffers"));
				return ret != 0;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public nuint MeshThreadExecutionWidth {
			[Export ("meshThreadExecutionWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("meshThreadExecutionWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public nuint MaxTotalThreadgroupsPerMeshGrid {
			[Export ("maxTotalThreadgroupsPerMeshGrid")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxTotalThreadgroupsPerMeshGrid"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("gpuResourceID"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public nuint MaxTotalThreadsPerMeshThreadgroup {
			[Export ("maxTotalThreadsPerMeshThreadgroup")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxTotalThreadsPerMeshThreadgroup"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public nuint MaxTotalThreadsPerObjectThreadgroup {
			[Export ("maxTotalThreadsPerObjectThreadgroup")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxTotalThreadsPerObjectThreadgroup"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		public nuint ObjectThreadExecutionWidth {
			[Export ("objectThreadExecutionWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("objectThreadExecutionWidth"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public MTLShaderValidation ShaderValidation {
			[Export ("shaderValidation")]
			get {
				MTLShaderValidation ret;
				ret = (MTLShaderValidation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("shaderValidation"));
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLRenderPipelineReflection? Reflection {
			[Export ("reflection")]
			get {
				MTLRenderPipelineReflection ret;
				ret =  Runtime.GetNSObject<MTLRenderPipelineReflection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reflection")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLSize RequiredThreadsPerTileThreadgroup {
			[Export ("requiredThreadsPerTileThreadgroup")]
			get {
				MTLSize ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, Selector.GetHandle ("requiredThreadsPerTileThreadgroup"));
				} else {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, Selector.GetHandle ("requiredThreadsPerTileThreadgroup"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLSize RequiredThreadsPerObjectThreadgroup {
			[Export ("requiredThreadsPerObjectThreadgroup")]
			get {
				MTLSize ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, Selector.GetHandle ("requiredThreadsPerObjectThreadgroup"));
				} else {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, Selector.GetHandle ("requiredThreadsPerObjectThreadgroup"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		public MTLSize RequiredThreadsPerMeshThreadgroup {
			[Export ("requiredThreadsPerMeshThreadgroup")]
			get {
				MTLSize ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, Selector.GetHandle ("requiredThreadsPerMeshThreadgroup"));
				} else {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, Selector.GetHandle ("requiredThreadsPerMeshThreadgroup"));
				}
				return ret!;
			}
		}
	}
}
