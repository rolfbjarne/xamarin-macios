using System;
using System.Runtime.InteropServices;

using Foundation;
using ModelIO;
using ObjCRuntime;
using Metal;

#nullable enable

namespace Metal {
	public partial class MTLVertexDescriptor {

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
#endif
		[DllImport (Constants.MetalKitLibrary)]
		static extern  /* MTLVertexDescriptor __nonnull */ IntPtr MTKMetalVertexDescriptorFromModelIO (/* MDLVertexDescriptor __nonnull */ IntPtr modelIODescriptor);

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
#endif
		public static MTLVertexDescriptor? FromModelIO (MDLVertexDescriptor descriptor)
		{
			if (descriptor is null)
				throw new ArgumentException ("descriptor");
			return Runtime.GetNSObject<MTLVertexDescriptor> (MTKMetalVertexDescriptorFromModelIO (descriptor.Handle));
		}

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		[DllImport (Constants.MetalKitLibrary)]
		unsafe static extern /* MTLVertexDescriptor __nonnull */ IntPtr MTKMetalVertexDescriptorFromModelIOWithError (/* MDLVertexDescriptor __nonnull */ IntPtr modelIODescriptor, IntPtr* error);

#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("tvos12.2")]
		[SupportedOSPlatform ("maccatalyst15.0")]
#endif
		public static MTLVertexDescriptor? FromModelIO (MDLVertexDescriptor descriptor, out NSError? error)
		{
			if (descriptor is null)
				throw new ArgumentException ("descriptor");
			IntPtr err;
			MTLVertexDescriptor? vd;
			unsafe {
				vd = Runtime.GetNSObject<MTLVertexDescriptor> (MTKMetalVertexDescriptorFromModelIOWithError (descriptor.Handle, &err));
			}
			error = Runtime.GetNSObject<NSError> (err);
			return vd;
		}
	}
}
