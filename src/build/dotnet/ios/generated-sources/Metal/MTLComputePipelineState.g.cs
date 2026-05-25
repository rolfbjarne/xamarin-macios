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
	/// <summary>System protocol that represents a compiled compute program.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MTLComputePipelineState", WrapperType = typeof (MTLComputePipelineStateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImageblockMemoryLength", Selector = "imageblockMemoryLengthForDimensions:", ReturnType = typeof (UIntPtr), ParameterType = new Type [] { typeof (MTLSize) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionHandle", Selector = "functionHandleWithFunction:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (IMTLFunction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithAdditionalBinaryFunctions:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (IMTLFunction[]), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateVisibleFunctionTable", Selector = "newVisibleFunctionTableWithDescriptor:", ReturnType = typeof (IMTLVisibleFunctionTable), ParameterType = new Type [] { typeof (MTLVisibleFunctionTableDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateIntersectionFunctionTable", Selector = "newIntersectionFunctionTableWithDescriptor:", ReturnType = typeof (IMTLIntersectionFunctionTable), ParameterType = new Type [] { typeof (MTLIntersectionFunctionTableDescriptor) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionHandle", Selector = "functionHandleWithName:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateFunctionHandle", Selector = "functionHandleWithBinaryFunction:", ReturnType = typeof (IMTLFunctionHandle), ParameterType = new Type [] { typeof (IMTL4BinaryFunction) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithBinaryFunctions:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (IMTL4BinaryFunction[]), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "MaxTotalThreadsPerThreadgroup", Selector = "maxTotalThreadsPerThreadgroup", PropertyType = typeof (UIntPtr), GetterSelector = "maxTotalThreadsPerThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ThreadExecutionWidth", Selector = "threadExecutionWidth", PropertyType = typeof (UIntPtr), GetterSelector = "threadExecutionWidth", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "StaticThreadgroupMemoryLength", Selector = "staticThreadgroupMemoryLength", PropertyType = typeof (UIntPtr), GetterSelector = "staticThreadgroupMemoryLength", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "SupportIndirectCommandBuffers", Selector = "supportIndirectCommandBuffers", PropertyType = typeof (bool), GetterSelector = "supportIndirectCommandBuffers", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "GpuResourceId", Selector = "gpuResourceID", PropertyType = typeof (MTLResourceId), GetterSelector = "gpuResourceID", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "ShaderValidation", Selector = "shaderValidation", PropertyType = typeof (MTLShaderValidation), GetterSelector = "shaderValidation", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Reflection", Selector = "reflection", PropertyType = typeof (MTLComputePipelineReflection), GetterSelector = "reflection", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "RequiredThreadsPerThreadgroup", Selector = "requiredThreadsPerThreadgroup", PropertyType = typeof (MTLSize), GetterSelector = "requiredThreadsPerThreadgroup", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTLComputePipelineState : INativeObject, IDisposable, 
		Metal.IMTLAllocation
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
		internal static nuint _GetImageblockMemoryLength (IMTLComputePipelineState This, MTLSize imageblockDimensions)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend_MTLSize (This.Handle, Selector.GetHandle ("imageblockMemoryLengthForDimensions:"), imageblockDimensions);
			GC.KeepAlive (This);
			return ret;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithFunction:")]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle CreateFunctionHandle (IMTLFunction function)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle _CreateFunctionHandle (IMTLComputePipelineState This, IMTLFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("functionHandleWithFunction:"), function__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithAdditionalBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState CreateComputePipelineState (IMTLFunction[] functions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState _CreateComputePipelineState (IMTLComputePipelineState This, IMTLFunction[] functions, out NSError? error)
		{
			if (functions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functions));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_functions = NSArray.FromNSObjects (functions);
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithAdditionalBinaryFunctions:error:"), nsa_functions.Handle, &errorValue), true)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newVisibleFunctionTableWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLVisibleFunctionTable CreateVisibleFunctionTable (MTLVisibleFunctionTableDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLVisibleFunctionTable _CreateVisibleFunctionTable (IMTLComputePipelineState This, MTLVisibleFunctionTableDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLVisibleFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLVisibleFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newVisibleFunctionTableWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newIntersectionFunctionTableWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLIntersectionFunctionTable CreateIntersectionFunctionTable (MTLIntersectionFunctionTableDescriptor descriptor)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLIntersectionFunctionTable _CreateIntersectionFunctionTable (IMTLComputePipelineState This, MTLIntersectionFunctionTableDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIntersectionFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLIntersectionFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newIntersectionFunctionTableWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithName:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle? CreateFunctionHandle (string name)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle? _CreateFunctionHandle (IMTLComputePipelineState This, string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("functionHandleWithName:"), nsname), false)!;
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("functionHandleWithBinaryFunction:")]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual IMTLFunctionHandle? CreateFunctionHandle (IMTL4BinaryFunction function)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLFunctionHandle? _CreateFunctionHandle (IMTLComputePipelineState This, IMTL4BinaryFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("functionHandleWithBinaryFunction:"), function__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState? CreateComputePipelineState (IMTL4BinaryFunction[] additionalBinaryFunctions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState? _CreateComputePipelineState (IMTLComputePipelineState This, IMTL4BinaryFunction[] additionalBinaryFunctions, out NSError? error)
		{
			if (additionalBinaryFunctions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (additionalBinaryFunctions));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_additionalBinaryFunctions = NSArray.FromNSObjects (additionalBinaryFunctions);
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithBinaryFunctions:error:"), nsa_additionalBinaryFunctions.Handle, &errorValue), true)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.IMTL4BinaryFunction[],Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.IMTLFunction[],Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateFunctionHandle(Metal.IMTL4BinaryFunction)")]
		[DynamicDependencyAttribute ("CreateFunctionHandle(Metal.IMTLFunction)")]
		[DynamicDependencyAttribute ("CreateFunctionHandle(System.String)")]
		[DynamicDependencyAttribute ("CreateIntersectionFunctionTable(Metal.MTLIntersectionFunctionTableDescriptor)")]
		[DynamicDependencyAttribute ("CreateVisibleFunctionTable(Metal.MTLVisibleFunctionTableDescriptor)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("GetImageblockMemoryLength(Metal.MTLSize)")]
		[DynamicDependencyAttribute ("GpuResourceId")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("MaxTotalThreadsPerThreadgroup")]
		[DynamicDependencyAttribute ("Reflection")]
		[DynamicDependencyAttribute ("RequiredThreadsPerThreadgroup")]
		[DynamicDependencyAttribute ("ShaderValidation")]
		[DynamicDependencyAttribute ("StaticThreadgroupMemoryLength")]
		[DynamicDependencyAttribute ("SupportIndirectCommandBuffers")]
		[DynamicDependencyAttribute ("ThreadExecutionWidth")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLComputePipelineStateWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLComputePipelineState ()
		{
			GC.KeepAlive (null);
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
		internal static IMTLDevice _GetDevice (IMTLComputePipelineState This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint MaxTotalThreadsPerThreadgroup {
			[Export ("maxTotalThreadsPerThreadgroup")]
			get {
				return _GetMaxTotalThreadsPerThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetMaxTotalThreadsPerThreadgroup (IMTLComputePipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("maxTotalThreadsPerThreadgroup"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual nuint ThreadExecutionWidth {
			[Export ("threadExecutionWidth")]
			get {
				return _GetThreadExecutionWidth (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetThreadExecutionWidth (IMTLComputePipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("threadExecutionWidth"));
			GC.KeepAlive (This);
			return ret;
		}
		/// <summary>Returns the descriptive label for the compute pipeline state.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTLComputePipelineState This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[global::Foundation.RequiredMember]
		public virtual nuint StaticThreadgroupMemoryLength {
			[Export ("staticThreadgroupMemoryLength")]
			get {
				return _GetStaticThreadgroupMemoryLength (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static nuint _GetStaticThreadgroupMemoryLength (IMTLComputePipelineState This)
		{
			nuint ret;
			ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("staticThreadgroupMemoryLength"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[global::Foundation.RequiredMember]
		public virtual bool SupportIndirectCommandBuffers {
			[Export ("supportIndirectCommandBuffers")]
			get {
				return _GetSupportIndirectCommandBuffers (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static bool _GetSupportIndirectCommandBuffers (IMTLComputePipelineState This)
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
		public virtual MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				return _GetGpuResourceId (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLResourceId _GetGpuResourceId (IMTLComputePipelineState This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual MTLShaderValidation ShaderValidation {
			[Export ("shaderValidation")]
			get {
				return _GetShaderValidation (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLShaderValidation _GetShaderValidation (IMTLComputePipelineState This)
		{
			MTLShaderValidation ret;
			ret = (MTLShaderValidation) (long) global::ObjCRuntime.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("shaderValidation"));
			GC.KeepAlive (This);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLComputePipelineReflection? Reflection {
			[Export ("reflection")]
			get {
				return _GetReflection (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLComputePipelineReflection _GetReflection (IMTLComputePipelineState This)
		{
			MTLComputePipelineReflection ret;
			ret =  Runtime.GetNSObject<MTLComputePipelineReflection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("reflection")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		[global::Foundation.RequiredMember]
		public virtual MTLSize RequiredThreadsPerThreadgroup {
			[Export ("requiredThreadsPerThreadgroup")]
			get {
				return _GetRequiredThreadsPerThreadgroup (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MTLSize _GetRequiredThreadsPerThreadgroup (IMTLComputePipelineState This)
		{
			MTLSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (This.Handle, Selector.GetHandle ("requiredThreadsPerThreadgroup"));
				GC.KeepAlive (This);
			} else {
				ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (This.Handle, Selector.GetHandle ("requiredThreadsPerThreadgroup"));
				GC.KeepAlive (This);
			}
			return ret!;
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLComputePipelineState" /> interface to support all the methods from the MTLComputePipelineState protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLComputePipelineState" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLComputePipelineState protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLComputePipelineState_Extensions {
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLFunctionHandle CreateFunctionHandle (this IMTLComputePipelineState This, IMTLFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("functionHandleWithFunction:"), function__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (function);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static IMTLComputePipelineState CreateComputePipelineState (this IMTLComputePipelineState This, IMTLFunction[] functions, out NSError? error)
		{
			if (functions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functions));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_functions = NSArray.FromNSObjects (functions);
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithAdditionalBinaryFunctions:error:"), nsa_functions.Handle, &errorValue), true)!;
			GC.KeepAlive (This);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLVisibleFunctionTable CreateVisibleFunctionTable (this IMTLComputePipelineState This, MTLVisibleFunctionTableDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLVisibleFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLVisibleFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newVisibleFunctionTableWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[return: ReleaseAttribute ()]
		[SupportedOSPlatform ("ios14.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static IMTLIntersectionFunctionTable CreateIntersectionFunctionTable (this IMTLComputePipelineState This, MTLIntersectionFunctionTableDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIntersectionFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLIntersectionFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("newIntersectionFunctionTableWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MTLResourceId GetGpuResourceId (this IMTLComputePipelineState This)
		{
			MTLResourceId ret;
			ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (This.Handle, Selector.GetHandle ("gpuResourceID"));
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLComputePipelineStateWrapper : BaseWrapper, IMTLComputePipelineState {
		public MTLComputePipelineStateWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLComputePipelineStateWrapper))]
		static MTLComputePipelineStateWrapper ()
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
		[Export ("functionHandleWithFunction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle CreateFunctionHandle (IMTLFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("functionHandleWithFunction:"), function__handle__), false)!;
			GC.KeepAlive (function);
			return ret!;
		}
		[Export ("newComputePipelineStateWithAdditionalBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState CreateComputePipelineState (IMTLFunction[] functions, out NSError? error)
		{
			if (functions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (functions));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_functions = NSArray.FromNSObjects (functions);
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithAdditionalBinaryFunctions:error:"), nsa_functions.Handle, &errorValue), true)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newVisibleFunctionTableWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLVisibleFunctionTable CreateVisibleFunctionTable (MTLVisibleFunctionTableDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLVisibleFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLVisibleFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newVisibleFunctionTableWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newIntersectionFunctionTableWithDescriptor:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLIntersectionFunctionTable CreateIntersectionFunctionTable (MTLIntersectionFunctionTableDescriptor descriptor)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			IMTLIntersectionFunctionTable? ret;
			ret =  Runtime.GetINativeObject<IMTLIntersectionFunctionTable> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("newIntersectionFunctionTableWithDescriptor:"), descriptor__handle__), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("functionHandleWithName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle? CreateFunctionHandle (string name)
		{
			if (name is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (name));
			var nsname = CFString.CreateNative (name);
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("functionHandleWithName:"), nsname), false)!;
			CFString.ReleaseNative (nsname);
			return ret!;
		}
		[Export ("functionHandleWithBinaryFunction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTLFunctionHandle? CreateFunctionHandle (IMTL4BinaryFunction function)
		{
			var function__handle__ = function!.GetNonNullHandle (nameof (function));
			IMTLFunctionHandle? ret;
			ret =  Runtime.GetINativeObject<IMTLFunctionHandle> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("functionHandleWithBinaryFunction:"), function__handle__), false)!;
			GC.KeepAlive (function);
			return ret!;
		}
		[Export ("newComputePipelineStateWithBinaryFunctions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState? CreateComputePipelineState (IMTL4BinaryFunction[] additionalBinaryFunctions, out NSError? error)
		{
			if (additionalBinaryFunctions is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (additionalBinaryFunctions));
			NativeHandle errorValue = IntPtr.Zero;
			using var nsa_additionalBinaryFunctions = NSArray.FromNSObjects (additionalBinaryFunctions);
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithBinaryFunctions:error:"), nsa_additionalBinaryFunctions.Handle, &errorValue), true)!;
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
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
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint MaxTotalThreadsPerThreadgroup {
			[Export ("maxTotalThreadsPerThreadgroup")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("maxTotalThreadsPerThreadgroup"));
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public nuint ThreadExecutionWidth {
			[Export ("threadExecutionWidth")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("threadExecutionWidth"));
				return ret;
			}
		}
		/// <summary>Returns the descriptive label for the compute pipeline state.</summary>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		public nuint StaticThreadgroupMemoryLength {
			[Export ("staticThreadgroupMemoryLength")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("staticThreadgroupMemoryLength"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("tvos13.0")]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("macos")]
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
		public MTLResourceId GpuResourceId {
			[Export ("gpuResourceID")]
			get {
				MTLResourceId ret;
				ret = global::ObjCRuntime.Messaging.MTLResourceId_objc_msgSend (this.Handle, Selector.GetHandle ("gpuResourceID"));
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
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
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public MTLComputePipelineReflection? Reflection {
			[Export ("reflection")]
			get {
				MTLComputePipelineReflection ret;
				ret =  Runtime.GetNSObject<MTLComputePipelineReflection> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("reflection")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("macos26.0")]
		[SupportedOSPlatform ("ios26.0")]
		[SupportedOSPlatform ("maccatalyst26.0")]
		[SupportedOSPlatform ("tvos26.0")]
		public MTLSize RequiredThreadsPerThreadgroup {
			[Export ("requiredThreadsPerThreadgroup")]
			get {
				MTLSize ret;
				if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend (this.Handle, Selector.GetHandle ("requiredThreadsPerThreadgroup"));
				} else {
					ret = global::ObjCRuntime.Messaging.MTLSize_objc_msgSend_stret (this.Handle, Selector.GetHandle ("requiredThreadsPerThreadgroup"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios18.0")]
		[SupportedOSPlatform ("macos15.0")]
		[SupportedOSPlatform ("tvos18.0")]
		[SupportedOSPlatform ("maccatalyst18.0")]
		public nuint AllocatedSize {
			[Export ("allocatedSize")]
			[SupportedOSPlatform ("ios18.0")]
			[SupportedOSPlatform ("macos15.0")]
			[SupportedOSPlatform ("tvos18.0")]
			[SupportedOSPlatform ("maccatalyst18.0")]
			get {
				nuint ret;
				ret = global::ObjCRuntime.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("allocatedSize"));
				return ret;
			}
		}
	}
}
