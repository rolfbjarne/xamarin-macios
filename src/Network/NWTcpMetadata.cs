//
// NWTcpMetadata.cs: Bindings the Netowrk nw_protocol_metadata_t API that is an Tcp.
//
// Authors:
//   Manuel de la Pena <mandel@microsoft.com>
//
// Copyrigh 2019 Microsoft
//

#nullable enable

using System;
using ObjCRuntime;
using Foundation;
using CoreFoundation;

#if !NET
using NativeHandle = System.IntPtr;
#endif

namespace Network {

#if NET
	[SupportedOSPlatform ("tvos12.2")]
	[SupportedOSPlatform ("macos12.0")]
	[SupportedOSPlatform ("ios12.2")]
	[SupportedOSPlatform ("maccatalyst15.0")]
#endif
	public class NWTcpMetadata : NWProtocolMetadata {

		[Preserve (Conditional = true)]
		internal NWTcpMetadata (NativeHandle handle, bool owns) : base (handle, owns) { }

		public uint AvailableReceiveBuffer => nw_tcp_get_available_receive_buffer (GetCheckedHandle ());

		public uint AvailableSendBuffer => nw_tcp_get_available_send_buffer (GetCheckedHandle ());
	}
}
