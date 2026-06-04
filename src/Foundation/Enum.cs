//
// Enums.cs: enumeration definitions for Foundation
//
// Copyright 2009-2010, Novell, Inc.
// Copyright 2011, 2012 Xamarin Inc
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace Foundation {

	/// <summary>Encodings supported by NSString.Encode.</summary>
	/// <remarks>The encodings supported by NSData and NSString.</remarks>
	[Native]
	public enum NSStringEncoding : ulong {
		/// <summary>ASCII encoding contains, 7-bit of information stored in 8 bits.</summary>
		ASCIIStringEncoding = 1,
		/// <summary>N E X T S T E P.</summary>
		NEXTSTEP = 2,
		/// <summary>Japanese E U C.</summary>
		JapaneseEUC = 3,
		/// <summary>8-bit based variable-length character encoding for Unicode. </summary>
		UTF8 = 4,
		/// <summary>8-bit ISO/IEC 8859-1, also knows as Latin1 encoding.</summary>
		ISOLatin1 = 5,
		/// <summary>Symbol.</summary>
		Symbol = 6,
		/// <summary>Non Lossy A S C I I.</summary>
		NonLossyASCII = 7,
		/// <summary>Shift J I S.</summary>
		ShiftJIS = 8,
		/// <summary>8-bit ISO/IEC 8859-2, also knows as Latin2 encoding.</summary>
		ISOLatin2 = 9,
		/// <summary>Unicode.</summary>
		Unicode = 10,
		/// <summary>Windows C P1251.</summary>
		WindowsCP1251 = 11,
		/// <summary>Windows C P1252.</summary>
		WindowsCP1252 = 12,
		/// <summary>Windows C P1253.</summary>
		WindowsCP1253 = 13,
		/// <summary>Windows C P1254.</summary>
		WindowsCP1254 = 14,
		/// <summary>Windows C P1250.</summary>
		WindowsCP1250 = 15,
		/// <summary>I S O2022 J P.</summary>
		ISO2022JP = 21,
		/// <summary>Mac O S Roman.</summary>
		MacOSRoman = 30,
		/// <summary>16 bit-based variable length encoding, blocks are interpreted as big endian.</summary>
		UTF16BigEndian = 0x90000100,
		/// <summary>16 bit-based variable length encoding, blocks are interpreted as litle endian. </summary>
		UTF16LittleEndian = 0x94000100,
		/// <summary>32-bit unicode encoding.</summary>
		UTF32 = 0x8c000100,
		/// <summary>32 bit encoding, blocks are interpreted as big endian.</summary>
		UTF32BigEndian = 0x98000100,
		/// <summary>32 bit encoding, blocks are interpreted as little endian.</summary>
		UTF32LittleEndian = 0x9c000100,
	};

	/// <summary>An enumeration of options available to NSString search and comparison methods.</summary>
	[Native]
	public enum NSStringCompareOptions : ulong {
		/// <summary>Case Insensitive Search.</summary>
		CaseInsensitiveSearch = 1,
		/// <summary>Literal Search.</summary>
		LiteralSearch = 2,
		/// <summary>Backwards Search.</summary>
		BackwardsSearch = 4,
		/// <summary>Anchored Search.</summary>
		AnchoredSearch = 8,
		/// <summary>Numeric Search.</summary>
		NumericSearch = 64,
		/// <summary>Diacritic Insensitive Search.</summary>
		DiacriticInsensitiveSearch = 128,
		/// <summary>Width Insensitive Search.</summary>
		WidthInsensitiveSearch = 256,
		/// <summary>Forced Ordering Search.</summary>
		ForcedOrderingSearch = 512,
		/// <summary>Regular Expression Search.</summary>
		RegularExpressionSearch = 1024,
	}

	/// <summary>Determines how credentials are persisted.</summary>
	[Native]
	public enum NSUrlCredentialPersistence : ulong {
		/// <summary>Not persisted.</summary>
		None,
		/// <summary>Persisted for the session.</summary>
		ForSession,
		/// <summary>Permanently.</summary>
		Permanent,
		/// <summary>Synchronizable.</summary>
		Synchronizable,
	}

#if MONOMAC

	/// <summary>The bundle's architecture.</summary>
	[NoiOS]
	[NoTV]
	[NoMacCatalyst]
	public enum NSBundleExecutableArchitecture {
		/// <summary>x86</summary>
		I386 = 0x00000007,
		/// <summary>PPC</summary>
		PPC = 0x00000012,
		/// <summary>x86-64</summary>
		X86_64 = 0x01000007,
		/// <summary>PPC64</summary>
		PPC64 = 0x01000012,
		ARM64 = 0x0100000c,
	}
#endif

	/// <summary>Comparison result in the Foundation Framework.</summary>
	[Native]
	public enum NSComparisonResult : long {
		/// <summary>Ascending.</summary>
		Ascending = -1,
		/// <summary>Same.</summary>
		Same,
		/// <summary>Descending.</summary>
		Descending,
	}

	/// <summary>NSUrlRequest caching policy.</summary>
	[Native]
	public enum NSUrlRequestCachePolicy : ulong {
		/// <summary>Use Protocol Cache Policy.</summary>
		UseProtocolCachePolicy = 0,
		/// <summary>Reload Ignoring Local Cache Data.</summary>
		ReloadIgnoringLocalCacheData = 1,
		/// <summary>Reload Ignoring Local And Remote Cache Data.</summary>
		ReloadIgnoringLocalAndRemoteCacheData = 4, // Unimplemented
		/// <summary>Reload Ignoring Cache Data.</summary>
		ReloadIgnoringCacheData = ReloadIgnoringLocalCacheData,

		/// <summary>Return Cache Data Else Load.</summary>
		ReturnCacheDataElseLoad = 2,
		/// <summary>Return Cache Data Do Not Load.</summary>
		ReturnCacheDataDoNotLoad = 3,

		/// <summary>Reload Revalidating Cache Data.</summary>
		ReloadRevalidatingCacheData = 5, // Unimplemented
	}

	/// <summary>An enumeration of values representing valid caching strategies for use with NSUrls.</summary>
	[Native]
	public enum NSUrlCacheStoragePolicy : ulong {
		/// <summary>Allowed.</summary>
		Allowed,
		/// <summary>Allowed In Memory Only.</summary>
		AllowedInMemoryOnly,
		/// <summary>Not Allowed.</summary>
		NotAllowed,
	}

	/// <summary>The current status of an NSStream.</summary>
	[Native]
	public enum NSStreamStatus : ulong {
		/// <summary>The stream is not yet open.</summary>
		NotOpen = 0,
		/// <summary>The stream is in the opening state.</summary>
		Opening = 1,
		/// <summary>The stream has been opened.</summary>
		Open = 2,
		/// <summary>The stream is reading.</summary>
		Reading = 3,
		/// <summary>The stream is writing.</summary>
		Writing = 4,
		/// <summary>At the end.</summary>
		AtEnd = 5,
		/// <summary>The stream is closed.</summary>
		Closed = 6,
		/// <summary>Error</summary>
		Error = 7,
	}

	/// <summary>The format to use during serialization using NSKeyedArchiver.</summary>
	[Native]
	public enum NSPropertyListFormat : ulong {
		/// <summary>Store in the old OpenStep format.</summary>
		OpenStep = 1,
		/// <summary>Store in XML format.</summary>
		Xml = 100,
		/// <summary>Store in the binary file format.</summary>
		Binary = 200,
	}

	/// <summary>An enumeration of values specifying mutability options for property lists.</summary>
	[Native]
	public enum NSPropertyListMutabilityOptions : ulong {
		/// <summary>Immutable.</summary>
		Immutable = 0,
		/// <summary>Mutable Containers.</summary>
		MutableContainers = 1,
		/// <summary>Mutable Containers And Leaves.</summary>
		MutableContainersAndLeaves = 2,
	}

	// Should mirror NSPropertyListMutabilityOptions
	/// <summary>An enumeration of mutability options for use with property lists.</summary>
	[Native]
	public enum NSPropertyListWriteOptions : ulong {
		/// <summary>Immutable.</summary>
		Immutable = 0,
		/// <summary>Mutable Containers.</summary>
		MutableContainers = 1,
		/// <summary>Mutable Containers And Leaves.</summary>
		MutableContainersAndLeaves = 2,
	}

	// Should mirror NSPropertyListMutabilityOptions, but currently
	// not implemented (always use Immutable/0)
	/// <summary>Apple states that functionality related to this class is not implemented.</summary>
	[Native]
	public enum NSPropertyListReadOptions : ulong {
		/// <summary>Immutable.</summary>
		Immutable = 0,
		/// <summary>Mutable Containers.</summary>
		MutableContainers = 1,
		/// <summary>Mutable Containers And Leaves.</summary>
		MutableContainersAndLeaves = 2,
	}

	/// <summary>A flagging enumeration whose values specify options in calls to <see cref="Foundation.NSMachPort.FromMachPort(System.UInt32,Foundation.NSMachPortRights)" />.</summary>
	[Native]
	[Flags]
	public enum NSMachPortRights : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Send Right.</summary>
		SendRight = (1 << 0),
		/// <summary>Receive Right.</summary>
		ReceiveRight = (1 << 1),
	}

	/// <summary>Status codes for the NSNetService.</summary>
	[Native]
	public enum NSNetServicesStatus : long {
		/// <summary>Unknown Error.</summary>
		UnknownError = -72000,
		/// <summary>Collision Error.</summary>
		CollisionError = -72001,
		/// <summary>Not Found Error.</summary>
		NotFoundError = -72002,
		/// <summary>Activity In Progress.</summary>
		ActivityInProgress = -72003,
		/// <summary>Bad Argument Error.</summary>
		BadArgumentError = -72004,
		/// <summary>Cancelled Error.</summary>
		CancelledError = -72005,
		/// <summary>Invalid Error.</summary>
		InvalidError = -72006,
		/// <summary>Timeout Error.</summary>
		TimeoutError = -72007,
		MissingRequiredConfigurationError = -72008,
	}

	/// <summary>NSNetService options.</summary>
	[Flags]
	[Native]
	public enum NSNetServiceOptions : ulong {
		/// <summary>No Auto Rename.</summary>
		NoAutoRename = 1 << 0,
		/// <summary>Listen For Connections.</summary>
		ListenForConnections = 1 << 1,
	}

	/// <summary>An enumeration of values that specify different date-format styles.</summary>
	[Native]
	public enum NSDateFormatterStyle : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Short.</summary>
		Short,
		/// <summary>Medium.</summary>
		Medium,
		/// <summary>Long.</summary>
		Long,
		/// <summary>Full.</summary>
		Full,
	}

	/// <summary>An enumeration that can specify whether the <see cref="Foundation.NSDateFormatter" /> should behave as it did prior to OS x v10.4</summary>
	[Native]
	public enum NSDateFormatterBehavior : ulong {
		/// <summary>Default.</summary>
		Default = 0,
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		Mode_10_0 = 1000,
		/// <summary>Mode_10_4.</summary>
		Mode_10_4 = 1040,
	}

	/// <summary>An enumeration whose values specify valid strategies for accepting <see cref="Foundation.NSHttpCookie" />s.</summary>
	[Native]
	public enum NSHttpCookieAcceptPolicy : ulong {
		/// <summary>Always.</summary>
		Always,
		/// <summary>Never.</summary>
		Never,
		/// <summary>Only From Main Document Domain.</summary>
		OnlyFromMainDocumentDomain,
	}

	/// <summary>An enumeration whose values specify calendrical units (e.g., seconds, months, eras).</summary>
	[Flags]
	[Native]
	public enum NSCalendarUnit : ulong {
		/// <summary>Era.</summary>
		Era = 2,
		/// <summary>Year.</summary>
		Year = 4,
		/// <summary>Month.</summary>
		Month = 8,
		/// <summary>Day.</summary>
		Day = 16,
		/// <summary>Hour.</summary>
		Hour = 32,
		/// <summary>Minute.</summary>
		Minute = 64,
		/// <summary>Second.</summary>
		Second = 128,
		/// <summary>Developers should not use this deprecated field. </summary>
		[Deprecated (PlatformName.MacOSX, 10, 10)]
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		Week = 256,
		/// <summary>Weekday.</summary>
		Weekday = 512,
		/// <summary>Weekday Ordinal.</summary>
		WeekdayOrdinal = 1024,
		/// <summary>Quarter.</summary>
		Quarter = 2048,

		/// <summary>Week Of Month.</summary>
		WeekOfMonth = (1 << 12),
		/// <summary>Week Of Year.</summary>
		WeekOfYear = (1 << 13),
		/// <summary>Year For Weak Of Year.</summary>
		YearForWeakOfYear = (1 << 14),

		/// <summary>Nanosecond.</summary>
		Nanosecond = (1 << 15),
		DayOfYear = (1 << 16),

		/// <summary>Calendar.</summary>
		Calendar = (1 << 20),
		/// <summary>Time Zone.</summary>
		TimeZone = (1 << 21),

		[TV (26, 0), Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0)]
		IsLeapMonth = (1 << 30),

		[TV (26, 0), Mac (26, 0), iOS (26, 0), MacCatalyst (26, 0)]
		IsRepeatedDay = (1UL << 31),
	}

	/// <summary>Flags that determine how NSData loads files.</summary>
	/// <remarks>
	///       <para>
	/// 	By default NSData will loads the contents of the file in memory
	/// 	by allocating a block of memory and then reading the contents of
	/// 	the file into it.
	///       </para>
	///       <para>
	/// 	The Mapped and MappedAlways parameter instruct NSData to use
	/// 	the kernel's interface to map the file into the process
	/// 	address space.  This has a few advantages: instead of
	/// 	allocating read/write memory for the process, that becomes
	/// 	real memory usage, the mapped versions map the file into
	/// 	memory which means that the data is loaded on demand instead
	/// 	of being loaded upfront.  This also allows the kernel to
	/// 	discard the data loaded from memory when the system is running
	/// 	low on memory. 
	///       </para>
	///     </remarks>
	[Flags]
	[Native]
	public enum NSDataReadingOptions : ulong {
		/// <summary>Use the kernel's virtual memory map to load the file, if possible. If sucessful, this replaces read/write memory that can be very expensive with discardable memory that is backed by a file.</summary>
		Mapped = 1 << 0,
		/// <summary>Notify the kernel that it should not try to cache the contents of this file in its buffer cache.</summary>
		Uncached = 1 << 1,
		/// <summary>Force NSData to try to use the kernel's mapping support to load the file.   If sucessful, this replaces read/write memory that can be very expensive with discardable memory that is backed by a file.</summary>
		MappedAlways = 1 << 3,
	}

	/// <summary>An enumeration of options to be used when writing <see cref="Foundation.NSData" /> objects.</summary>
	[Flags]
	[Native]
	public enum NSDataWritingOptions : ulong {
		/// <summary>Atomic.</summary>
		Atomic = 1,

		/// <summary>Without Overwriting.</summary>
		WithoutOverwriting = 2,
		/// <summary>File Protection None.</summary>
		[MacCatalyst (13, 1)]
		FileProtectionNone = 0x10000000,
		/// <summary>File Protection Complete.</summary>
		[MacCatalyst (13, 1)]
		FileProtectionComplete = 0x20000000,
		/// <summary>File Protection Mask.</summary>
		[MacCatalyst (13, 1)]
		FileProtectionMask = 0xf0000000,
		/// <summary>File Protection Complete Unless Open.</summary>
		[MacCatalyst (13, 1)]
		FileProtectionCompleteUnlessOpen = 0x30000000,
		/// <summary>File Protection Complete Until First User Authentication.</summary>
		[MacCatalyst (13, 1)]
		FileProtectionCompleteUntilFirstUserAuthentication = 0x40000000,
		[iOS (17, 0), NoMac, MacCatalyst (17, 0), TV (17, 0)]
		FileProtectionCompleteWhenUserInactive = 0x50000000,
	}

	/// <param name="obj">The object.</param>
	/// <param name="stop">Set to true to stop enumeration.</param>
	/// <summary>A delegate that specifies the enumerator used by <see cref="Foundation.NSSet.Enumerate(Foundation.NSSetEnumerator)" />.</summary>
	public delegate void NSSetEnumerator (NSObject obj, ref bool stop);

	/// <summary>An enumeration of values that specify the priority of an operation, relative to others, in a <see cref="Foundation.NSOperationQueue" />.</summary>
	[Native]
	public enum NSOperationQueuePriority : long {
		/// <summary>Very Low.</summary>
		VeryLow = -8,
		/// <summary>Low.</summary>
		Low = -4,
		/// <summary>Normal.</summary>
		Normal = 0,
		/// <summary>High.</summary>
		High = 4,
		/// <summary>Very High.</summary>
		VeryHigh = 8,
	}

	/// <summary>An enumeration of ways in which <see cref="Foundation.NSNotification" />s can be coalesced.</summary>
	[Flags]
	[Native]
	public enum NSNotificationCoalescing : ulong {
		/// <summary>No Coalescing.</summary>
		NoCoalescing = 0,
		/// <summary>Coalescing On Name.</summary>
		CoalescingOnName = 1,
		/// <summary>Coalescing On Sender.</summary>
		CoalescingOnSender = 2,
	}

	/// <summary>An enumeration of values that specify when a notification shouldbe posted.</summary>
	[Native]
	public enum NSPostingStyle : ulong {
		/// <summary>Post When Idle.</summary>
		PostWhenIdle = 1,
		/// <summary>Post A S A P.</summary>
		PostASAP = 2,
		/// <summary>Now.</summary>
		Now = 3,
	}

	/// <summary>Flags controling the search in NSData's Find method.</summary>
	/// <remarks>
	///     </remarks>
	[Flags]
	[Native]
	public enum NSDataSearchOptions : ulong {
		/// <summary>Starts search from the end, instead of the start.</summary>
		SearchBackwards = 1,
		/// <summary>Limits the search to the start (or end if SearchBackwards is specified)</summary>
		SearchAnchored = 2,
	}

	/// <summary>An enumeration of valid types for a <see cref="Foundation.NSExpression" />.</summary>
	[Native]
	public enum NSExpressionType : ulong {
		/// <summary>Constant Value.</summary>
		ConstantValue = 0,
		/// <summary>Evaluated Object.</summary>
		EvaluatedObject,
		/// <summary>Variable.</summary>
		Variable,
		/// <summary>Key Path.</summary>
		KeyPath,
		/// <summary>Function.</summary>
		Function,
		/// <summary>Union Set.</summary>
		UnionSet,
		/// <summary>Intersect Set.</summary>
		IntersectSet,
		/// <summary>Minus Set.</summary>
		MinusSet,
		/// <summary>Subquery.</summary>
		Subquery = 13,
		/// <summary>N S Aggregate.</summary>
		NSAggregate,
		/// <summary>Any Key.</summary>
		AnyKey = 15,
		/// <summary>Block.</summary>
		Block = 19,
		/// <summary>Conditional.</summary>
		Conditional = 20,
	}

	/// <summary>Enumeration of various errors relating to Cocoa development.</summary>
	public enum NSCocoaError : int {
		/// <summary>None.</summary>
		None,

		/// <summary>File No Such File.</summary>
		FileNoSuchFile = 4,
		/// <summary>File Locking.</summary>
		FileLocking = 255,
		/// <summary>File Read Unknown.</summary>
		FileReadUnknown = 256,
		/// <summary>File Read No Permission.</summary>
		FileReadNoPermission = 257,
		/// <summary>File Read Invalid File Name.</summary>
		FileReadInvalidFileName = 258,
		/// <summary>File Read Corrupt File.</summary>
		FileReadCorruptFile = 259,
		/// <summary>File Read No Such File.</summary>
		FileReadNoSuchFile = 260,
		/// <summary>File Read Inapplicable String Encoding.</summary>
		FileReadInapplicableStringEncoding = 261,
		/// <summary>File Read Unsupported Scheme.</summary>
		FileReadUnsupportedScheme = 262,
		/// <summary>File Read Too Large.</summary>
		FileReadTooLarge = 263,
		/// <summary>File Read Unknown String Encoding.</summary>
		FileReadUnknownStringEncoding = 264,
		/// <summary>File Write Unknown.</summary>
		FileWriteUnknown = 512,
		/// <summary>File Write No Permission.</summary>
		FileWriteNoPermission = 513,
		/// <summary>File Write Invalid File Name.</summary>
		FileWriteInvalidFileName = 514,
		/// <summary>File Write File Exists.</summary>
		FileWriteFileExists = 516,
		/// <summary>File Write Inapplicable String Encoding.</summary>
		FileWriteInapplicableStringEncoding = 517,
		/// <summary>File Write Unsupported Scheme.</summary>
		FileWriteUnsupportedScheme = 518,
		/// <summary>File Write Out Of Space.</summary>
		FileWriteOutOfSpace = 640,
		/// <summary>File Write Volume Read Only.</summary>
		FileWriteVolumeReadOnly = 642,

#if MONOMAC
		/// <summary>File Manager Unmount Unknown Error.</summary>
		FileManagerUnmountUnknownError = 768,
		/// <summary>File Manager Unmount Busy Error.</summary>
		FileManagerUnmountBusyError = 769,
#endif

		/// <summary>Key Value Validation.</summary>
		KeyValueValidation = 1024,
		/// <summary>Formatting.</summary>
		Formatting = 2048,
		/// <summary>User Cancelled.</summary>
		UserCancelled = 3072,
		/// <summary>Feature Unsupported.</summary>
		FeatureUnsupported = 3328,
		/// <summary>Executable Not Loadable.</summary>
		ExecutableNotLoadable = 3584,
		/// <summary>Executable Architecture Mismatch.</summary>
		ExecutableArchitectureMismatch = 3585,
		/// <summary>Executable Runtime Mismatch.</summary>
		ExecutableRuntimeMismatch = 3586,
		/// <summary>Executable Load.</summary>
		ExecutableLoad = 3587,
		/// <summary>Executable Link.</summary>
		ExecutableLink = 3588,
		/// <summary>File Error Minimum.</summary>
		FileErrorMinimum = 0,
		/// <summary>File Error Maximum.</summary>
		FileErrorMaximum = 1023,
		/// <summary>Validation Error Minimum.</summary>
		ValidationErrorMinimum = 1024,
		/// <summary>Validation Error Maximum.</summary>
		ValidationErrorMaximum = 2047,
		/// <summary>Executable Error Minimum.</summary>
		ExecutableErrorMinimum = 3584,
		/// <summary>Executable Error Maximum.</summary>
		ExecutableErrorMaximum = 3839,
		/// <summary>Formatting Error Minimum.</summary>
		FormattingErrorMinimum = 2048,
		/// <summary>Formatting Error Maximum.</summary>
		FormattingErrorMaximum = 2559,

		/// <summary>Property List Read Corrupt.</summary>
		PropertyListReadCorrupt = 3840,
		/// <summary>Property List Read Unknown Version.</summary>
		PropertyListReadUnknownVersion = 3841,
		/// <summary>Property List Read Stream.</summary>
		PropertyListReadStream = 3842,
		/// <summary>Property List Write Stream.</summary>
		PropertyListWriteStream = 3851,
		/// <summary>Property List Write Invalid.</summary>
		PropertyListWriteInvalid = 3852,
		/// <summary>Property List Error Minimum.</summary>
		PropertyListErrorMinimum = 3840,
		/// <summary>Property List Error Maximum.</summary>
		PropertyListErrorMaximum = 4095,

		/// <summary>Xpc Connection Interrupted.</summary>
		XpcConnectionInterrupted = 4097,
		/// <summary>Xpc Connection Invalid.</summary>
		XpcConnectionInvalid = 4099,
		/// <summary>Xpc Connection Reply Invalid.</summary>
		XpcConnectionReplyInvalid = 4101,
		XpcConnectionCodeSigningRequirementFailure = 4102,
		/// <summary>Xpc Connection Error Minimum.</summary>
		XpcConnectionErrorMinimum = 4096,
		/// <summary>Xpc Connection Error Maximum.</summary>
		XpcConnectionErrorMaximum = 4224,

		/// <summary>Ubiquitous File Unavailable.</summary>
		UbiquitousFileUnavailable = 4353,
		/// <summary>Ubiquitous File Not Uploaded Due To Quota.</summary>
		UbiquitousFileNotUploadedDueToQuota = 4354,
		/// <summary>Ubiquitous File Ubiquity Server Not Available.</summary>
		UbiquitousFileUbiquityServerNotAvailable = 4355,
		/// <summary>Ubiquitous File Error Minimum.</summary>
		UbiquitousFileErrorMinimum = 4352,
		/// <summary>Ubiquitous File Error Maximum.</summary>
		UbiquitousFileErrorMaximum = 4607,

		/// <summary>User Activity Handoff Failed Error.</summary>
		UserActivityHandoffFailedError = 4608,
		/// <summary>User Activity Connection Unavailable Error.</summary>
		UserActivityConnectionUnavailableError = 4609,
		/// <summary>User Activity Remote Application Timed Out Error.</summary>
		UserActivityRemoteApplicationTimedOutError = 4610,
		/// <summary>User Activity Handoff User Info Too Large Error.</summary>
		UserActivityHandoffUserInfoTooLargeError = 4611,

		/// <summary>User Activity Error Minimum.</summary>
		UserActivityErrorMinimum = 4608,
		/// <summary>User Activity Error Maximum.</summary>
		UserActivityErrorMaximum = 4863,

		/// <summary>Coder Read Corrupt Error.</summary>
		CoderReadCorruptError = 4864,
		/// <summary>Coder Value Not Found Error.</summary>
		CoderValueNotFoundError = 4865,
		/// <summary>Coder Invalid Value Error.</summary>
		CoderInvalidValueError = 4866,
		/// <summary>Coder Error Minimum.</summary>
		CoderErrorMinimum = 4864,
		/// <summary>Coder Error Maximum.</summary>
		CoderErrorMaximum = 4991,

		/// <summary>Bundle Error Minimum.</summary>
		BundleErrorMinimum = 4992,
		/// <summary>Bundle Error Maximum.</summary>
		BundleErrorMaximum = 5119,

		/// <summary>Bundle On Demand Resource Out Of Space Error.</summary>
		BundleOnDemandResourceOutOfSpaceError = 4992,
		/// <summary>Bundle On Demand Resource Exceeded Maximum Size Error.</summary>
		BundleOnDemandResourceExceededMaximumSizeError = 4993,
		/// <summary>Bundle On Demand Resource Invalid Tag Error.</summary>
		BundleOnDemandResourceInvalidTagError = 4994,

		/// <summary>Cloud Sharing Network Failure Error.</summary>
		CloudSharingNetworkFailureError = 5120,
		/// <summary>Cloud Sharing Quota Exceeded Error.</summary>
		CloudSharingQuotaExceededError = 5121,
		/// <summary>Cloud Sharing Too Many Participants Error.</summary>
		CloudSharingTooManyParticipantsError = 5122,
		/// <summary>Cloud Sharing Conflict Error.</summary>
		CloudSharingConflictError = 5123,
		/// <summary>Cloud Sharing No Permission Error.</summary>
		CloudSharingNoPermissionError = 5124,
		/// <summary>Cloud Sharing Other Error.</summary>
		CloudSharingOtherError = 5375,
		/// <summary>Cloud Sharing Error Minimum.</summary>
		CloudSharingErrorMinimum = 5120,
		/// <summary>Cloud Sharing Error Maximum.</summary>
		CloudSharingErrorMaximum = 5375,

		CompressionFailedError = 5376,
		DecompressionFailedError = 5377,
		CompressionErrorMinimum = 5376,
		CompressionErrorMaximum = 5503,
	}

	// note: Make sure names are identical/consistent with CFNetworkErrors.*
	// they share the same values but there's more entries in CFNetworkErrors
	// so anything new probably already exists over there
	/// <summary>An enumeration of errors associated with creating or loading a <see cref="Foundation.NSUrl" />.</summary>
	public enum NSUrlError : int {
		/// <summary>Unknown.</summary>
		Unknown = -1,

		/// <summary>Background Session Requires Shared Container.</summary>
		BackgroundSessionRequiresSharedContainer = -995,
		/// <summary>Background Session In Use By Another Process.</summary>
		BackgroundSessionInUseByAnotherProcess = -996,
		/// <summary>Background Session Was Disconnected.</summary>
		BackgroundSessionWasDisconnected = -997,

		/// <summary>Cancelled.</summary>
		Cancelled = -999,
		/// <summary>Bad U R L.</summary>
		BadURL = -1000,
		/// <summary>Timed Out.</summary>
		TimedOut = -1001,
		/// <summary>Unsupported U R L.</summary>
		UnsupportedURL = -1002,
		/// <summary>Cannot Find Host.</summary>
		CannotFindHost = -1003,
		/// <summary>Cannot Connect To Host.</summary>
		CannotConnectToHost = -1004,
		/// <summary>Network Connection Lost.</summary>
		NetworkConnectionLost = -1005,
		/// <summary>D N S Lookup Failed.</summary>
		DNSLookupFailed = -1006,
		/// <summary>H T T P Too Many Redirects.</summary>
		HTTPTooManyRedirects = -1007,
		/// <summary>Resource Unavailable.</summary>
		ResourceUnavailable = -1008,
		/// <summary>Not Connected To Internet.</summary>
		NotConnectedToInternet = -1009,
		/// <summary>Redirect To Non Existent Location.</summary>
		RedirectToNonExistentLocation = -1010,
		/// <summary>Bad Server Response.</summary>
		BadServerResponse = -1011,
		/// <summary>User Cancelled Authentication.</summary>
		UserCancelledAuthentication = -1012,
		/// <summary>User Authentication Required.</summary>
		UserAuthenticationRequired = -1013,
		/// <summary>Zero Byte Resource.</summary>
		ZeroByteResource = -1014,
		/// <summary>Cannot Decode Raw Data.</summary>
		CannotDecodeRawData = -1015,
		/// <summary>Cannot Decode Content Data.</summary>
		CannotDecodeContentData = -1016,
		/// <summary>Cannot Parse Response.</summary>
		CannotParseResponse = -1017,
		/// <summary>International Roaming Off.</summary>
		InternationalRoamingOff = -1018,
		/// <summary>Call Is Active.</summary>
		CallIsActive = -1019,
		/// <summary>Data Not Allowed.</summary>
		DataNotAllowed = -1020,
		/// <summary>Request Body Stream Exhausted.</summary>
		RequestBodyStreamExhausted = -1021,
		/// <summary>App Transport Security Requires Secure Connection.</summary>
		AppTransportSecurityRequiresSecureConnection = -1022,

		/// <summary>File Does Not Exist.</summary>
		FileDoesNotExist = -1100,
		/// <summary>File Is Directory.</summary>
		FileIsDirectory = -1101,
		/// <summary>No Permissions To Read File.</summary>
		NoPermissionsToReadFile = -1102,
		/// <summary>Data Length Exceeds Maximum.</summary>
		DataLengthExceedsMaximum = -1103,
		/// <summary>File Outside Safe Area.</summary>
		FileOutsideSafeArea = -1104,

		/// <summary>Secure Connection Failed.</summary>
		SecureConnectionFailed = -1200,
		/// <summary>Server Certificate Has Bad Date.</summary>
		ServerCertificateHasBadDate = -1201,
		/// <summary>Server Certificate Untrusted.</summary>
		ServerCertificateUntrusted = -1202,
		/// <summary>Server Certificate Has Unknown Root.</summary>
		ServerCertificateHasUnknownRoot = -1203,
		/// <summary>Server Certificate Not Yet Valid.</summary>
		ServerCertificateNotYetValid = -1204,
		/// <summary>Client Certificate Rejected.</summary>
		ClientCertificateRejected = -1205,
		/// <summary>Client Certificate Required.</summary>
		ClientCertificateRequired = -1206,

		/// <summary>Cannot Load From Network.</summary>
		CannotLoadFromNetwork = -2000,

		// Download and file I/O errors
		/// <summary>Cannot Create File.</summary>
		CannotCreateFile = -3000,
		/// <summary>Cannot Open File.</summary>
		CannotOpenFile = -3001,
		/// <summary>Cannot Close File.</summary>
		CannotCloseFile = -3002,
		/// <summary>Cannot Write To File.</summary>
		CannotWriteToFile = -3003,
		/// <summary>Cannot Remove File.</summary>
		CannotRemoveFile = -3004,
		/// <summary>Cannot Move File.</summary>
		CannotMoveFile = -3005,
		/// <summary>Download Decoding Failed Mid Stream.</summary>
		DownloadDecodingFailedMidStream = -3006,
		/// <summary>Download Decoding Failed To Complete.</summary>
		DownloadDecodingFailedToComplete = -3007,
	}

	/// <summary>An enumeration of values specifying options to be used with the <see cref="Foundation.NSObject.AddObserver(Foundation.NSObject,System.String,Foundation.NSKeyValueObservingOptions,System.IntPtr)" /> method.</summary>
	/// <remarks>
	///       <para>
	///       </para>
	///     </remarks>
	[Flags]
	[Native]
	public enum NSKeyValueObservingOptions : ulong {
		None = 0,
		/// <summary>Request that new values be delivered to the observer.</summary>
		New = 1,
		/// <summary>Requests that old values be delivered to the observer.</summary>
		Old = 2,
		/// <summary>Requests that both old and new values be delivered to the observer.</summary>
		OldNew = 3,
		/// <summary>Use this to send a notification on first use, without waiting for an actual change to take place.</summary>
		Initial = 4,
		/// <summary>If set, notifications are sent before and after the change to the property is made.   Otherwise the notifications are only sent after the property has been set.</summary>
		Prior = 8,
	}

	/// <summary>An enumeration indicating the type of change occurring in the <see cref="Foundation.NSObject.WillChangeValue(System.String)" /> and <see cref="Foundation.NSObject.DidChangeValue(System.String)" /> methods.</summary>
	/// <remarks>
	///       <para />
	///     </remarks>
	[Native]
	public enum NSKeyValueChange : ulong {
		/// <summary>The change is reported for setting a value in AProperty.</summary>
		Setting = 1,
		/// <summary>The change being reported is an insertion into a collection.</summary>
		Insertion,
		/// <summary>The change being reported is a removal from a collection.</summary>
		Removal,
		/// <summary>The change being reported is a set of changes in a collection.</summary>
		Replacement,
	}

	/// <summary>An enumeration of values indicating the operation being performed on a mutable key-value store.</summary>
	[Native]
	public enum NSKeyValueSetMutationKind : ulong {
		/// <summary>Union Set.</summary>
		UnionSet = 1,
		/// <summary>Minus Set.</summary>
		MinusSet,
		/// <summary>Intersect Set.</summary>
		IntersectSet,
		/// <summary>Set Set.</summary>
		SetSet,
	}

	/// <summary>An enumeration of valid options for use when enumerating over Blocks.</summary>
	[Flags]
	[Native]
	public enum NSEnumerationOptions : ulong {
		/// <summary>Sort Concurrent.</summary>
		SortConcurrent = 1,
		/// <summary>Reverse.</summary>
		Reverse = 2,
	}

	/// <summary>An enumeration of values that may be sent to <see cref="Foundation.NSStreamDelegate.HandleEvent(Foundation.NSStream,Foundation.NSStreamEvent)" />.</summary>
	[Flags]
	[Native]
	public enum NSStreamEvent : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Open Completed.</summary>
		OpenCompleted = 1 << 0,
		/// <summary>Has Bytes Available.</summary>
		HasBytesAvailable = 1 << 1,
		/// <summary>Has Space Available.</summary>
		HasSpaceAvailable = 1 << 2,
		/// <summary>Error Occurred.</summary>
		ErrorOccurred = 1 << 3,
		/// <summary>End Encountered.</summary>
		EndEncountered = 1 << 4,
	}

	/// <summary>An enumeration whose values specify how a <see cref="Foundation.NSComparisonPredicate" /> should apply to an n-to-many relationship.</summary>
	[Native]
	public enum NSComparisonPredicateModifier : ulong {
		/// <summary>Direct.</summary>
		Direct,
		/// <summary>All.</summary>
		All,
		/// <summary>Any.</summary>
		Any,
	}

	/// <summary>An enumeration of values that specify comparison types for use with <see cref="Foundation.NSComparisonPredicate" />.</summary>
	[Native]
	public enum NSPredicateOperatorType : ulong {
		/// <summary>Less Than.</summary>
		LessThan,
		/// <summary>Less Than Or Equal To.</summary>
		LessThanOrEqualTo,
		/// <summary>Greater Than.</summary>
		GreaterThan,
		/// <summary>Greater Than Or Equal To.</summary>
		GreaterThanOrEqualTo,
		/// <summary>Equal To.</summary>
		EqualTo,
		/// <summary>Not Equal To.</summary>
		NotEqualTo,
		/// <summary>Matches.</summary>
		Matches,
		/// <summary>Like.</summary>
		Like,
		/// <summary>Begins With.</summary>
		BeginsWith,
		/// <summary>Ends With.</summary>
		EndsWith,
		/// <summary>In.</summary>
		In,
		/// <summary>Custom Selector.</summary>
		CustomSelector,
		/// <summary>Contains.</summary>
		Contains = 99,
		/// <summary>Between.</summary>
		Between,
	}

	/// <summary>An enumeration whose values specify the type of string comparison to be used in a <see cref="Foundation.NSComparisonPredicate" />.</summary>
	[Flags]
	[Native]
	public enum NSComparisonPredicateOptions : ulong {
		/// <summary>None.</summary>
		None = 0x00,
		/// <summary>Case Insensitive.</summary>
		CaseInsensitive = 1 << 0,
		/// <summary>Diacritic Insensitive.</summary>
		DiacriticInsensitive = 1 << 1,
		/// <summary>Normalized.</summary>
		Normalized = 1 << 2,
	}

	/// <summary>An enumeration whose values specify the Boolean logical operator to be applied to a <see cref="Foundation.NSCompoundPredicate" />.</summary>
	[Native]
	public enum NSCompoundPredicateType : ulong {
		/// <summary>Not.</summary>
		Not,
		/// <summary>And.</summary>
		And,
		/// <summary>Or.</summary>
		Or,
	}

	/// <summary>An enumeration of options for use when enumerating mounted volumes.</summary>
	[Flags]
	[Native]
	public enum NSVolumeEnumerationOptions : ulong {
		/// <summary>None.</summary>
		None = 0,
		// skip                  = 1 << 0,
		/// <summary>Skip Hidden Volumes.</summary>
		SkipHiddenVolumes = 1 << 1,
		/// <summary>Produce File Reference Urls.</summary>
		ProduceFileReferenceUrls = 1 << 2,
	}

	/// <summary>An enumeration of options for use with <see cref="Foundation.NSDirectoryEnumerator" />.</summary>
	[Flags]
	[Native]
	public enum NSDirectoryEnumerationOptions : ulong {
		None = 0,
		/// <summary>Skips Subdirectory Descendants.</summary>
		SkipsSubdirectoryDescendants = 1 << 0,
		/// <summary>Skips Package Descendants.</summary>
		SkipsPackageDescendants = 1 << 1,
		/// <summary>Skips Hidden Files.</summary>
		SkipsHiddenFiles = 1 << 2,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		IncludesDirectoriesPostOrder = 1 << 3,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		ProducesRelativePathUrls = 1 << 4,
	}

	/// <summary>An enumeration of options for use with <see cref="Foundation.NSFileManager.Replace(Foundation.NSUrl,Foundation.NSUrl,System.String,Foundation.NSFileManagerItemReplacementOptions,out Foundation.NSUrl,out Foundation.NSError)" />.</summary>
	[Flags]
	[Native]
	public enum NSFileManagerItemReplacementOptions : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Using New Metadata Only.</summary>
		UsingNewMetadataOnly = 1 << 0,
		/// <summary>Without Deleting Backup Item.</summary>
		WithoutDeletingBackupItem = 1 << 1,
	}

	/// <summary>An enumeration of special directories for use with <see cref="Foundation.NSFileManager.GetUrls" />.</summary>
	/// <remarks>Some of these constants when used can return more than one value (for example AllApplicationsDirectory).</remarks>
	[Native]
	public enum NSSearchPathDirectory : ulong {
		/// <summary>Applications directory (/Applications).</summary>
		ApplicationDirectory = 1,
		/// <summary>Demo applications directory</summary>
		DemoApplicationDirectory,
		/// <summary>Deprecated, used to be /Developer/Applications.</summary>
		DeveloperApplicationDirectory,
		/// <summary>Directory for admin applications (Application/Utilities)</summary>
		AdminApplicationDirectory,
		/// <summary>Library directory contains documentation, configuration files and support files (Library)</summary>
		LibraryDirectory,
		/// <summary>Deprecated, used to be /Developer</summary>
		DeveloperDirectory,
		/// <summary>User directory (for all users, not the currently logged in user, /Users, /Network/Users for example)</summary>
		UserDirectory,
		/// <summary>Documentation directory</summary>
		DocumentationDirectory,
		/// <summary>Document directory (this is where an application can store its documents)</summary>
		DocumentDirectory,
		/// <summary>Directory for CoreServices (System/Library/CoreServices)</summary>
		CoreServiceDirectory,
		/// <summary>User autosave directory (Library/Autosave Information)</summary>
		AutosavedInformationDirectory = 11,
		/// <summary>The user’s desktop directory.</summary>
		DesktopDirectory = 12,
		/// <summary>Cache directory (Library/Caches)</summary>
		CachesDirectory = 13,
		/// <summary>Application support directory (Library/Application Support)</summary>
		ApplicationSupportDirectory = 14,
		/// <summary>Downloads directory (only available when the domain specified includes the User value)</summary>
		DownloadsDirectory = 15,
		/// <summary>Input methods directory (Library/Input Methods)</summary>
		InputMethodsDirectory = 16,
		/// <summary>User’s movies directory (~/Movies)</summary>
		MoviesDirectory = 17,
		/// <summary>User’s music directory (~/Music)</summary>
		MusicDirectory = 18,
		/// <summary>User’s picture directory (~/Pictures)</summary>
		PicturesDirectory = 19,
		/// <summary>Printer descriptions directory, the directory that contains Postcript Printer Description files (Library/Printers/PPDS)</summary>
		PrinterDescriptionDirectory = 20,
		/// <summary>Shared public directory, when enabled (~/Public)</summary>
		SharedPublicDirectory = 21,
		/// <summary>Preference Panes directory, the directory that contains the *.prefPane bundles, (Library/PreferencePanes)</summary>
		PreferencePanesDirectory = 22,
		/// <summary>User scripts directory (Library/Application Scripts/app)</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		ApplicationScriptsDirectory = 23,
		/// <summary>Item replacement directory, used for implementing safe-save features.</summary>
		ItemReplacementDirectory = 99,
		/// <summary>Combined directories where applications can appear.</summary>
		AllApplicationsDirectory = 100,
		/// <summary>Combined directories where resources can be appear.</summary>
		AllLibrariesDirectory = 101,
		/// <summary>Trash directory</summary>
		[NoTV]
		[MacCatalyst (13, 1)]
		TrashDirectory = 102,
	}

	/// <summary>An enumeration of values specifying search path domain constants for use with <see cref="Foundation.NSSearchPathDirectory" />.</summary>
	/// <remarks>The domain is used to specify the kind of directory you want to get from the <see cref="Foundation.NSFileManager.GetUrls(Foundation.NSSearchPathDirectory,Foundation.NSSearchPathDomain)" /> method.</remarks>
	[Flags]
	[Native]
	public enum NSSearchPathDomain : ulong {
		/// <summary>Do not return anything.</summary>
		None = 0,
		/// <summary>Return user directories.</summary>
		User = 1 << 0,
		/// <summary>Return local directories.</summary>
		Local = 1 << 1,
		/// <summary>Return network directories.</summary>
		Network = 1 << 2,
		/// <summary>Return the system directories.</summary>
		System = 1 << 3,
		/// <summary>Return items for all domains.</summary>
		All = 0x0ffff,
	}

	/// <summary>An enumeration of values that specify rounding behaviors for <see cref="Foundation.NSDecimal" />s.</summary>
	[Native]
	public enum NSRoundingMode : ulong {
		/// <summary>Plain.</summary>
		Plain,
		/// <summary>Down.</summary>
		Down,
		/// <summary>Up.</summary>
		Up,
		/// <summary>Bankers.</summary>
		Bankers,
	}

	/// <summary>An enumeration whose values indicate a specific calculation error (e.g., underflow, division by zero, loss of precision).</summary>
	[Native]
	public enum NSCalculationError : ulong {
		/// <summary>None.</summary>
		None,
		/// <summary>Precision Loss.</summary>
		PrecisionLoss,
		/// <summary>Underflow.</summary>
		Underflow,
		/// <summary>Overflow.</summary>
		Overflow,
		/// <summary>Divide By Zero.</summary>
		DivideByZero,
	}

	/// <summary>An enumeration of options for use when drawing strings.</summary>
	[Flags]
	[Native]
	public enum NSStringDrawingOptions : ulong {
		/// <summary>Uses Line Fragment Origin.</summary>
		UsesLineFragmentOrigin = (1 << 0),
		/// <summary>Uses Font Leading.</summary>
		UsesFontLeading = (1 << 1),
		/// <summary>This value is OSX-specific (not available in iOS)</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		[Deprecated (PlatformName.MacOSX, 10, 11)]
		DisableScreenFontSubstitution = (1 << 2),
		/// <summary>Uses Device Metrics.</summary>
		UsesDeviceMetrics = (1 << 3),
		/// <summary>This value is OSX-specific (not available in iOS)</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		[Deprecated (PlatformName.MacOSX, 10, 11)]
		OneShot = (1 << 4),
		/// <summary>Truncates Last Visible Line.</summary>
		TruncatesLastVisibleLine = (1 << 5),

		[iOS (26, 0), TV (26, 0), MacCatalyst (26, 0), Mac (26, 0)]
		OptionsResolvesNaturalAlignmentWithBaseWritingDirection = (1L << 9),
	}

	/// <summary>An enumeration of formats that can be used with numbers.</summary>
	[Native]
	public enum NSNumberFormatterStyle : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Decimal.</summary>
		Decimal = 1,
		/// <summary>Currency.</summary>
		Currency = 2,
		/// <summary>Percent.</summary>
		Percent = 3,
		/// <summary>Scientific.</summary>
		Scientific = 4,
		/// <summary>Spell Out.</summary>
		SpellOut = 5,
		[MacCatalyst (13, 1)]
		OrdinalStyle = 6,
		[MacCatalyst (13, 1)]
		CurrencyIsoCodeStyle = 8,
		[MacCatalyst (13, 1)]
		CurrencyPluralStyle = 9,
		[MacCatalyst (13, 1)]
		CurrencyAccountingStyle = 10,
	}

	/// <summary>An enumeration whose values specify whether the number formatter should behave as it did before OS X v10.4</summary>
	[Native]
	public enum NSNumberFormatterBehavior : ulong {
		/// <summary>Default.</summary>
		Default = 0,
		/// <summary>Version_10_0.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		Version_10_0 = 1000,
		/// <summary>Version_10_4.</summary>
		Version_10_4 = 1040,
	}

	/// <summary>An enumeration whose values indicates where padding should be applied to numbers.</summary>
	[Native]
	public enum NSNumberFormatterPadPosition : ulong {
		/// <summary>Before Prefix.</summary>
		BeforePrefix,
		/// <summary>After Prefix.</summary>
		AfterPrefix,
		/// <summary>Before Suffix.</summary>
		BeforeSuffix,
		/// <summary>After Suffix.</summary>
		AfterSuffix,
	}

	/// <summary>An enumeration of rounding modes that can be applied to numbers.</summary>
	[Native]
	public enum NSNumberFormatterRoundingMode : ulong {
		/// <summary>Ceiling.</summary>
		Ceiling,
		/// <summary>Floor.</summary>
		Floor,
		/// <summary>Down.</summary>
		Down,
		/// <summary>Up.</summary>
		Up,
		/// <summary>Half Even.</summary>
		HalfEven,
		/// <summary>Half Down.</summary>
		HalfDown,
		/// <summary>Half Up.</summary>
		HalfUp,
	}

	/// <summary>Allows the application developer to specify that the old version of the file should be removed from the version store.</summary>
	[Flags]
	[Native]
	public enum NSFileVersionReplacingOptions : ulong {
		/// <summary>By Moving.</summary>
		ByMoving = 1 << 0,
	}

	/// <summary>Allows the application developer to specify that a new file version should be created by moving the source file.</summary>
	[Flags]
	[Native]
	public enum NSFileVersionAddingOptions : ulong {
		/// <summary>By Moving.</summary>
		ByMoving = 1 << 0,
	}

	/// <summary>An enumeration of options relating to reading the contents or attributes of a file or directory.</summary>
	[Flags]
	[Native]
	public enum NSFileCoordinatorReadingOptions : ulong {
		/// <summary>Without Changes.</summary>
		WithoutChanges = 1,
		/// <summary>Resolves Symbolic Link.</summary>
		ResolvesSymbolicLink = 1 << 1,
		/// <summary>Immediately Available Metadata Only.</summary>
		[MacCatalyst (13, 1)]
		ImmediatelyAvailableMetadataOnly = 1 << 2,
		/// <summary>For Uploading.</summary>
		[MacCatalyst (13, 1)]
		ForUploading = 1 << 3,
	}

	/// <summary>An enumeration of options valid when changing the contents or attributes of a file or directory.</summary>
	[Flags]
	[Native]
	public enum NSFileCoordinatorWritingOptions : ulong {
		/// <summary>For Deleting.</summary>
		ForDeleting = 1,
		/// <summary>For Moving.</summary>
		ForMoving = 2,
		/// <summary>For Merging.</summary>
		ForMerging = 4,
		/// <summary>For Replacing.</summary>
		ForReplacing = 8,
		[MacCatalyst (13, 1)]
		ContentIndependentMetadataOnly = 16,
	}

	/// <summary>An enumeration of options for use with <see cref="Foundation.NSLinguisticTagger" />.</summary>
	[Flags]
	[Native]
	public enum NSLinguisticTaggerOptions : ulong {
		/// <summary>Omit Words.</summary>
		OmitWords = 1,
		/// <summary>Omit Punctuation.</summary>
		OmitPunctuation = 2,
		/// <summary>Omit Whitespace.</summary>
		OmitWhitespace = 4,
		/// <summary>Omit Other.</summary>
		OmitOther = 8,
		/// <summary>Join Names.</summary>
		JoinNames = 16,
	}

	/// <summary>An enumeration of valid reasons for modifying the iCloud ubiquitous key store.</summary>
	[Native]
	public enum NSUbiquitousKeyValueStoreChangeReason : long {
		/// <summary>Server Change.</summary>
		ServerChange,
		/// <summary>Initial Sync Change.</summary>
		InitialSyncChange,
		/// <summary>Quota Violation Change.</summary>
		QuotaViolationChange,
		/// <summary>Account Change.</summary>
		AccountChange,
	}

	/// <summary>Options for use when converting JSON data to instances of Foundation types.</summary>
	[Flags]
	[Native]
	public enum NSJsonReadingOptions : ulong {
		/// <summary>Mutable Containers.</summary>
		MutableContainers = 1,
		/// <summary>Mutable Leaves.</summary>
		MutableLeaves = 2,
		FragmentsAllowed = 4,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		Json5Allowed = 8,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		TopLevelDictionaryAssumed = 16,
	}

	/// <summary>An enumeration specifying printing options (compact vs. pretty-printed) for JSON data.</summary>
	[Flags]
	[Native]
	public enum NSJsonWritingOptions : ulong {
		/// <summary>Pretty Printed.</summary>
		PrettyPrinted = 1,
		/// <summary>Sorted Keys.</summary>
		[MacCatalyst (13, 1)]
		SortedKeys = (1 << 1),
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		FragmentsAllowed = (1 << 2),
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		WithoutEscapingSlashes = (1 << 3),
	}

	/// <summary>An enumeration of values that specify the direction of text for a language.</summary>
	[Native]
	public enum NSLocaleLanguageDirection : ulong {
		/// <summary>Unknown.</summary>
		Unknown,
		/// <summary>Left To Right.</summary>
		LeftToRight,
		/// <summary>Right To Left.</summary>
		RightToLeft,
		/// <summary>Top To Bottom.</summary>
		TopToBottom,
		/// <summary>Bottom To Top.</summary>
		BottomToTop,
	}

	/// <summary>An enumeration of values used by alignment functions.</summary>
	[Flags]
	public enum NSAlignmentOptions : long {
		/// <summary>Min X Inward.</summary>
		MinXInward = 1 << 0,
		/// <summary>Min Y Inward.</summary>
		MinYInward = 1 << 1,
		/// <summary>Max X Inward.</summary>
		MaxXInward = 1 << 2,
		/// <summary>Max Y Inward.</summary>
		MaxYInward = 1 << 3,
		/// <summary>Width Inward.</summary>
		WidthInward = 1 << 4,
		/// <summary>Height Inward.</summary>
		HeightInward = 1 << 5,

		/// <summary>Min X Outward.</summary>
		MinXOutward = 1 << 8,
		/// <summary>Min Y Outward.</summary>
		MinYOutward = 1 << 9,
		/// <summary>Max X Outward.</summary>
		MaxXOutward = 1 << 10,
		/// <summary>Max Y Outward.</summary>
		MaxYOutward = 1 << 11,
		/// <summary>Width Outward.</summary>
		WidthOutward = 1 << 12,
		/// <summary>Height Outward.</summary>
		HeightOutward = 1 << 13,

		/// <summary>Min X Nearest.</summary>
		MinXNearest = 1 << 16,
		/// <summary>Min Y Nearest.</summary>
		MinYNearest = 1 << 17,
		/// <summary>Max X Nearest.</summary>
		MaxXNearest = 1 << 18,
		/// <summary>Max Y Nearest.</summary>
		MaxYNearest = 1 << 19,
		/// <summary>Width Nearest.</summary>
		WidthNearest = 1 << 20,
		/// <summary>Height Nearest.</summary>
		HeightNearest = 1 << 21,

		/// <summary>Rect Flipped.</summary>
		RectFlipped = unchecked((long) (1UL << 63)),

		/// <summary>All Edges Inward.</summary>
		AllEdgesInward = MinXInward | MaxXInward | MinYInward | MaxYInward,
		/// <summary>All Edges Outward.</summary>
		AllEdgesOutward = MinXOutward | MaxXOutward | MinYOutward | MaxYOutward,
		/// <summary>All Edges Nearest.</summary>
		AllEdgesNearest = MinXNearest | MaxXNearest | MinYNearest | MaxYNearest,
	}

	/// <summary>An enumeration of options to be used when reading a file-system node.</summary>
	[Flags]
	[Native]
	public enum NSFileWrapperReadingOptions : ulong {
		/// <summary>Immediate.</summary>
		Immediate = 1 << 0,
		/// <summary>Without Mapping.</summary>
		WithoutMapping = 1 << 1,
	}

	/// <summary>An enumeration of options to be used when writing a file-system node.</summary>
	[Flags]
	[Native]
	public enum NSFileWrapperWritingOptions : ulong {
		/// <summary>Atomic.</summary>
		Atomic = 1 << 0,
		/// <summary>With Name Updating.</summary>
		WithNameUpdating = 1 << 1,
	}

	/// <summary>An enumeration whose values specify the options to be used in the <see cref="Foundation.NSAttributedString.EnumerateAttribute(Foundation.NSString,Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedStringCallback)" /> and <see cref="Foundation.NSAttributedString.EnumerateAttributes(Foundation.NSRange,Foundation.NSAttributedStringEnumeration,Foundation.NSAttributedRangeCallback)" /> methods.</summary>
	[Flags]
	[Native ("NSAttributedStringEnumerationOptions")]
	public enum NSAttributedStringEnumeration : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Reverse.</summary>
		Reverse = 1 << 1,
		/// <summary>Longest Effective Range Not Required.</summary>
		LongestEffectiveRangeNotRequired = 1 << 20,
	}

	// macOS has defined this in AppKit as well, but starting with .NET we're going
	// to use this one only.
	/// <summary>An enumeration of valid styles for underlines or strikethroughs.</summary>
	[Native]
	public enum NSUnderlineStyle : long {
		/// <summary>None.</summary>
		None = 0x00,
		/// <summary>Single.</summary>
		Single = 0x01,
		/// <summary>Thick.</summary>
		Thick = 0x02,
		/// <summary>Double.</summary>
		Double = 0x09,
		/// <summary>Pattern Solid.</summary>
		PatternSolid = 0x0000,
		/// <summary>Pattern Dot.</summary>
		PatternDot = 0x0100,
		/// <summary>Pattern Dash.</summary>
		PatternDash = 0x0200,
		/// <summary>Pattern Dash Dot.</summary>
		PatternDashDot = 0x0300,
		/// <summary>Pattern Dash Dot Dot.</summary>
		PatternDashDotDot = 0x0400,
		/// <summary>By Word.</summary>
		ByWord = 0x8000,
	}

	// There's an AppKit.NSWritingDirection, which is deprecated.
	// There's also an UIKit.UITextWritingDirection, which is deprecated too.
	// This is the enum we should be using.
	// See https://github.com/dotnet/macios/issues/6573
	/// <summary>An enumeration of valid writing directions.</summary>
	[Native]
	public enum NSWritingDirection : long {
		/// <summary>Natural.</summary>
		Natural = -1,
		/// <summary>Left To Right.</summary>
		LeftToRight = 0,
		/// <summary>Right To Left.</summary>
		RightToLeft = 1,
	}

	/// <summary>An enumeration whose values specify the units to be displayed by a <see cref="Foundation.NSByteCountFormatter" />.</summary>
	[Flags]
	[Native]
	public enum NSByteCountFormatterUnits : ulong {
		/// <summary>Use Default.</summary>
		UseDefault = 0,
		/// <summary>Use Bytes.</summary>
		UseBytes = 1 << 0,
		/// <summary>Use K B.</summary>
		UseKB = 1 << 1,
		/// <summary>Use M B.</summary>
		UseMB = 1 << 2,
		/// <summary>Use G B.</summary>
		UseGB = 1 << 3,
		/// <summary>Use T B.</summary>
		UseTB = 1 << 4,
		/// <summary>Use P B.</summary>
		UsePB = 1 << 5,
		/// <summary>Use E B.</summary>
		UseEB = 1 << 6,
		/// <summary>Use Z B.</summary>
		UseZB = 1 << 7,
		/// <summary>Use Y B Or Higher.</summary>
		UseYBOrHigher = 0x0FF << 8,
		/// <summary>Use All.</summary>
		UseAll = 0x0FFFF,
	}

	/// <summary>An enumeration whose values specify how byte units are calculated (e.g., if "KB" indicates 1000 or 1024 bytes).</summary>
	[Native]
	public enum NSByteCountFormatterCountStyle : long {
		/// <summary>File.</summary>
		File,
		/// <summary>Memory.</summary>
		Memory,
		/// <summary>Decimal.</summary>
		Decimal,
		/// <summary>Binary.</summary>
		Binary,
	}

	/// <summary>An enumeration of options ot be used when creating a bookmark.</summary>
	[Flags]
	[Native]
	public enum NSUrlBookmarkCreationOptions : ulong {
		/// <summary>Prefer File I D Resolution.</summary>
		PreferFileIDResolution = 1 << 8,
		/// <summary>Minimal Bookmark.</summary>
		MinimalBookmark = 1 << 9,
		/// <summary>Suitable For Bookmark File.</summary>
		SuitableForBookmarkFile = 1 << 10,
		/// <summary>With Security Scope.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		WithSecurityScope = 1 << 11,
		/// <summary>Security Scope Allow Only Read Access.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		SecurityScopeAllowOnlyReadAccess = 1 << 12,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		CreationWithoutImplicitSecurityScope = 1 << 29,
	}

	/// <summary>An enumeration of options to be used when creating an NSUrl by resolving a bookmark.</summary>
	[Flags]
	[Native]
	public enum NSUrlBookmarkResolutionOptions : ulong {
		/// <summary>Without U I.</summary>
		WithoutUI = 1 << 8,
		/// <summary>Without Mounting.</summary>
		WithoutMounting = 1 << 9,
		/// <summary>With Security Scope.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		WithSecurityScope = 1 << 10,
		[iOS (15, 0), TV (15, 0), MacCatalyst (15, 0)]
		WithoutImplicitStartAccessing = 1 << 15,
	}

	/// <summary>An enumeration that defines the valid ligature types of an <see cref="Foundation.NSAttributedString" />.</summary>
	[Native]
	public enum NSLigatureType : long {
		/// <summary>None.</summary>
		None,
		/// <summary>Default.</summary>
		Default,
		/// <summary>All.</summary>
		All,
	}

	/// <summary>A flagging enumeration whose values specify options in calls to <see cref="NSCalendar.Components" /> and <see cref="Foundation.NSCalendar.DateByAddingComponents(Foundation.NSDateComponents,Foundation.NSDate,Foundation.NSCalendarOptions)" />.</summary>
	[Flags]
	[Native]
	public enum NSCalendarOptions : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Wrap Calendar Components.</summary>
		WrapCalendarComponents = 1 << 0,

		/// <summary>Match Strictly.</summary>
		[MacCatalyst (13, 1)]
		MatchStrictly = 1 << 1,
		/// <summary>Search Backwards.</summary>
		[MacCatalyst (13, 1)]
		SearchBackwards = 1 << 2,

		/// <summary>Match Previous Time Preserving Smaller Units.</summary>
		[MacCatalyst (13, 1)]
		MatchPreviousTimePreservingSmallerUnits = 1 << 8,
		/// <summary>Match Next Time Preserving Smaller Units.</summary>
		[MacCatalyst (13, 1)]
		MatchNextTimePreservingSmallerUnits = 1 << 9,
		/// <summary>Match Next Time.</summary>
		[MacCatalyst (13, 1)]
		MatchNextTime = 1 << 10,

		/// <summary>Match First.</summary>
		[MacCatalyst (13, 1)]
		MatchFirst = 1 << 12,
		/// <summary>Match Last.</summary>
		[MacCatalyst (13, 1)]
		MatchLast = 1 << 13,
	}

	/// <summary>Network service types for <see cref="Foundation.NSUrlRequest" />.</summary>
	/// <remarks>
	///     </remarks>
	[Native]
	public enum NSUrlRequestNetworkServiceType : ulong {
		/// <summary>Default traffic</summary>
		Default,
		/// <summary>Voice over IP traffic.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 15, message: "Use 'PushKit' framework instead.")]
		[Deprecated (PlatformName.iOS, 13, 0, message: "Use 'PushKit' framework instead.")]
		[Deprecated (PlatformName.TvOS, 13, 0, message: "Use 'PushKit' framework instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'PushKit' framework instead.")]
		VoIP,
		/// <summary>Video traffic.</summary>
		Video,
		/// <summary>Background traffic.</summary>
		Background,
		/// <summary>Voice traffic.</summary>
		Voice,
		/// <summary>Responsive Data.</summary>
		[MacCatalyst (13, 1)]
		ResponsiveData = 6,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		AVStreaming = 8,
		[TV (13, 0), iOS (13, 0)]
		[MacCatalyst (13, 1)]
		ResponsiveAV = 9,
		/// <summary>Call Signaling.</summary>
		[MacCatalyst (13, 1)]
		CallSignaling = 11,
	}

	/// <summary>A flagging enumeration that specifies sorting options in calls to <see cref="NSMutableOrderedSet.Sort" />.</summary>
	[Flags]
	[Native]
	public enum NSSortOptions : ulong {
		/// <summary>Concurrent.</summary>
		Concurrent = 1 << 0,
		/// <summary>Stable.</summary>
		Stable = 1 << 4,
	}

	/// <summary>A flagging enumeration that can be used with the <see cref="Foundation.NSData(Foundation.NSData,Foundation.NSDataBase64DecodingOptions)" /> constructor.</summary>
	[Flags]
	[Native]
	public enum NSDataBase64DecodingOptions : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Ignore Unknown Characters.</summary>
		IgnoreUnknownCharacters = 1,
	}

	/// <summary>A flagging enumeration that can be used to specify options for <see cref="Foundation.NSData.GetBase64EncodedData(Foundation.NSDataBase64EncodingOptions)" /> and <see cref="Foundation.NSData.GetBase64EncodedString(Foundation.NSDataBase64EncodingOptions)" />.</summary>
	[Flags]
	[Native]
	public enum NSDataBase64EncodingOptions : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Sixty Four Character Line Length.</summary>
		SixtyFourCharacterLineLength = 1,
		/// <summary>Seventy Six Character Line Length.</summary>
		SeventySixCharacterLineLength = 1 << 1,
		/// <summary>End Line With Carriage Return.</summary>
		EndLineWithCarriageReturn = 1 << 4,
		/// <summary>End Line With Line Feed.</summary>
		EndLineWithLineFeed = 1 << 5,
	}

	/// <summary>An enumeration whose values specify the state of an authorization challenge.</summary>
	/// <remarks>
	///       <para>Instances of this type are passed as an argument to the completion handler callback in <see cref="Foundation.NSUrlSessionDelegate.DidReceiveChallenge(Foundation.NSUrlSession,Foundation.NSUrlAuthenticationChallenge,System.Action{Foundation.NSUrlSessionAuthChallengeDisposition,Foundation.NSUrlCredential})" /> and its overrides.</para>
	///     </remarks>
	[Native]
	public enum NSUrlSessionAuthChallengeDisposition : long {
		/// <summary>Use Credential.</summary>
		UseCredential = 0,
		/// <summary>Perform Default Handling.</summary>
		PerformDefaultHandling = 1,
		/// <summary>Cancel Authentication Challenge.</summary>
		CancelAuthenticationChallenge = 2,
		/// <summary>Reject Protection Space.</summary>
		RejectProtectionSpace = 3,
	}

	/// <summary>An enumeration whose values specify the state of a <see cref="NSUrlSessionTask" />.</summary>
	[Native]
	public enum NSUrlSessionTaskState : long {
		/// <summary>Running.</summary>
		Running = 0,
		/// <summary>Suspended.</summary>
		Suspended = 1,
		/// <summary>Canceling.</summary>
		Canceling = 2,
		/// <summary>Completed.</summary>
		Completed = 3,
	}

	/// <summary>An enumeration whose values specify the state of a response.</summary>
	/// <remarks>An instance of this class is passed as an argument to the completion handler of the <see cref="Foundation.NSUrlSessionDataDelegate.DidReceiveResponse(Foundation.NSUrlSession,Foundation.NSUrlSessionDataTask,Foundation.NSUrlResponse,System.Action{Foundation.NSUrlSessionResponseDisposition})" /> method.</remarks>
	[Native]
	public enum NSUrlSessionResponseDisposition : long {
		/// <summary>Cancel.</summary>
		Cancel = 0,
		/// <summary>Allow.</summary>
		Allow = 1,
		/// <summary>Become Download.</summary>
		BecomeDownload = 2,
		/// <summary>Become Stream.</summary>
		BecomeStream = 3,
	}

	/// <summary>An enumeration whose values specify why a data transfer was cancelled.</summary>
	[Native]
	public enum NSUrlErrorCancelledReason : long {
		/// <summary>User Force Quit Application.</summary>
		UserForceQuitApplication,
		/// <summary>Background Updates Disabled.</summary>
		BackgroundUpdatesDisabled,
		/// <summary>Insufficient System Resources.</summary>
		InsufficientSystemResources,
	}

	/// <summary>A flagging enumeration whose values can be used with <see cref="Foundation.NSProcessInfo.BeginActivity(Foundation.NSActivityOptions,System.String)" />.</summary>
	[Flags]
	public enum NSActivityOptions : ulong {
		/// <summary>Idle Display Sleep Disabled.</summary>
		IdleDisplaySleepDisabled = 1UL << 40,
		/// <summary>Idle System Sleep Disabled.</summary>
		IdleSystemSleepDisabled = 1UL << 20,
		/// <summary>Sudden Termination Disabled.</summary>
		SuddenTerminationDisabled = 1UL << 14,
		/// <summary>Automatic Termination Disabled.</summary>
		AutomaticTerminationDisabled = 1UL << 15,
		AnimationTrackingEnabled = 1uL << 45,
		TrackingEnabled = 1uL << 46,
		UserInteractive = (UserInitiated | LatencyCritical),
		/// <summary>User Initiated.</summary>
		UserInitiated = 0x00FFFFFFUL | IdleSystemSleepDisabled,
		/// <summary>Background.</summary>
		Background = 0x000000ffUL,
		/// <summary>Latency Critical.</summary>
		LatencyCritical = 0xFF00000000UL,
		InitiatedAllowingIdleSystemSleep = UserInitiated & ~IdleSystemSleepDisabled,
	}

	/// <summary>Specifies styles for time-zone names.</summary>
	[Native]
	public enum NSTimeZoneNameStyle : long {
		/// <summary>Standard.</summary>
		Standard,
		/// <summary>Short Standard.</summary>
		ShortStandard,
		/// <summary>Daylight Saving.</summary>
		DaylightSaving,
		/// <summary>Short Daylight Saving.</summary>
		ShortDaylightSaving,
		/// <summary>Generic.</summary>
		Generic,
		/// <summary>Short Generic.</summary>
		ShortGeneric,
	}

	/// <summary>Enumerates errors relating to <see cref="Foundation.NSItemProvider" /> methods.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSItemProviderErrorCode : long {
		/// <summary>Unknown.</summary>
		Unknown = -1,
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Item Unavailable.</summary>
		ItemUnavailable = -1000,
		/// <summary>Unexpected Value Class.</summary>
		UnexpectedValueClass = -1100,
		/// <summary>Unavailable Coercion.</summary>
		UnavailableCoercion = -1200,
	}

	/// <summary>Enumerates <see cref="Foundation.NSDateComponentsFormatter" /> output styles.</summary>
	[Native]
	[MacCatalyst (13, 1)]
	public enum NSDateComponentsFormatterUnitsStyle : long {
		/// <summary>Positional.</summary>
		Positional = 0,
		/// <summary>Abbreviated.</summary>
		Abbreviated,
		/// <summary>Short.</summary>
		Short,
		/// <summary>Full.</summary>
		Full,
		/// <summary>Spell Out.</summary>
		SpellOut,
		/// <summary>Brief.</summary>
		[MacCatalyst (13, 1)]
		Brief,
	}

	/// <summary>Enumerates how zero values should be dealt with by a <see cref="Foundation.NSDateComponentsFormatter" />.</summary>
	[Flags]
	[Native]
	[MacCatalyst (13, 1)]
	public enum NSDateComponentsFormatterZeroFormattingBehavior : ulong {
		/// <summary>None.</summary>
		None = (0),
		/// <summary>Default.</summary>
		Default = (1 << 0),
		/// <summary>Drop Leading.</summary>
		DropLeading = (1 << 1),
		/// <summary>Drop Middle.</summary>
		DropMiddle = (1 << 2),
		/// <summary>Drop Trailing.</summary>
		DropTrailing = (1 << 3),
		/// <summary>Drop All.</summary>
		DropAll = (DropLeading | DropMiddle | DropTrailing),
		/// <summary>Pad.</summary>
		Pad = (1 << 16),
	}

	/// <summary>Enumerates the position of the data being formatted. Used with <see cref="Foundation.NSByteCountFormatter" /> and <see cref="Foundation.NSDateComponentsFormatter" />.</summary>
	[Native]
	[MacCatalyst (13, 1)]
	public enum NSFormattingContext : long {
		/// <summary>Unknown.</summary>
		Unknown = 0,
		/// <summary>Dynamic.</summary>
		Dynamic = 1,
		/// <summary>Standalone.</summary>
		Standalone = 2,
		/// <summary>List Item.</summary>
		ListItem = 3,
		/// <summary>Beginning Of Sentence.</summary>
		BeginningOfSentence = 4,
		/// <summary>Middle Of Sentence.</summary>
		MiddleOfSentence = 5,
	}

	/// <summary>Enumerates the output styles of a <see cref="Foundation.NSDateIntervalFormatter" />.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSDateIntervalFormatterStyle : ulong {
		/// <summary>None.</summary>
		None = 0,
		/// <summary>Short.</summary>
		Short = 1,
		/// <summary>Medium.</summary>
		Medium = 2,
		/// <summary>Long.</summary>
		Long = 3,
		/// <summary>Full.</summary>
		Full = 4,
	}

	/// <summary>The unit to be used by a <see cref="Foundation.NSEnergyFormatter" />.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSEnergyFormatterUnit : long {
		/// <summary>Joule.</summary>
		Joule = 11,
		/// <summary>Kilojoule.</summary>
		Kilojoule = 14,
		/// <summary>Calorie.</summary>
		Calorie = (7 << 8) + 1,
		/// <summary>Kilocalorie.</summary>
		Kilocalorie = (7 << 8) + 2,
	}

	/// <summary>Enumerates the style (desired length) of an <see cref="Foundation.NSLengthFormatter" />, <see cref="Foundation.NSEnergyFormatter" />, or <see cref="Foundation.NSMassFormatter" />.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSFormattingUnitStyle : long {
		/// <summary>Short.</summary>
		Short = 1,
		/// <summary>Medium.</summary>
		Medium,
		/// <summary>Long.</summary>
		Long,
	}

	/// <summary>Enumerates mass units (lb, kg, stone).</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSMassFormatterUnit : long {
		/// <summary>Gram.</summary>
		Gram = 11,
		/// <summary>Kilogram.</summary>
		Kilogram = 14,
		/// <summary>Ounce.</summary>
		Ounce = (6 << 8) + 1,
		/// <summary>Pound.</summary>
		Pound = (6 << 8) + 2,
		/// <summary>Stone.</summary>
		Stone = (6 << 8) + 3,
	}

	/// <summary>Enumerates units of length (foot, meter, etc.) for use with <see cref="Foundation.NSLengthFormatter" />.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSLengthFormatterUnit : long {
		/// <summary>Millimeter.</summary>
		Millimeter = 8,
		/// <summary>Centimeter.</summary>
		Centimeter = 9,
		/// <summary>Meter.</summary>
		Meter = 11,
		/// <summary>Kilometer.</summary>
		Kilometer = 14,
		/// <summary>Inch.</summary>
		Inch = (5 << 8) + 1,
		/// <summary>Foot.</summary>
		Foot = (5 << 8) + 2,
		/// <summary>Yard.</summary>
		Yard = (5 << 8) + 3,
		/// <summary>Mile.</summary>
		Mile = (5 << 8) + 4,
	}

	/// <summary>Enumerates QoS values for use with <see cref="Foundation.NSOperation" /> objects and <see cref="Foundation.NSOperationQueue" /> objects.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSQualityOfService : long {
		/// <summary>User Interactive.</summary>
		UserInteractive = 33,
		/// <summary>User Initiated.</summary>
		UserInitiated = 25,
		/// <summary>Utility.</summary>
		Utility = 17,
		/// <summary>Background.</summary>
		Background = 9,
		/// <summary>Default.</summary>
		Default = -1,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSProcessInfoThermalState : long {
		/// <summary>Nominal.</summary>
		Nominal,
		/// <summary>Fair.</summary>
		Fair,
		/// <summary>Serious.</summary>
		Serious,
		/// <summary>Critical.</summary>
		Critical,
	}

	/// <summary>Defines constants defining the relationship between a directory and an item.</summary>
	[Native]
	public enum NSUrlRelationship : long {
		/// <summary>Contains.</summary>
		Contains,
		/// <summary>Same.</summary>
		Same,
		/// <summary>Other.</summary>
		Other,
	}

	// NSTextCheckingResult.h:typedef NS_OPTIONS(uint64_t, NSTextCheckingType)
	/// <summary>Enumerates available predefined regular expressions for checking text.</summary>
	[Flags]
	public enum NSTextCheckingType : ulong {
		/// <summary>Orthography.</summary>
		Orthography = 1 << 0,
		/// <summary>Spelling.</summary>
		Spelling = 1 << 1,
		/// <summary>Grammar.</summary>
		Grammar = 1 << 2,
		/// <summary>Date.</summary>
		Date = 1 << 3,
		/// <summary>Address.</summary>
		Address = 1 << 4,
		/// <summary>Link.</summary>
		Link = 1 << 5,
		/// <summary>Quote.</summary>
		Quote = 1 << 6,
		/// <summary>Dash.</summary>
		Dash = 1 << 7,
		/// <summary>Replacement.</summary>
		Replacement = 1 << 8,
		/// <summary>Correction.</summary>
		Correction = 1 << 9,
		/// <summary>Regular Expression.</summary>
		RegularExpression = 1 << 10,
		/// <summary>Phone Number.</summary>
		PhoneNumber = 1 << 11,
		/// <summary>Transit Information.</summary>
		TransitInformation = 1 << 12,
	}

	// NSTextCheckingResult.h:typedef uint64_t NSTextCheckingTypes;
	/// <summary>Enumerates available predefined classes of regular expressions for checking text.</summary>
	public enum NSTextCheckingTypes : ulong {
		/// <summary>All System Types.</summary>
		AllSystemTypes = 0xffffffff,
		/// <summary>All Custom Types.</summary>
		AllCustomTypes = 0xffffffff00000000,
		/// <summary>All Types.</summary>
		AllTypes = 0xffffffffffffffff,
	}

	/// <summary>Defines options for use with <see cref="Foundation.NSRegularExpression" /> objects.</summary>
	[Native]
	[Flags]
	public enum NSRegularExpressionOptions : ulong {
		/// <summary>Case Insensitive.</summary>
		CaseInsensitive = 1 << 0,
		/// <summary>Allow Comments And Whitespace.</summary>
		AllowCommentsAndWhitespace = 1 << 1,
		/// <summary>Ignore Metacharacters.</summary>
		IgnoreMetacharacters = 1 << 2,
		/// <summary>Dot Matches Line Separators.</summary>
		DotMatchesLineSeparators = 1 << 3,
		/// <summary>Anchors Match Lines.</summary>
		AnchorsMatchLines = 1 << 4,
		UseUnixLineSeparators = 1 << 5,
		/// <summary>Use Unicode Word Boundaries.</summary>
		UseUnicodeWordBoundaries = 1 << 6,
	}

	/// <summary>Enumerates options for use with <see cref="Foundation.NSRegularExpression" /> regular expression objects.</summary>
	[Native]
	[Flags]
	public enum NSMatchingOptions : ulong {
		/// <summary>Report Progress.</summary>
		ReportProgress = 1 << 0,
		/// <summary>Report Completion.</summary>
		ReportCompletion = 1 << 1,
		/// <summary>Anchored.</summary>
		Anchored = 1 << 2,
		/// <summary>With Transparent Bounds.</summary>
		WithTransparentBounds = 1 << 3,
		/// <summary>Without Anchoring Bounds.</summary>
		WithoutAnchoringBounds = 1 << 4,
	}

	/// <summary>Enumerates flags for use with the <see cref="Foundation.NSMatchEnumerator" /> delegate.</summary>
	[Native]
	[Flags]
	public enum NSMatchingFlags : ulong {
		/// <summary>Progress.</summary>
		Progress = 1 << 0,
		/// <summary>Completed.</summary>
		Completed = 1 << 1,
		/// <summary>Hit End.</summary>
		HitEnd = 1 << 2,
		/// <summary>Required End.</summary>
		RequiredEnd = 1 << 3,
		/// <summary>Internal Error.</summary>
		InternalError = 1 << 4,
	}

	/// <summary>Contains a constant that, if specified, indicates that the phonetic representation of a name should be formatted, rather than the name object's own components.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum NSPersonNameComponentsFormatterOptions : ulong {
		/// <summary>Value that indicates that the phonetic representation of a name should be formatted, rather than the name object's own components.</summary>
		Phonetic = (1 << 1),
	}

	/// <summary>Enumerates values that control the way that names are displayed.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSPersonNameComponentsFormatterStyle : long {
		/// <summary>Display a medium-length representation of the name. Equivalent to <c>Medium</c>.</summary>
		Default = 0,
		/// <summary>Display a shortened form of the name by abbreviating or omitting various, user-specified, components.</summary>
		Short,
		/// <summary>Display a medium-length representation of the name. Equivalent to <c>Default</c>.</summary>
		Medium,
		/// <summary>Use all available name components, except for the nickname, to display the name.</summary>
		Long,
		/// <summary>Display the most abbreviated form of the name.</summary>
		Abbreviated,
	}

	/// <summary>Enumerates the manner in which a <see cref="Foundation.NSCoder" /> fails. (See <see cref="Foundation.NSCoder.DecodingFailurePolicy" />)</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSDecodingFailurePolicy : long {
		/// <summary>Raise Exception.</summary>
		RaiseException,
		/// <summary>Set Error And Return.</summary>
		SetErrorAndReturn,
	}

	/// <summary>A flagging enumeration of formatting options for use with <see cref="Foundation.NSIso8601DateFormatter" />.</summary>
	/// <remarks>
	///       <para>It is often easier to code a format by removing flags from <see cref="Foundation.NSIso8601DateFormatOptions.InternetDateTime" /> such as:</para>
	///       <example>
	///         <code lang="csharp lang-csharp"><![CDATA[
	/// fmt.FormatOptions = fmt.FormatOptions & ~NSIso8601DateFormatOptions.Day
	/// var s = fmt.StringFor(d); //"2016-08T23:15:36Z"          
	///           ]]></code>
	///       </example>
	///     </remarks>
	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum NSIso8601DateFormatOptions : ulong {
		/// <summary>Includes the year in the string.</summary>
		Year = 1 << 0,
		/// <summary>Includes the month in the string.</summary>
		Month = 1 << 1,
		/// <summary>Includes the week of the year in the string (e.g., "W33").</summary>
		WeekOfYear = 1 << 2,
		/// <summary>Includes the day in the string.</summary>
		Day = 1 << 4,
		/// <summary>Includes the time in the string.</summary>
		Time = 1 << 5,
		/// <summary>Includes the timezone in the string.</summary>
		TimeZone = 1 << 6,
		/// <summary>Puts a space between the date and the time.</summary>
		SpaceBetweenDateAndTime = 1 << 7,
		/// <summary>Separates date components with a dash.</summary>
		DashSeparatorInDate = 1 << 8,
		/// <summary>Puts a colon between time components</summary>
		ColonSeparatorInTime = 1 << 9,
		/// <summary>Puts a colon in the time.</summary>
		ColonSeparatorInTimeZone = 1 << 10,
		/// <summary>Fractional Seconds.</summary>
		[MacCatalyst (13, 1)]
		FractionalSeconds = 1 << 11,
		/// <summary>Includes the date in the string.</summary>
		FullDate = Year | Month | Day | DashSeparatorInDate,
		/// <summary>Includes the time in the string.</summary>
		FullTime = Time | ColonSeparatorInTime | TimeZone | ColonSeparatorInTimeZone,
		/// <summary>The standard ISO-8601 format (<c>yyyy-MM-ddTHH:mm:ssZ</c>).</summary>
		InternetDateTime = FullDate | FullTime,
	}

	/// <summary>Enumerates the way a network resource might be loaded.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSUrlSessionTaskMetricsResourceFetchType : long {
		/// <summary>The manner of the resource loading is not known.</summary>
		Unknown,
		/// <summary>The resource was retrieved via a network connection.</summary>
		NetworkLoad,
		/// <summary>The resource was pushed from a server.</summary>
		[Deprecated (PlatformName.iOS, 18, 4, message: "Not supported in iOS 17+.")] // message mentions one OS version and the actual deprecation OS version don't match, but that's what the headers do.
		[Deprecated (PlatformName.TvOS, 18, 4, message: "Not supported in tvOS 17+.")] // message mentions one OS version and the actual deprecation OS version don't match, but that's what the headers do.
		[Deprecated (PlatformName.MacCatalyst, 18, 4, message: "Not supported in Mac Catalyst 17+.")] // message mentions one OS version and the actual deprecation OS version don't match, but that's what the headers do.
		[Deprecated (PlatformName.MacOSX, 15, 4, message: "Not supported in macOS 14+.")] // message mentions one OS version and the actual deprecation OS version don't match, but that's what the headers do.
		ServerPush,
		/// <summary>The resource was retrieved from a local cache.</summary>
		LocalCache,
	}

	[MacCatalyst (13, 1)]
	[Native]
	[Flags]
	public enum NSMeasurementFormatterUnitOptions : ulong {
		/// <summary>Provided Unit.</summary>
		ProvidedUnit = (1 << 0),
		/// <summary>Natural Scale.</summary>
		NaturalScale = (1 << 1),
		/// <summary>Temperature Without Unit.</summary>
		TemperatureWithoutUnit = (1 << 2),
	}


	[MacCatalyst (13, 1)]
	[Native]
	public enum NSItemProviderRepresentationVisibility : long {
		/// <summary>All.</summary>
		All = 0,
		/// <summary>Team.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		Team = 1,
		/// <summary>Group.</summary>
		[NoiOS, NoTV]
		[NoMacCatalyst]
		Group = 2,
		/// <summary>Own Process.</summary>
		OwnProcess = 3,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSItemProviderFileOptions : long {
		/// <summary>Open In Place.</summary>
		OpenInPlace = 1,
	}

	/// <summary>Enumerate the linguistic units recognized by the <see cref="Foundation.NSLinguisticTagger" /> class.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum NSLinguisticTaggerUnit : long {
		/// <summary>Word.</summary>
		Word,
		/// <summary>Sentence.</summary>
		Sentence,
		/// <summary>Paragraph.</summary>
		Paragraph,
		/// <summary>Document.</summary>
		Document,
	}

	[MacCatalyst (13, 1)]
	[Native]
	public enum NSUrlSessionDelayedRequestDisposition : long {
		/// <summary>Continue Loading.</summary>
		ContinueLoading = 0,
		/// <summary>Use New Request.</summary>
		UseNewRequest = 1,
		/// <summary>Cancel.</summary>
		Cancel = 2,
	}

	[Native]
	public enum NSXpcConnectionOptions : ulong {
		Privileged = (1 << 12),
	}

	[MacCatalyst (13, 1)]
	public enum NSFileProtectionType {
		[Field ("NSFileProtectionComplete")]
		Complete,
		[Field ("NSFileProtectionCompleteUnlessOpen")]
		CompleteUnlessOpen,
		[Field ("NSFileProtectionCompleteUntilFirstUserAuthentication")]
		CompleteUntilFirstUserAuthentication,
		[Field ("NSFileProtectionNone")]
		None,
		[TV (17, 0), NoMac, iOS (17, 0), MacCatalyst (17, 0)]
		[Field ("NSFileProtectionCompleteWhenUserInactive")]
		CompleteWhenUserInactive,
	}
}
