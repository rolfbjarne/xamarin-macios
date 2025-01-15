using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using ObjCRuntime;

#nullable enable

namespace Compression {
#if NET
		[SupportedOSPlatform ("ios12.2")]
		[SupportedOSPlatform ("macos12.0")]
		[SupportedOSPlatform ("maccatalyst15.0")]
		[SupportedOSPlatform ("tvos12.2")]
#endif
	[StructLayout (LayoutKind.Sequential)]
	struct CompressionStreamStruct {
		public IntPtr Destination; // uint8_t * dst_ptr
		public nint DestinationSize; // size_t dst_size;
		public IntPtr Source; // const uint8_t * src_ptr;
		public nint SourceSize; // size_t src_size;
		public IntPtr State; // void * __nullable state;


		[DllImport (Constants.libcompressionLibrary)]
		public unsafe static extern CompressionStatus compression_stream_init (CompressionStreamStruct* stream, StreamOperation operation, CompressionAlgorithm algorithm);

		[DllImport (Constants.libcompressionLibrary)]
		public unsafe static extern CompressionStatus compression_stream_process (CompressionStreamStruct* stream, StreamFlag flags);

		[DllImport (Constants.libcompressionLibrary)]
		public unsafe static extern CompressionStatus compression_stream_destroy (CompressionStreamStruct* stream);
	}
}
