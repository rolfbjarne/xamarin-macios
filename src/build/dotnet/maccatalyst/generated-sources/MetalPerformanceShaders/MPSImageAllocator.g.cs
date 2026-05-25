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
namespace MetalPerformanceShaders {
	#pragma warning disable CS1573
	/// <summary>Interface defining a factory that generates a <see cref="T:MetalPerformanceShaders.MPSImage" /> from a <see cref="T:Metal.IMTLCommandBuffer" />, a <see cref="T:MetalPerformanceShaders.MPSImageDescriptor" />, and a <see cref="T:MetalPerformanceShaders.MPSKernel" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	[Protocol (Name = "MPSImageAllocator", WrapperType = typeof (MPSImageAllocatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "GetImage", Selector = "imageForCommandBuffer:imageDescriptor:kernel:", ReturnType = typeof (MetalPerformanceShaders.MPSImage), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSImageDescriptor), typeof (MetalPerformanceShaders.MPSKernel) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetImageBatch", Selector = "imageBatchForCommandBuffer:imageDescriptor:kernel:count:", ReturnType = typeof (global::Foundation.NSArray<global::MetalPerformanceShaders.MPSImage>), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSImageDescriptor), typeof (MetalPerformanceShaders.MPSKernel), typeof (UIntPtr) }, ParameterByRef = new bool [] { false, false, false, false })]
	public partial interface IMPSImageAllocator : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSSecureCoding
	{
		/// <param name="cmdBuf">To be added.</param><param name="descriptor">To be added.</param><param name="kernel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.RequiredMember]
		[Export ("imageForCommandBuffer:imageDescriptor:kernel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSImage GetImage (global::Metal.IMTLCommandBuffer cmdBuf, MPSImageDescriptor descriptor, MPSKernel kernel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		/// <param name="cmdBuf">To be added.</param><param name="descriptor">To be added.</param><param name="kernel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSImage _GetImage (IMPSImageAllocator This, global::Metal.IMTLCommandBuffer cmdBuf, MPSImageDescriptor descriptor, MPSKernel kernel)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			MPSImage? ret;
			ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("imageForCommandBuffer:imageDescriptor:kernel:"), cmdBuf__handle__, descriptor__handle__, kernel__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (cmdBuf);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (kernel);
			return ret!;
		}
		/// <param name="commandBuffer">To be added.</param><param name="descriptor">To be added.</param><param name="kernel">To be added.</param><param name="count">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[global::Foundation.OptionalMember]
		[Export ("imageBatchForCommandBuffer:imageDescriptor:kernel:count:")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSArray<MPSImage> GetImageBatch (global::Metal.IMTLCommandBuffer commandBuffer, MPSImageDescriptor descriptor, MPSKernel kernel, nuint count)
		{
			return _GetImageBatch (this, commandBuffer, descriptor, kernel, count);
		}
		/// <param name="commandBuffer">To be added.</param><param name="descriptor">To be added.</param><param name="kernel">To be added.</param><param name="count">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static NSArray<MPSImage> _GetImageBatch (IMPSImageAllocator This, global::Metal.IMTLCommandBuffer commandBuffer, MPSImageDescriptor descriptor, MPSKernel kernel, nuint count)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			NSArray<MPSImage>? ret;
			ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("imageBatchForCommandBuffer:imageDescriptor:kernel:count:"), commandBuffer__handle__, descriptor__handle__, kernel__handle__, count), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (kernel);
			return ret!;
		}
		[DynamicDependencyAttribute ("GetImage(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSImageDescriptor,MetalPerformanceShaders.MPSKernel)")]
		[DynamicDependencyAttribute ("GetImageBatch(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSImageDescriptor,MetalPerformanceShaders.MPSKernel,System.UIntPtr)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSImageAllocatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSImageAllocator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	#pragma warning disable CS1573
	/// <summary>Extension methods to the <see cref="IMPSImageAllocator" /> interface to support all the methods from the MPSImageAllocator protocol.</summary>
	/// <remarks>
	///   <para>The extension methods for <see cref="IMPSImageAllocator" /> interface allow developers to treat instances of the interface as having all the optional methods of the original MPSImageAllocator protocol. Since the interface only contains the required members, these extension methods allow developers to call the optional members of the protocol.</para>
	/// </remarks>
	public unsafe static partial class MPSImageAllocator_Extensions {
		/// <param name="commandBuffer">To be added.</param><param name="descriptor">To be added.</param><param name="kernel">To be added.</param><param name="count">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSArray<MPSImage> GetImageBatch (this IMPSImageAllocator This, global::Metal.IMTLCommandBuffer commandBuffer, MPSImageDescriptor descriptor, MPSKernel kernel, nuint count)
		{
			var commandBuffer__handle__ = commandBuffer!.GetNonNullHandle (nameof (commandBuffer));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			NSArray<MPSImage>? ret;
			ret =  Runtime.GetNSObject<NSArray<MPSImage>> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle_UIntPtr (This.Handle, Selector.GetHandle ("imageBatchForCommandBuffer:imageDescriptor:kernel:count:"), commandBuffer__handle__, descriptor__handle__, kernel__handle__, count), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (commandBuffer);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (kernel);
			return ret!;
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSImageAllocatorWrapper : BaseWrapper, IMPSImageAllocator {
		public MPSImageAllocatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSImageAllocatorWrapper))]
		static MPSImageAllocatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		/// <param name="cmdBuf">To be added.</param><param name="descriptor">To be added.</param><param name="kernel">To be added.</param><summary>To be added.</summary><returns>To be added.</returns><remarks>To be added.</remarks>
		[Export ("imageForCommandBuffer:imageDescriptor:kernel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSImage GetImage (global::Metal.IMTLCommandBuffer cmdBuf, MPSImageDescriptor descriptor, MPSKernel kernel)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			MPSImage? ret;
			ret =  Runtime.GetNSObject<MPSImage> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("imageForCommandBuffer:imageDescriptor:kernel:"), cmdBuf__handle__, descriptor__handle__, kernel__handle__), false)!;
			GC.KeepAlive (cmdBuf);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (kernel);
			return ret!;
		}
		/// <summary>Encodes the state of the object using the provided encoder.</summary><param name="encoder">The encoder object where the state of the object will be stored</param><remarks><para>This method is part of the <see cref="T:Foundation.INSCoding" /> protocol and is used by applications to preserve the state of the object into an archive.</para><para>Developers will typically create an <see cref="T:Foundation.NSKeyedArchiver" /> and then invoke the <see cref="M:Foundation.NSKeyedArchiver.ArchiveRootObjectToFile(Foundation.NSObject,System.String)" /> method which will call into this method.</para><para>If developers want to allow their object to be archived, they should override this method and store their state in using the provided <paramref name="encoder" /> parameter. In addition, developers should also implement a constructor that takes an NSCoder argument and is exported with <c>[Export ("initWithCoder:")]</c>.</para><example><code lang="csharp lang-csharp"><![CDATA[public void override EncodeTo (NSCoder coder) {
		/// coder.Encode (1, key: "version");
		/// coder.Encode (userName, key: "userName");
		/// coder.Encode (hostName, key: "hostName");]]></code></example></remarks>
		[Export ("encodeWithCoder:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void EncodeTo (NSCoder encoder)
		{
			var encoder__handle__ = encoder!.GetNonNullHandle (nameof (encoder));
			global::ObjCRuntime.Messaging.void_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("encodeWithCoder:"), encoder__handle__);
			GC.KeepAlive (encoder);
		}
	}
}
