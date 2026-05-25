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
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTL4Archive</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos26.0")]
	[SupportedOSPlatform ("ios26.0")]
	[SupportedOSPlatform ("tvos26.0")]
	[SupportedOSPlatform ("maccatalyst26.0")]
	[Protocol (Name = "MTL4Archive", WrapperType = typeof (MTL4ArchiveWrapper), BackwardsCompatibleCodeGeneration = false)]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (MTL4ComputePipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateComputePipelineState", Selector = "newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:error:", ReturnType = typeof (IMTLComputePipelineState), ParameterType = new Type [] { typeof (MTL4ComputePipelineDescriptor), typeof (MTL4PipelineStageDynamicLinkingDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateRenderPipelineState", Selector = "newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:error:", ReturnType = typeof (IMTLRenderPipelineState), ParameterType = new Type [] { typeof (MTL4PipelineDescriptor), typeof (MTL4RenderPipelineDynamicLinkingDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "CreateBinaryFunction", Selector = "newBinaryFunctionWithDescriptor:error:", ReturnType = typeof (IMTL4BinaryFunction), ParameterType = new Type [] { typeof (MTL4BinaryFunctionDescriptor), typeof (NSError) }, ParameterByRef = new bool [] { false, true })]
	[ProtocolMember (IsRequired = true, IsProperty = true, IsStatic = false, Name = "Label", Selector = "label", PropertyType = typeof (string), GetterSelector = "label", SetterSelector = "setLabel:", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IMTL4Archive : INativeObject, IDisposable
	{
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState? _CreateComputePipelineState (IMTL4Archive This, MTL4ComputePipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor dynamicLinkingDescriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLComputePipelineState? _CreateComputePipelineState (IMTL4Archive This, MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor dynamicLinkingDescriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor!.GetNonNullHandle (nameof (dynamicLinkingDescriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineState (IMTL4Archive This, MTL4PipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor dynamicLinkingDescriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTLRenderPipelineState? _CreateRenderPipelineState (IMTL4Archive This, MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor dynamicLinkingDescriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor!.GetNonNullHandle (nameof (dynamicLinkingDescriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[global::Foundation.RequiredMember]
		[Export ("newBinaryFunctionWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual IMTL4BinaryFunction? CreateBinaryFunction (MTL4BinaryFunctionDescriptor descriptor, out NSError? error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal unsafe static IMTL4BinaryFunction? _CreateBinaryFunction (IMTL4Archive This, MTL4BinaryFunctionDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4BinaryFunction? ret;
			ret =  Runtime.GetINativeObject<IMTL4BinaryFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (This.Handle, Selector.GetHandle ("newBinaryFunctionWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (This);
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[DynamicDependencyAttribute ("CreateBinaryFunction(Metal.MTL4BinaryFunctionDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTL4ComputePipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateComputePipelineState(Metal.MTL4ComputePipelineDescriptor,Metal.MTL4PipelineStageDynamicLinkingDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTL4PipelineDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("CreateRenderPipelineState(Metal.MTL4PipelineDescriptor,Metal.MTL4RenderPipelineDynamicLinkingDescriptor,Foundation.NSError@)")]
		[DynamicDependencyAttribute ("Label")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4ArchiveWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTL4Archive ()
		{
			GC.KeepAlive (null);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[global::Foundation.RequiredMember]
		public virtual string? Label {
			[Export ("label")]
			get {
				return _GetLabel (this);
			}
			[Export ("setLabel:")]
			set {
				_SetLabel (this, value);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static string _GetLabel (IMTL4Archive This)
		{
			string ret;
			ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (This.Handle, Selector.GetHandle ("label")), false)!;
			GC.KeepAlive (This);
			return ret;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _SetLabel (IMTL4Archive This, string? value)
		{
			var nsvalue = CFString.CreateNative (value);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
			GC.KeepAlive (This);
			CFString.ReleaseNative (nsvalue);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTL4ArchiveWrapper : BaseWrapper, IMTL4Archive {
		public MTL4ArchiveWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTL4ArchiveWrapper))]
		static MTL4ArchiveWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("newComputePipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLComputePipelineState? CreateComputePipelineState (MTL4ComputePipelineDescriptor descriptor, MTL4PipelineStageDynamicLinkingDescriptor dynamicLinkingDescriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor!.GetNonNullHandle (nameof (dynamicLinkingDescriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLComputePipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLComputePipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newComputePipelineStateWithDescriptor:dynamicLinkingDescriptor:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineStateWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTLRenderPipelineState? CreateRenderPipelineState (MTL4PipelineDescriptor descriptor, MTL4RenderPipelineDynamicLinkingDescriptor dynamicLinkingDescriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var dynamicLinkingDescriptor__handle__ = dynamicLinkingDescriptor!.GetNonNullHandle (nameof (dynamicLinkingDescriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTLRenderPipelineState? ret;
			ret =  Runtime.GetINativeObject<IMTLRenderPipelineState> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newRenderPipelineStateWithDescriptor:dynamicLinkingDescriptor:error:"), descriptor__handle__, dynamicLinkingDescriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			GC.KeepAlive (dynamicLinkingDescriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[Export ("newBinaryFunctionWithDescriptor:error:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe IMTL4BinaryFunction? CreateBinaryFunction (MTL4BinaryFunctionDescriptor descriptor, out NSError? error)
		{
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			NativeHandle errorValue = IntPtr.Zero;
			IMTL4BinaryFunction? ret;
			ret =  Runtime.GetINativeObject<IMTL4BinaryFunction> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_ref_NativeHandle (this.Handle, Selector.GetHandle ("newBinaryFunctionWithDescriptor:error:"), descriptor__handle__, &errorValue), true)!;
			GC.KeepAlive (descriptor);
			error = Runtime.GetNSObject<NSError> (errorValue)!;
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public string? Label {
			[Export ("label")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			set {
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
