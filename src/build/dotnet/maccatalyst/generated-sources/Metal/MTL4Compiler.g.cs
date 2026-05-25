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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4Compiler</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4Compiler", WrapperType = typeof (MTL4CompilerWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithDescriptor:error:", ReturnType = typeof (IMTLLibrary), ParameterType = new Type [] { typeof (MTL4LibraryDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDynamicLibrary", Selector = "newDynamicLibrary:error:", ReturnType = typeof (IMTLDynamicLibrary), ParameterType = new Type [] { typeof (IMTLLibrary), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDynamicLibrary", Selector = "newDynamicLibraryWithURL:error:", ReturnType = typeof (IMTLDynamicLibrary), ParameterType = new Type [] { typeof (NSUrl), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:compilerTaskOptions:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (MTL4ComputePipelineDescriptor), typeof (MTL4CompilerTaskOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (MTL4ComputePipelineDescriptor), typeof (MTL4PipelineStageDynamicLinkingDescriptor), typeof (MTL4CompilerTaskOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:compilerTaskOptions:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (MTL4CompilerTaskOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (MTL4RenderPipelineDynamicLinkingDescriptor), typeof (MTL4CompilerTaskOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineStateBySpecialization", Selector = "newRenderPipelineStateBySpecializationWithDescriptor:pipeline:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (IMTLRenderPipelineState), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBinaryFunction", Selector = "newBinaryFunctionWithDescriptor:compilerTaskOptions:error:", ReturnType = typeof (IMTL4BinaryFunction), ParameterType = new Type [] { typeof (MTL4BinaryFunctionDescriptor), typeof (MTL4CompilerTaskOptions), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateLibrary", Selector = "newLibraryWithDescriptor:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4LibraryDescriptor), typeof (MTLCreateLibraryCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateLibraryCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDynamicLibrary", Selector = "newDynamicLibrary:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (IMTLLibrary), typeof (MTLCreateDynamicLibraryCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateDynamicLibrary", Selector = "newDynamicLibraryWithURL:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (NSUrl), typeof (MTLCreateDynamicLibraryCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:compilerTaskOptions:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4ComputePipelineDescriptor), typeof (MTL4CompilerTaskOptions), typeof (MTLCreateComputePipelineStateCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4ComputePipelineDescriptor), typeof (MTL4PipelineStageDynamicLinkingDescriptor), typeof (MTL4CompilerTaskOptions), typeof (MTLCreateComputePipelineStateCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:compilerTaskOptions:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (MTL4CompilerTaskOptions), typeof (MTLCreateRenderPipelineStateCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (MTL4RenderPipelineDynamicLinkingDescriptor), typeof (MTL4CompilerTaskOptions), typeof (MTLCreateRenderPipelineStateCompletionHandler) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineStateBySpecialization", Selector = "newRenderPipelineStateBySpecializationWithDescriptor:pipeline:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (IMTLRenderPipelineState), typeof (MTLCreateRenderPipelineStateCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBinaryFunction", Selector = "newBinaryFunctionWithDescriptor:compilerTaskOptions:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4BinaryFunctionDescriptor), typeof (MTL4CompilerTaskOptions), typeof (MTL4CreateBinaryFunctionCompletionHandler) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDMTL4CreateBinaryFunctionCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateMachineLearningPipelineState", Selector = "newMachineLearningPipelineStateWithDescriptor:error:", ReturnType = typeof (IMTL4MachineLearningPipelineState), ParameterType = new Type [] { typeof (MTL4MachineLearningPipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateMachineLearningPipelineState", Selector = "newMachineLearningPipelineStateWithDescriptor:completionHandler:", ReturnType = typeof (IMTL4CompilerTask), ParameterType = new Type [] { typeof (MTL4MachineLearningPipelineDescriptor), typeof (MTL4CreateMachineLearningPipelineStateCompletionHandler) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDMTL4CreateMachineLearningPipelineStateCompletionHandler) })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Device", Selector = "device", PropertyType = typeof (IMTLDevice), GetterSelector = "device", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "PipelineDataSetSerializer", Selector = "pipelineDataSetSerializer", PropertyType = typeof (IMTL4PipelineDataSetSerializer), GetterSelector = "pipelineDataSetSerializer", ArgumentSemantic = ArgumentSemantic.Retain)]
	public partial interface IMTL4Compiler : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLLibrary? CreateLibrary (MTL4LibraryDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLLibrary? _CreateLibrary (IMTL4Compiler This, MTL4LibraryDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newDynamicLibrary:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLDynamicLibrary? CreateDynamicLibrary (IMTLLibrary library, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLDynamicLibrary? _CreateDynamicLibrary (IMTL4Compiler This, IMTLLibrary library, out NSError? error)
		{
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newDynamicLibrary:error:"), library__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (library);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newDynamicLibraryWithURL:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLDynamicLibrary? CreateDynamicLibrary (NSUrl url, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLDynamicLibrary? _CreateDynamicLibrary (IMTL4Compiler This, NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newDynamicLibraryWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState? _CreateComputePipelineState (IMTL4Compiler This, MTL4ComputePipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:compilerTaskOptions:error:"), descriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState? _CreateComputePipelineState (IMTL4Compiler This, MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineState (IMTL4Compiler This, MTL4PipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:error:"), descriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineState (IMTL4Compiler This, MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineStateBySpecialization (MTL4PipelineDescriptor descriptor, IMTLRenderPipelineState pipeline, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineStateBySpecialization (IMTL4Compiler This, MTL4PipelineDescriptor descriptor, IMTLRenderPipelineState pipeline, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var pipeline__handle__ = pipeline!.GetNonNullHandle (nameof (pipeline));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:error:"), descriptor__handle__, pipeline__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (pipeline);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newBinaryFunctionWithDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4BinaryFunction? CreateBinaryFunction (MTL4BinaryFunctionDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4BinaryFunction? _CreateBinaryFunction (IMTL4Compiler This, MTL4BinaryFunctionDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4BinaryFunction? ret;
			ret =  Runtime.GetINativeObject<IMTL4BinaryFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newBinaryFunctionWithDescriptor:compilerTaskOptions:error:"), descriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newLibraryWithDescriptor:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateLibrary (MTL4LibraryDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateLibraryCompletionHandler))]MTLCreateLibraryCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateLibrary (IMTL4Compiler This, MTL4LibraryDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateLibraryCompletionHandler))]MTLCreateLibraryCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateLibraryCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newLibraryWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newDynamicLibrary:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateDynamicLibrary (IMTLLibrary library, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler))]MTLCreateDynamicLibraryCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateDynamicLibrary (IMTL4Compiler This, IMTLLibrary library, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler))]MTLCreateDynamicLibraryCompletionHandler completionHandler)
		{
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateDynamicLibraryCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newDynamicLibrary:completionHandler:"), library__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (library);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newDynamicLibraryWithURL:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateDynamicLibrary (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler))]MTLCreateDynamicLibraryCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateDynamicLibrary (IMTL4Compiler This, NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler))]MTLCreateDynamicLibraryCompletionHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateDynamicLibraryCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newDynamicLibraryWithURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (url);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler))]MTLCreateComputePipelineStateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateComputePipelineState (IMTL4Compiler This, MTL4ComputePipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler))]MTLCreateComputePipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateComputePipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler))]MTLCreateComputePipelineStateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateComputePipelineState (IMTL4Compiler This, MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler))]MTLCreateComputePipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateComputePipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateRenderPipelineState (IMTL4Compiler This, MTL4PipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateRenderPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateRenderPipelineState (IMTL4Compiler This, MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateRenderPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateRenderPipelineStateBySpecialization (MTL4PipelineDescriptor descriptor, IMTLRenderPipelineState pipeline, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateRenderPipelineStateBySpecialization (IMTL4Compiler This, MTL4PipelineDescriptor descriptor, IMTLRenderPipelineState pipeline, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var pipeline__handle__ = pipeline!.GetNonNullHandle (nameof (pipeline));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateRenderPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:completionHandler:"), descriptor__handle__, pipeline__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (pipeline);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newBinaryFunctionWithDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateBinaryFunction (MTL4BinaryFunctionDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTL4CreateBinaryFunctionCompletionHandler))]MTL4CreateBinaryFunctionCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateBinaryFunction (IMTL4Compiler This, MTL4BinaryFunctionDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTL4CreateBinaryFunctionCompletionHandler))]MTL4CreateBinaryFunctionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTL4CreateBinaryFunctionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newBinaryFunctionWithDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newMachineLearningPipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4MachineLearningPipelineState? CreateMachineLearningPipelineState (MTL4MachineLearningPipelineDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4MachineLearningPipelineState? _CreateMachineLearningPipelineState (IMTL4Compiler This, MTL4MachineLearningPipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4MachineLearningPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTL4MachineLearningPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newMachineLearningPipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newMachineLearningPipelineStateWithDescriptor:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4CompilerTask CreateMachineLearningPipelineState (MTL4MachineLearningPipelineDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTL4CreateMachineLearningPipelineStateCompletionHandler))]MTL4CreateMachineLearningPipelineStateCompletionHandler completionHandler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4CompilerTask _CreateMachineLearningPipelineState (IMTL4Compiler This, MTL4MachineLearningPipelineDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTL4CreateMachineLearningPipelineStateCompletionHandler))]MTL4CreateMachineLearningPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTL4CreateMachineLearningPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("newMachineLearningPipelineStateWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateBinaryFunction(Metal.MTL4BinaryFunctionDescriptor,Metal.MTL4CompilerTaskOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateBinaryFunction(Metal.MTL4BinaryFunctionDescriptor,Metal.MTL4CompilerTaskOptions,Metal.MTL4CreateBinaryFunctionCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTL4ComputePipelineDescriptor,Metal.MTL4CompilerTaskOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTL4ComputePipelineDescriptor,Metal.MTL4CompilerTaskOptions,Metal.MTLCreateComputePipelineStateCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTL4ComputePipelineDescriptor,Metal.MTL4PipelineStageDynamicLinkingDescriptor,Metal.MTL4CompilerTaskOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTL4ComputePipelineDescriptor,Metal.MTL4PipelineStageDynamicLinkingDescriptor,Metal.MTL4CompilerTaskOptions,Metal.MTLCreateComputePipelineStateCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateDynamicLibrary(Foundation.NSUrl,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateDynamicLibrary(Foundation.NSUrl,Metal.MTLCreateDynamicLibraryCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateDynamicLibrary(Metal.IMTLLibrary,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateDynamicLibrary(Metal.IMTLLibrary,Metal.MTLCreateDynamicLibraryCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateLibrary(Metal.MTL4LibraryDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateLibrary(Metal.MTL4LibraryDescriptor,Metal.MTLCreateLibraryCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateMachineLearningPipelineState(Metal.MTL4MachineLearningPipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateMachineLearningPipelineState(Metal.MTL4MachineLearningPipelineDescriptor,Metal.MTL4CreateMachineLearningPipelineStateCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTL4PipelineDescriptor,Metal.MTL4CompilerTaskOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTL4PipelineDescriptor,Metal.MTL4CompilerTaskOptions,Metal.MTLCreateRenderPipelineStateCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTL4PipelineDescriptor,Metal.MTL4RenderPipelineDynamicLinkingDescriptor,Metal.MTL4CompilerTaskOptions,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTL4PipelineDescriptor,Metal.MTL4RenderPipelineDynamicLinkingDescriptor,Metal.MTL4CompilerTaskOptions,Metal.MTLCreateRenderPipelineStateCompletionHandler)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineStateBySpecialization(Metal.MTL4PipelineDescriptor,Metal.IMTLRenderPipelineState,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineStateBySpecialization(Metal.MTL4PipelineDescriptor,Metal.IMTLRenderPipelineState,Metal.MTLCreateRenderPipelineStateCompletionHandler)")]
		[DynamicDependencyAttribute ("Device")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute ("PipelineDataSetSerializer")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CompilerWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4Compiler ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTLDevice Device {
			[Export ("device")]
			get {
				return _GetDevice (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTLDevice _GetDevice (IMTL4Compiler This)
		{
			IMTLDevice ret;
			ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("device")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTL4Compiler This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual IMTL4PipelineDataSetSerializer? PipelineDataSetSerializer {
			[Export ("pipelineDataSetSerializer", ArgumentSemantic.Retain)]
			get {
				return _GetPipelineDataSetSerializer (this);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static IMTL4PipelineDataSetSerializer _GetPipelineDataSetSerializer (IMTL4Compiler This)
		{
			IMTL4PipelineDataSetSerializer ret;
			ret =  Runtime.GetINativeObject<IMTL4PipelineDataSetSerializer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("pipelineDataSetSerializer")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4CompilerWrapper : BaseWrapper, IMTL4Compiler {
		public MTL4CompilerWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4CompilerWrapper))]
		static MTL4CompilerWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("newLibraryWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLLibrary? CreateLibrary (MTL4LibraryDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newDynamicLibrary:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLDynamicLibrary? CreateDynamicLibrary (IMTLLibrary library, out NSError? error)
		{
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newDynamicLibrary:error:"), library__handle__, &errorValue), true)!;
			GC.KeepAlive (library);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newDynamicLibraryWithURL:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLDynamicLibrary? CreateDynamicLibrary (NSUrl url, out NSError? error)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLDynamicLibrary? ret;
			ret =  Runtime.GetINativeObject<IMTLDynamicLibrary> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newDynamicLibraryWithURL:error:"), url__handle__, &errorValue), true)!;
			GC.KeepAlive (url);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newComputePipelineStateWithDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:compilerTaskOptions:error:"), descriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:error:"), descriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineStateBySpecialization (MTL4PipelineDescriptor descriptor, IMTLRenderPipelineState pipeline, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var pipeline__handle__ = pipeline!.GetNonNullHandle (nameof (pipeline));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:error:"), descriptor__handle__, pipeline__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (pipeline);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newBinaryFunctionWithDescriptor:compilerTaskOptions:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4BinaryFunction? CreateBinaryFunction (MTL4BinaryFunctionDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4BinaryFunction? ret;
			ret =  Runtime.GetINativeObject<IMTL4BinaryFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newBinaryFunctionWithDescriptor:compilerTaskOptions:error:"), descriptor__handle__, compilerTaskOptions__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newLibraryWithDescriptor:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateLibrary (MTL4LibraryDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateLibraryCompletionHandler))]MTLCreateLibraryCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateLibraryCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newLibraryWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
		[Export ("newDynamicLibrary:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateDynamicLibrary (IMTLLibrary library, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler))]MTLCreateDynamicLibraryCompletionHandler completionHandler)
		{
			var library__handle__ = library!.GetNonNullHandle (nameof (library));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateDynamicLibraryCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newDynamicLibrary:completionHandler:"), library__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (library);
			return ret!;
		}
		[Export ("newDynamicLibraryWithURL:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateDynamicLibrary (NSUrl url, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateDynamicLibraryCompletionHandler))]MTLCreateDynamicLibraryCompletionHandler completionHandler)
		{
			var url__handle__ = url!.GetNonNullHandle (nameof (url));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateDynamicLibraryCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newDynamicLibraryWithURL:completionHandler:"), url__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (url);
			return ret!;
		}
		[Export ("newComputePipelineStateWithDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler))]MTLCreateComputePipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateComputePipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[Export ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateComputePipelineStateCompletionHandler))]MTLCreateComputePipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateComputePipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[Export ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateRenderPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[Export ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor? dynamicLinkingDescriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor.GetHandle ();
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateRenderPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[Export ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateRenderPipelineStateBySpecialization (MTL4PipelineDescriptor descriptor, IMTLRenderPipelineState pipeline, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTLCreateRenderPipelineStateCompletionHandler))]MTLCreateRenderPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var pipeline__handle__ = pipeline!.GetNonNullHandle (nameof (pipeline));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTLCreateRenderPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateBySpecializationWithDescriptor:pipeline:completionHandler:"), descriptor__handle__, pipeline__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (pipeline);
			return ret!;
		}
		[Export ("newBinaryFunctionWithDescriptor:compilerTaskOptions:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateBinaryFunction (MTL4BinaryFunctionDescriptor descriptor, MTL4CompilerTaskOptions? compilerTaskOptions, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTL4CreateBinaryFunctionCompletionHandler))]MTL4CreateBinaryFunctionCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var compilerTaskOptions__handle__ = compilerTaskOptions.GetHandle ();
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTL4CreateBinaryFunctionCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newBinaryFunctionWithDescriptor:compilerTaskOptions:completionHandler:"), descriptor__handle__, compilerTaskOptions__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (compilerTaskOptions);
			return ret!;
		}
		[Export ("newMachineLearningPipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4MachineLearningPipelineState? CreateMachineLearningPipelineState (MTL4MachineLearningPipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4MachineLearningPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTL4MachineLearningPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newMachineLearningPipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newMachineLearningPipelineStateWithDescriptor:completionHandler:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4CompilerTask CreateMachineLearningPipelineState (MTL4MachineLearningPipelineDescriptor descriptor, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMTL4CreateMachineLearningPipelineStateCompletionHandler))]MTL4CreateMachineLearningPipelineStateCompletionHandler completionHandler)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			if (completionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completionHandler));
			using var block_completionHandler = Trampolines.SDMTL4CreateMachineLearningPipelineStateCompletionHandler.CreateBlock (completionHandler);
			BlockLiteral *block_ptr_completionHandler = &block_completionHandler;
			IMTL4CompilerTask? ret;
			ret =  Runtime.GetINativeObject<IMTL4CompilerTask> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("newMachineLearningPipelineStateWithDescriptor:completionHandler:"), descriptor__handle__, (IntPtr) block_ptr_completionHandler), true)!;
			GC.KeepAlive (descriptor);
			return ret!;
		}
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
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMTL4PipelineDataSetSerializer? PipelineDataSetSerializer {
			[Export ("pipelineDataSetSerializer", ArgumentSemantic.Retain)]
			get {
				IMTL4PipelineDataSetSerializer ret;
				ret =  Runtime.GetINativeObject<IMTL4PipelineDataSetSerializer> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("pipelineDataSetSerializer")), false)!;
				return ret;
			}
		}
	}
}
