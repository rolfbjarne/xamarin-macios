
using ModelIO;
using Metal;

#nullable enable

namespace ModelIO {
	public partial class MDLVertexDescriptor {
		[DllImport (Constants.MetalKitLibrary)]
		static extern  /* MDLVertexDescriptor __nonnull */ IntPtr MTKModelIOVertexDescriptorFromMetal (/* MTLVertexDescriptor __nonnull */ IntPtr mtlDescriptor);

		/// <param name="descriptor">The descriptor.</param>
		///         <summary>Creates a new vertex descriptor from a Metal vertex descriptor.</summary>
		public static MDLVertexDescriptor? FromMetal (MTLVertexDescriptor descriptor)
		{
			if (descriptor is null)
				throw new ArgumentException (nameof (descriptor));
			MDLVertexDescriptor? result = Runtime.GetNSObject<MDLVertexDescriptor> (MTKModelIOVertexDescriptorFromMetal (descriptor.Handle));
			GC.KeepAlive (descriptor);
			return result;
		}

		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		[DllImport (Constants.MetalKitLibrary)]
		unsafe static extern /* MDLVertexDescriptor __nonnull */ IntPtr MTKModelIOVertexDescriptorFromMetalWithError (/* MTLVertexDescriptor __nonnull */ IntPtr metalDescriptor, /* NSError */ IntPtr* error);

		/// <param name="descriptor">The descriptor.</param>
		///         <param name="error">The error that occurred, or <see langword="null" /> if no error occurred.</param>
		///         <summary>Creates a Model IO vertex descriptor from the specified metal vertex descriptor.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("tvos")]
		[SupportedOSPlatform ("maccatalyst")]
		public static MDLVertexDescriptor? FromMetal (MTLVertexDescriptor descriptor, out NSError? error)
		{
			if (descriptor is null)
				throw new ArgumentException (nameof (descriptor));
			IntPtr err;
			MDLVertexDescriptor? vd;
			unsafe {
				vd = Runtime.GetNSObject<MDLVertexDescriptor> (MTKModelIOVertexDescriptorFromMetalWithError (descriptor.Handle, &err));
				GC.KeepAlive (descriptor);
			}
			error = Runtime.GetNSObject<NSError> (err);
			return vd;
		}
	}
}
