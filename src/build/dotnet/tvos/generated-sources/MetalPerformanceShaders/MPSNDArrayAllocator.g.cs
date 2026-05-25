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
namespace MetalPerformanceShaders {
	#pragma warning disable CS1573
	/// <summary>This interface represents the Objective-C protocol <c>MPSNDArrayAllocator</c>.</summary>
	/// <remarks>
	///   <para>A class that implements this interface (and subclasses <see cref="NSObject" />) will be exported to Objective-C as implementing the Objective-C protocol this interface represents.</para>
	///   <para>A class may also implement members from this interface to implement members from the protocol.</para>
	/// </remarks>
	[Protocol (Name = "MPSNDArrayAllocator", WrapperType = typeof (MPSNDArrayAllocatorWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "AllocateArray", Selector = "arrayForCommandBuffer:arrayDescriptor:kernel:", ReturnType = typeof (MetalPerformanceShaders.MPSNDArray), ParameterType = new Type [] { typeof (IMTLCommandBuffer), typeof (MetalPerformanceShaders.MPSNDArrayDescriptor), typeof (MetalPerformanceShaders.MPSKernel) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IMPSNDArrayAllocator : INativeObject, IDisposable, 
		Foundation.INSCoding
		, Foundation.INSCopying
		, Foundation.INSSecureCoding
	{
		[global::Foundation.RequiredMember]
		[Export ("arrayForCommandBuffer:arrayDescriptor:kernel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MPSNDArray AllocateArray (global::Metal.IMTLCommandBuffer cmdBuf, MPSNDArrayDescriptor descriptor, MPSKernel kernel)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		internal static MPSNDArray _AllocateArray (IMPSNDArrayAllocator This, global::Metal.IMTLCommandBuffer cmdBuf, MPSNDArrayDescriptor descriptor, MPSKernel kernel)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			MPSNDArray? ret;
			ret =  Runtime.GetNSObject<MPSNDArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (This.Handle, Selector.GetHandle ("arrayForCommandBuffer:arrayDescriptor:kernel:"), cmdBuf__handle__, descriptor__handle__, kernel__handle__), false)!;
			GC.KeepAlive (This);
			GC.KeepAlive (cmdBuf);
			GC.KeepAlive (descriptor);
			GC.KeepAlive (kernel);
			return ret!;
		}
		[DynamicDependencyAttribute ("AllocateArray(Metal.IMTLCommandBuffer,MetalPerformanceShaders.MPSNDArrayDescriptor,MetalPerformanceShaders.MPSKernel)")]
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.Interfaces | DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSNDArrayAllocatorWrapper))]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static IMPSNDArrayAllocator ()
		{
			GC.KeepAlive (null);
		}
	}
	#pragma warning restore CS1573
	internal unsafe sealed class MPSNDArrayAllocatorWrapper : BaseWrapper, IMPSNDArrayAllocator {
		public MPSNDArrayAllocatorWrapper (NativeHandle handle, bool owns)
			: base (handle, owns)
		{
		}
		[DynamicDependencyAttribute (DynamicallyAccessedMemberTypes.PublicConstructors, typeof (MPSNDArrayAllocatorWrapper))]
		static MPSNDArrayAllocatorWrapper ()
		{
			GC.KeepAlive (null);
		}
		[Export ("arrayForCommandBuffer:arrayDescriptor:kernel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MPSNDArray AllocateArray (global::Metal.IMTLCommandBuffer cmdBuf, MPSNDArrayDescriptor descriptor, MPSKernel kernel)
		{
			var cmdBuf__handle__ = cmdBuf!.GetNonNullHandle (nameof (cmdBuf));
			var descriptor__handle__ = descriptor!.GetNonNullHandle (nameof (descriptor));
			var kernel__handle__ = kernel!.GetNonNullHandle (nameof (kernel));
			MPSNDArray? ret;
			ret =  Runtime.GetNSObject<MPSNDArray> (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle_NativeHandle_NativeHandle (this.Handle, Selector.GetHandle ("arrayForCommandBuffer:arrayDescriptor:kernel:"), cmdBuf__handle__, descriptor__handle__, kernel__handle__), false)!;
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
		/// <param name="zone">Developers should pass <see langword="null" />.  Memory zones are no longer used.</param><summary>Performs a copy of the underlying Objective-C object.</summary><returns>The newly-allocated object.</returns><remarks><para>This method performs a "shallow copy" of <see langword="this" />. If this object contains references to external objects, the new object will contain references to the same object.</para></remarks>
		[Export ("copyWithZone:")]
		[return: ReleaseAttribute ()]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public NSObject Copy (NSZone? zone)
		{
			var zone__handle__ = zone.GetHandle ();
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ObjCRuntime.Messaging.NativeHandle_objc_msgSend_NativeHandle (this.Handle, Selector.GetHandle ("copyWithZone:"), zone__handle__), true)!;
			GC.KeepAlive (zone);
			return ret!;
		}
	}
}
