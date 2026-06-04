#nullable enable

namespace NetworkExtension {

	// needed for generated Async support
	//public delegate void NEPacketTunnelFlowReadHandler (NSData [] packets, NSNumber [] protocols);

	// avoid generator default `Arg1` and `Arg2` since Action<> was used
	/// <summary>To be added.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos17.0")]
	public class NEPacketTunnelFlowReadResult {

#if !COREBUILD
		/// <param name="packets">The packets.</param>
		///         <param name="protocols">The protocols.</param>
		///         <summary>To be added.</summary>
		public NEPacketTunnelFlowReadResult (NSData [] packets, NSNumber [] protocols)
		{
			Packets = packets;
			Protocols = protocols;
		}

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public NSData [] Packets { get; set; }

		/// <summary>To be added.</summary>
		///         <value>To be added.</value>
		public NSNumber [] Protocols { get; set; }
#endif
	}
}
