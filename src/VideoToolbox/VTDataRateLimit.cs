//
// VideoToolbox core types
//
// Authors: 
// 		Miguel de Icaza (miguel@xamarin.com)
//		Alex Soto (alex.soto@xamarin.com)
//
// Copyright 2014 Xamarin Inc
//

#nullable enable

namespace VideoToolbox {
	/// <summary>Strongly typed representation of bytes and seconds used in <see cref="VideoToolbox.VTCompressionProperties.DataRateLimits" />.</summary>
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("tvos")]
	public struct VTDataRateLimit {
		/// <summary>Gets or sets the number of bytes.</summary>
		public uint NumberOfBytes { get; set; }
		/// <summary>Gets or sets the seconds.</summary>
		public double Seconds { get; set; }

		/// <param name="numberOfBytes">The number of bytes.</param>
		///         <param name="seconds">The seconds.</param>
		///         <summary>Creates a new <see cref="VTDataRateLimit" /> instance.</summary>
		public VTDataRateLimit (uint numberOfBytes, double seconds) : this ()
		{
			NumberOfBytes = numberOfBytes;
			Seconds = seconds;
		}
	}
}
