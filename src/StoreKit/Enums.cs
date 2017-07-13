using XamCore.ObjCRuntime;

namespace XamCore.StoreKit {

	// typedef NSInteger SKPaymentTransactionState;
	// StoreKit.framework/Headers/SKPaymentTransaction.h
	[Native]
	public enum SKPaymentTransactionState : nint {
		Purchasing,
		Purchased,
		Failed,  
		Restored,
		[iOS (8,0)]Deferred
	}

	// untyped enum and not used in API - so it _could_ be an `int`
	// OTOH it's meant to be used with NSError.Code which is an NSInteger/nint
	// StoreKit.framework/Headers/SKError.h
	[Native]
	[ErrorDomain ("SKErrorDomain")]
	public enum SKError : nint {
		Unknown,
		ClientInvalid,
		PaymentCancelled,
		PaymentInvalid,
		PaymentNotAllowed,
		ProductNotAvailable,
		// iOS 9.3
		CloudServicePermissionDenied,
		CloudServiceNetworkConnectionFailed,
		// iOS 10.3
		Revoked,
	}

	// typedef NSInteger SKDownloadState;
	// StoreKit.framework/Headers/SKDownload.h 
	[Native]
	public enum SKDownloadState : nint {
		Waiting, Active, Paused, Finished, Failed, Cancelled
	}

#if !MONOMAC || !XAMCORE_4_0
	[iOS (9,3)]
	[Native]
	public enum SKCloudServiceAuthorizationStatus : nint {
		NotDetermined,
		Denied,
		Restricted,
		Authorized
	}

	[iOS (9,3)]
	[Native]
	public enum SKCloudServiceCapability : nuint {
		None = 0,
		MusicCatalogPlayback = 1 << 0,
		[NoTV, iOS (10,1)]
		MusicCatalogSubscriptionEligible = 1 << 1,
		AddToCloudMusicLibrary = 1 << 8
	}
#endif
}
