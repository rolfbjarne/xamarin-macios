#nullable enable

namespace StoreKit {

	public partial class SKReceiptRefreshRequest {
#if __TVOS__ && !XAMCORE_5_0
		// This method was incorrectly exposed on tvOS; but it doesn't exist there.
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[EditorBrowsable (EditorBrowsableState.Never))]
		public static void TerminateForInvalidReceipt ()
		{
			throw new PlatformNotSupportedException ();
		}
#endif // __TVOS__ && !XAMCORE_5_0

#if !__TVOS__
		/// <summary>Terminates the app if the license to use it has expired.</summary>
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[UnsupportedOSPlatform ("tvos")]
		[DllImport (Constants.StoreKitLibrary, EntryPoint = "SKTerminateForInvalidReceipt")]
		static extern public void TerminateForInvalidReceipt ();
#endif // !__TVOS__
	}
}
