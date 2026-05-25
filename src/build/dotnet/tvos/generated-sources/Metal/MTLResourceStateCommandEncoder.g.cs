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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Metal {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MTLResourceStateCommandEncoder</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios13.0")]
	[SupportedOSPlatform ("tvos16.0")]
	[SupportedOSPlatform ("macos")]
	[Protocol (Name = "MTLResourceStateCommandEncoder", WrapperType = typeof (MTLResourceStateCommandEncoderWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateTextureMappings:mode:regions:mipLevels:slices:numRegions:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (MTLSparseTextureMappingMode), typeof (IntPtr), typeof (IntPtr), typeof (IntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateTextureMapping:mode:region:mipLevel:slice:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (MTLSparseTextureMappingMode), typeof (MTLRegion), typeof (UIntPtr), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateTextureMapping:mode:indirectBuffer:indirectBufferOffset:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (MTLSparseTextureMappingMode), typeof (IMTLBuffer), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Update", Selector = "updateFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Wait", Selector = "waitForFence:", ParameterType = new Type [] { typeof (IMTLFence) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "MoveTextureMappings", Selector = "moveTextureMappingsFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:", ParameterType = new Type [] { typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin), typeof (MTLSize), typeof (IMTLTexture), typeof (UIntPtr), typeof (UIntPtr), typeof (MTLOrigin) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false })]
	public partial interface IMTLResourceStateCommandEncoder : INativeObject, IDisposable, 
		Metal.IMTLCommandEncoder
	{
		[global::Foundation.RequiredMember]
		[Export ("updateTextureMappings:mode:regions:mipLevels:slices:numRegions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (IMTLTexture texture, MTLSparseTextureMappingMode mode, nint regions, nint mipLevels, nint slices, nuint numRegions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (IMTLResourceStateCommandEncoder This, IMTLTexture texture, MTLSparseTextureMappingMode mode, nint regions, nint mipLevels, nint slices, nuint numRegions)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr_IntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("updateTextureMappings:mode:regions:mipLevels:slices:numRegions:"), texture__handle__, (UIntPtr) (ulong) mode, regions, mipLevels, slices, numRegions);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateTextureMapping:mode:region:mipLevel:slice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (IMTLTexture texture, MTLSparseTextureMappingMode mode, MTLRegion region, nuint mipLevel, nuint slice)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (IMTLResourceStateCommandEncoder This, IMTLTexture texture, MTLSparseTextureMappingMode mode, MTLRegion region, nuint mipLevel, nuint slice)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_MTLRegion_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("updateTextureMapping:mode:region:mipLevel:slice:"), texture__handle__, (UIntPtr) (ulong) mode, region, mipLevel, slice);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateTextureMapping:mode:indirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (IMTLTexture texture, MTLSparseTextureMappingMode mode, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (IMTLResourceStateCommandEncoder This, IMTLTexture texture, MTLSparseTextureMappingMode mode, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("updateTextureMapping:mode:indirectBuffer:indirectBufferOffset:"), texture__handle__, (UIntPtr) (ulong) mode, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (This);
			GC.KeepAlive (texture);
			GC.KeepAlive (indirectBuffer);
		}
		[global::Foundation.RequiredMember]
		[Export ("updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Update (IMTLFence fence)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Update (IMTLResourceStateCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("waitForFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Wait (IMTLFence fence)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _Wait (IMTLResourceStateCommandEncoder This, IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (This.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (This);
			GC.KeepAlive (fence);
		}
		[global::Foundation.RequiredMember]
		[Export ("moveTextureMappingsFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void MoveTextureMappings (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static void _MoveTextureMappings (IMTLResourceStateCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (This.Handle, Selector.GetHandle ("moveTextureMappingsFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		[DynamicDependencyAttribute ("MoveTextureMappings(Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin,Metal.MTLSize,Metal.IMTLTexture,System.UIntPtr,System.UIntPtr,Metal.MTLOrigin)")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLFence)")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLTexture,Metal.MTLSparseTextureMappingMode,Metal.IMTLBuffer,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLTexture,Metal.MTLSparseTextureMappingMode,Metal.MTLRegion,System.UIntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Update(Metal.IMTLTexture,Metal.MTLSparseTextureMappingMode,System.IntPtr,System.IntPtr,System.IntPtr,System.UIntPtr)")]
		[DynamicDependencyAttribute ("Wait(Metal.IMTLFence)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLResourceStateCommandEncoderWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMTLResourceStateCommandEncoder ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMTLResourceStateCommandEncoder" /> interface to support all the methods from the MTLResourceStateCommandEncoder protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMTLResourceStateCommandEncoder" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MTLResourceStateCommandEncoder protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MTLResourceStateCommandEncoder_Extensions {
		[SupportedOSPlatform ("macos13.0")]
		[SupportedOSPlatform ("ios16.0")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst16.0")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void MoveTextureMappings (this IMTLResourceStateCommandEncoder This, IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (This.Handle, Selector.GetHandle ("moveTextureMappingsFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (This);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MTLResourceStateCommandEncoderWrapper : BaseWrapper, IMTLResourceStateCommandEncoder {
		public MTLResourceStateCommandEncoderWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MTLResourceStateCommandEncoderWrapper))]
		static MTLResourceStateCommandEncoderWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("updateTextureMappings:mode:regions:mipLevels:slices:numRegions:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Update (IMTLTexture texture, MTLSparseTextureMappingMode mode, nint regions, nint mipLevels, nint slices, nuint numRegions)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_IntPtr_IntPtr_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("updateTextureMappings:mode:regions:mipLevels:slices:numRegions:"), texture__handle__, (UIntPtr) (ulong) mode, regions, mipLevels, slices, numRegions);
			GC.KeepAlive (texture);
		}
		[Export ("updateTextureMapping:mode:region:mipLevel:slice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Update (IMTLTexture texture, MTLSparseTextureMappingMode mode, MTLRegion region, nuint mipLevel, nuint slice)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_MTLRegion_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("updateTextureMapping:mode:region:mipLevel:slice:"), texture__handle__, (UIntPtr) (ulong) mode, region, mipLevel, slice);
			GC.KeepAlive (texture);
		}
		[Export ("updateTextureMapping:mode:indirectBuffer:indirectBufferOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Update (IMTLTexture texture, MTLSparseTextureMappingMode mode, IMTLBuffer indirectBuffer, nuint indirectBufferOffset)
		{
			var texture__handle__ = texture!.GetNonNullHandle (nameof (texture));
			var indirectBuffer__handle__ = indirectBuffer!.GetNonNullHandle (nameof (indirectBuffer));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_NativeHandle_UIntPtr (this.Handle, Selector.GetHandle ("updateTextureMapping:mode:indirectBuffer:indirectBufferOffset:"), texture__handle__, (UIntPtr) (ulong) mode, indirectBuffer__handle__, indirectBufferOffset);
			GC.KeepAlive (texture);
			GC.KeepAlive (indirectBuffer);
		}
		[Export ("updateFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Update (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("updateFence:"), fence__handle__);
			GC.KeepAlive (fence);
		}
		[Export ("waitForFence:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void Wait (IMTLFence fence)
		{
			var fence__handle__ = fence!.GetNonNullHandle (nameof (fence));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("waitForFence:"), fence__handle__);
			GC.KeepAlive (fence);
		}
		[Export ("moveTextureMappingsFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void MoveTextureMappings (IMTLTexture sourceTexture, nuint sourceSlice, nuint sourceLevel, MTLOrigin sourceOrigin, MTLSize sourceSize, IMTLTexture destinationTexture, nuint destinationSlice, nuint destinationLevel, MTLOrigin destinationOrigin)
		{
			var sourceTexture__handle__ = sourceTexture!.GetNonNullHandle (nameof (sourceTexture));
			var destinationTexture__handle__ = destinationTexture!.GetNonNullHandle (nameof (destinationTexture));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle_UIntPtr_UIntPtr_MTLOrigin_MTLSize_NativeHandle_UIntPtr_UIntPtr_MTLOrigin (this.Handle, Selector.GetHandle ("moveTextureMappingsFromTexture:sourceSlice:sourceLevel:sourceOrigin:sourceSize:toTexture:destinationSlice:destinationLevel:destinationOrigin:"), sourceTexture__handle__, sourceSlice, sourceLevel, sourceOrigin, sourceSize, destinationTexture__handle__, destinationSlice, destinationLevel, destinationOrigin);
			GC.KeepAlive (sourceTexture);
			GC.KeepAlive (destinationTexture);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("endEncoding")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EndEncoding ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("endEncoding"));
		}
		/// <param name="signpost">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("insertDebugSignpost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void InsertDebugSignpost (string signpost)
		{
			if (signpost is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (signpost));
			var nssignpost = CFString.CreateNative (signpost);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("insertDebugSignpost:"), nssignpost);
			CFString.ReleaseNative (nssignpost);
		}
		/// <param name="debugGroup">To be added.</param><summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("pushDebugGroup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PushDebugGroup (string debugGroup)
		{
			if (debugGroup is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (debugGroup));
			var nsdebugGroup = CFString.CreateNative (debugGroup);
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("pushDebugGroup:"), nsdebugGroup);
			CFString.ReleaseNative (nsdebugGroup);
		}
		/// <summary>To be added.</summary><remarks>To be added.</remarks>
		[Export ("popDebugGroup")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void PopDebugGroup ()
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("popDebugGroup"));
		}
		[Export ("barrierAfterQueueStages:beforeStages:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void BarrierAfterQueueStages (MTLStages afterQueueStages, MTLStages beforeStages)
		{
			global::ObjCRuntime.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("barrierAfterQueueStages:beforeStages:"), (UIntPtr) (ulong) afterQueueStages, (UIntPtr) (ulong) beforeStages);
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public IMTLDevice Device {
			[Export ("device")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				IMTLDevice ret;
				ret =  Runtime.GetINativeObject<IMTLDevice> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("device")), false)!;
				return ret;
			}
		}
		/// <summary>To be added.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[SupportedOSPlatform ("ios13.0")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos16.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public string Label {
			[Export ("label")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				string ret;
				ret = CFString.FromHandle (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend (this.Handle, Selector.GetHandle ("label")), false)!;
				return ret;
			}
			[Export ("setLabel:")]
			[SupportedOSPlatform ("ios13.0")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("tvos16.0")]
			[SupportedOSPlatform ("maccatalyst")]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("setLabel:"), nsvalue);
				CFString.ReleaseNative (nsvalue);
			}
		}
	}
}
