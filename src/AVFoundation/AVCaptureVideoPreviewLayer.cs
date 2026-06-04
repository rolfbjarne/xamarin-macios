#if !TVOS

using CoreFoundation;
using AudioToolbox;

#nullable enable

namespace AVFoundation {
	public partial class AVCaptureVideoPreviewLayer {

		/// <summary>Enumerates values that specify the presence or absence of a capture session connection.</summary>
		public enum InitMode {
			/// <summary>Indicates a connection.</summary>
			WithConnection,
			/// <summary>Indicates no connection.</summary>
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			[SupportedOSPlatform ("maccatalyst")]
			WithNoConnection,
		}

		/// <param name="session">The session.</param>
		///         <param name="mode">The mode.</param>
		///         <summary>Creates a new preview layer with the supplied capture session and initialization mode.</summary>
		public AVCaptureVideoPreviewLayer (AVCaptureSession session, InitMode mode) : base (NSObjectFlag.Empty)
		{
			switch (mode) {
			case InitMode.WithConnection:
				InitializeHandle (InitWithConnection (session));
				break;
			case InitMode.WithNoConnection:
				InitializeHandle (InitWithNoConnection (session));
				break;
			default:
				throw new ArgumentException (nameof (mode));
			}
		}

		/// <param name="session">The session.</param>
		///         <summary>Creates a new preview layer with the supplied capture session.</summary>
		public AVCaptureVideoPreviewLayer (AVCaptureSession session) : this (session, InitMode.WithConnection) { }
	}
}

#endif
