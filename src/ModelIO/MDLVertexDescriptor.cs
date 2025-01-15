using System;
using System.Runtime.InteropServices;

using Foundation;
using ModelIO;
using ObjCRuntime;
using Metal;

#nullable enable

namespace ModelIO {
	public partial class MDLVertexDescriptor {
		[DllImport (Constants.MetalKitLibrary)]
		static extern  /* MDLVertexDescriptor __nonnull */ IntPtr MTKModelIOVertexDescriptorFromMetal (/* MTLVertexDescriptor __nonnull */ IntPtr mtlDescriptor);

		public static MDLVertexDescriptor? FromMetal (MTLVertexDescriptor descriptor)
		{
			if (descriptor is null)
				throw new ArgumentException (nameof (descriptor));
			return Runtime.GetNSObject<MDLVertexDescriptor> (MTKModelIOVertexDescriptorFromMetal (descriptor.Handle));
		}

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		[DllImport (Constants.MetalKitLibrary)]
		unsafe static extern /* MDLVertexDescriptor __nonnull */ IntPtr MTKModelIOVertexDescriptorFromMetalWithError (/* MTLVertexDescriptor __nonnull */ IntPtr metalDescriptor, /* NSError */ IntPtr* error);

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		public static MDLVertexDescriptor? FromMetal (MTLVertexDescriptor descriptor, out NSError? error)
		{
			if (descriptor is null)
				throw new ArgumentException (nameof (descriptor));
			IntPtr err;
			MDLVertexDescriptor? vd;
			unsafe {
				vd = Runtime.GetNSObject<MDLVertexDescriptor> (MTKModelIOVertexDescriptorFromMetalWithError (descriptor.Handle, &err));
			}
			error = Runtime.GetNSObject<NSError> (err);
			return vd;
		}
	}
}
