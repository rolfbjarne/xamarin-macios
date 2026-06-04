#nullable enable

namespace NetworkExtension {

	// needed for generated Async support
	//public delegate void NEPacketTunnelFlowReadHandler (NSData [] packets, NSNumber [] protocols);

	// avoid generator default `Arg1` and `Arg2` since Action<> was used
	/// <summary>Gets or sets the n e packet tunnel flow read result.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos17.0")]
	public class NEPacketTunnelFlowReadResult {

#if !COREBUILD
		/// <param name="packets">The packets.</param>
		///         <param name="protocols">The protocols.</param>
		///         <summary>Creates a new <see cref="NEPacketTunnelFlowReadResult" /> instance.</summary>
		public NEPacketTunnelFlowReadResult (NSData [] packets, NSNumber [] protocols)
		{
			Packets = packets;
			Protocols = protocols;
		}

		/// <summary>Gets or sets the packet data.</summary>
		public NSData [] Packets { get; set; }

		/// <summary>Gets or sets the protocol numbers associated with each packet.</summary>
		public NSNumber [] Protocols { get; set; }
#endif
	}
}
