using System;

using CoreFoundation;
using Darwin;
using Foundation;
using ObjCRuntime;

#if NET

namespace FSKit {
	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSClient
	{
		[Async]
		[Export ("installedExtensions:")]
		void GetInstalledExtensions (Action<FSModuleIdentity[], NSError> results);

		[Export ("installedExtensionsSync:")]
		void GetInstalledExtensionsSync (Action<FSModuleIdentity[], NSError> results);
	}

	[Mac (15, 0)]
	[Native]
	public enum FSContainerState : long
	{
		NotReady = 0,
		Blocked,
		Ready,
		Active,
	}

	[Mac (15, 0)]
	[BaseType (typeof (FSEntityIdentifier))]
	interface FSContainerIdentifier
	{
		[Export ("volumeIdentifier")]
		FSVolumeIdentifier VolumeIdentifier { get; }
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSEntityIdentifier : INSCopying, INSSecureCoding
	{
		[Export ("initWithUUID:")]
		NativeHandle Constructor (NSUuid uuid);

		[Export ("initWithUUID:data:")]
		NativeHandle Constructor (NSUuid uuid, NSData qualifier);

		// There's no documentation on what the 'bytes' pointer is, so wait with the binding for it.
		// [Export ("initWithUUID:byteQualifier:")]
		// NativeHandle Constructor (NSUuid uuid, IntPtr /* sbyte* */ bytes);

		// There's no documentation on what the 'bytes' pointer is, so wait with the binding for it.
		// [Export ("initWithUUID:longByteQualifier:")]
		// NativeHandle Constructor (NSUuid uuid, IntPtr /* sbyte* */ bytes);

		[Static]
		[Export ("identifier")]
		FSEntityIdentifier Create ();

		[Static]
		[Export ("identifierWithUUID:")]
		FSEntityIdentifier Create (NSUuid uuid);

		[Static]
		[Export ("identifierWithUUID:data:")]
		FSEntityIdentifier Create (NSUuid uuid, NSData qualifier);

		// There's no documentation on what the 'bytes' pointer is, so wait with the binding for it.
		// [Static]
		// [Export ("identifierWithUUID:byteQualifier:")]
		// FSEntityIdentifier CreateWithByteQualifier (NSUuid uuid, IntPtr /* sbyte* */ bytes);

		// There's no documentation on what the 'bytes' pointer is, so wait with the binding for it.
		// [Static]
		// [Export ("identifierWithUUID:longByteQualifier:")]
		// FSEntityIdentifier CreateWithLongByteQualifier (NSUuid uuid, IntPtr /* sbyte* */ bytes);

		[Export ("uuid", ArgumentSemantic.Retain)]
		NSUuid Uuid { get; set; }

		[NullAllowed, Export ("qual", ArgumentSemantic.Retain)]
		NSData Qual { get; set; }

		// This constructor is deprecated, so just skip binding it.
		// [Deprecated (PlatformName.MacOSX, 15, 0, message: "Use one of the other constructors or the Create methods instead.")]
		// [Export ("initWithBytes:length:")]
		// NativeHandle Constructor (IntPtr /* sbyte* */ buffer, int len);
	}

	[Mac (15, 0)]
	[Category]
	[BaseType (typeof (NSUuid))]
	interface NSUUID_FSEntityIdentifier
	{
		[Export ("fs_containerIdentifier")]
		FSContainerIdentifier GetFSContainerIdentifier ();

		[Export ("fs_entityIdentifier")]
		FSEntityIdentifier GetFSEntityIdentifier ();

		[Export ("fs_volumeIdentifier")]
		FSVolumeIdentifier GetFSVolumeIdentifier ();
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSFileDataBuffer : INSSecureCoding
	{
		[Export ("length")]
		nuint Length { get; set; }

		[Static]
		[Export ("dataWithLength:")]
		[return: NullAllowed]
		FSFileDataBuffer Create (nuint length);

		[Export ("initWithLength:")]
		NativeHandle Constructor (nuint length);

		[NullAllowed, Export ("bytes")]
		IntPtr Bytes { get; }
	}

	[Mac (15, 0)]
	[BaseType (typeof (FSFileDataBuffer))]
	interface FSMutableFileDataBuffer
	{
		[Static]
		[Export ("dataWithCapacity:")]
		[return: NullAllowed]
		FSMutableFileDataBuffer Create (nuint capacity);

		[Export ("initWithCapacity:")]
		NativeHandle Constructor (nuint capacity);

		[Export ("capacity")]
		nuint Capacity { get; }

		[NullAllowed, Export ("mutableBytes")]
		IntPtr MutableBytes { get; }
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface FSFileName : INSSecureCoding, INSCopying
	{
		[Export ("data")]
		NSData Data { get; }

		[NullAllowed, Export ("string")]
		string String { get; }

		// The C# binding for this ends up being the same as the the initWithCString: selector, which we've already bound.
		// [Export ("initWithCString:")]
		// [DesignatedInitializer]
		// [Internal]
		// NativeHandle Constructor (IntPtr name);

		[Export ("initWithBytes:length:")]
		[DesignatedInitializer]
		[Internal]
		NativeHandle InitWithBytes (IntPtr bytes, nuint length);

		[Export ("initWithData:")]
		NativeHandle Constructor (NSData name);

		[Export ("initWithString:")]
		NativeHandle Constructor (string name);

		// The C# binding for this ends up being the same as the the nameWithString: selector, which we've already bound.
		// [Static]
		// [Export ("nameWithCString:")]
		// [Internal]
		// FSFileName _Create (IntPtr name);

		[Static]
		[Export ("nameWithBytes:length:")]
		[Internal]
		FSFileName _Create (IntPtr bytes, nuint length);

		[Static]
		[Export ("nameWithData:")]
		FSFileName Create (NSData name);

		[Static]
		[Export ("nameWithString:")]
		FSFileName Create (string name);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSFileSystemBase
	{
		[Abstract]
		[NullAllowed, Export ("errorState", ArgumentSemantic.Strong)]
		NSError ErrorState { get; set; }

		[Abstract]
		[Export ("containerState", ArgumentSemantic.Assign)]
		FSContainerState ContainerState { get; set; }

		[Abstract]
		[Export ("wipeResource:includingRanges:excludingRanges:replyHandler:")]
		void WipeResource (FSBlockDeviceResource resource, NSIndexSet includingRanges, NSIndexSet excludingRanges, Action<NSError> reply);
	}

	[Mac (15, 0)]
	public enum FSItemType : byte
	{
		Unknown = 0,
		File,
		Dir,
		Symlink,
		Fifo,
		CharDev,
		BlockDev,
		Socket,
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSItemAttributes : INSSecureCoding
	{
		[Export ("reset")]
		void Reset ();

		[Export ("uid")]
		uint Uid { get; set; }

		[Export ("gid")]
		uint Gid { get; set; }

		[Export ("mode")]
		uint Mode { get; set; }

		[Export ("type", ArgumentSemantic.Assign)]
		FSItemType Type { get; set; }

		[Export ("numLinks")]
		uint NumLinks { get; set; }

		[Export ("bsdFlags")]
		uint BsdFlags { get; set; }

		[Export ("size")]
		ulong Size { get; set; }

		[Export ("allocSize")]
		ulong AllocSize { get; set; }

		[Export ("fileid")]
		ulong FileId { get; set; }

		[Export ("parentid")]
		ulong ParentId { get; set; }

		[Export ("useKOIO")]
		bool UseKoio { get; set; }

		[Export ("supportsLimitedXAttrs")]
		bool SupportsLimitedXAttrs { get; set; }

		[Export ("modifyTime:")]
		void ModifyTime (ref TimeSpec tp);

		[Export ("addedTime:")]
		void AddedTime (ref TimeSpec tp);

		[Export ("changeTime:")]
		void ChangeTime (ref TimeSpec tp);

		[Export ("accessTime:")]
		void AccessTime (ref TimeSpec tp);

		[Export ("birthTime:")]
		void BirthTime (ref TimeSpec tp);

		[Export ("backupTime:")]
		void BackupTime (ref TimeSpec tp);

		[Export ("uidIsActive")]
		bool UidIsActive { get; }

		[Export ("gidIsActive")]
		bool GidIsActive { get; }

		[Export ("modeIsActive")]
		bool ModeIsActive { get; }

		[Export ("typeIsActive")]
		bool TypeIsActive { get; }

		[Export ("numLinksIsActive")]
		bool NumLinksIsActive { get; }

		[Export ("bsdFlagsIsActive")]
		bool BsdFlagsIsActive { get; }

		[Export ("sizeIsActive")]
		bool SizeIsActive { get; }

		[Export ("allocSizeIsActive")]
		bool AllocSizeIsActive { get; }

		[Export ("fileidIsActive")]
		bool FileIdIsActive { get; }

		[Export ("parentidIsActive")]
		bool ParentIdIsActive { get; }

		[Export ("modifyTimeIsActive")]
		bool ModifyTimeIsActive { get; }

		[Export ("addedTimeIsActive")]
		bool AddedTimeIsActive { get; }

		[Export ("changeTimeIsActive")]
		bool ChangeTimeIsActive { get; }

		[Export ("accessTimeIsActive")]
		bool AccessTimeIsActive { get; }

		[Export ("birthTimeIsActive")]
		bool BirthTimeIsActive { get; }

		[Export ("backupTimeIsActive")]
		bool BackupTimeIsActive { get; }

		[Export ("setModifyTime:")]
		void SetModifyTime (ref TimeSpec tp);

		[Export ("setAddedTime:")]
		void SetAddedTime (ref TimeSpec tp);

		[Export ("setChangeTime:")]
		void SetChangeTime (ref TimeSpec tp);

		[Export ("setAccessTime:")]
		void SetAccessTime (ref TimeSpec tp);

		[Export ("setBirthTime:")]
		void SetBirthTime (ref TimeSpec tp);

		[Export ("setBackupTime:")]
		void SetBackupTime (ref TimeSpec tp);
	}

	[Mac (15, 0)]
	[BaseType (typeof (FSItemAttributes))]
	interface FSItemSetAttributesRequest
	{
		[Export ("uidWasConsumed")]
		bool UidWasConsumed { get; set; }

		[Export ("gidWasConsumed")]
		bool GidWasConsumed { get; set; }

		[Export ("typeWasConsumed")]
		bool TypeWasConsumed { get; set; }

		[Export ("modeWasConsumed")]
		bool ModeWasConsumed { get; set; }

		[Export ("numLinksWasConsumed")]
		bool NumLinksWasConsumed { get; set; }

		[Export ("bsdFlagsWasConsumed")]
		bool BsdFlagsWasConsumed { get; set; }

		[Export ("sizeWasConsumed")]
		bool SizeWasConsumed { get; set; }

		[Export ("allocSizeWasConsumed")]
		bool AllocSizeWasConsumed { get; set; }

		[Export ("fileidWasConsumed")]
		bool FileIdWasConsumed { get; set; }

		[Export ("parentidWasConsumed")]
		bool ParentIdWasConsumed { get; set; }

		[Export ("accessTimeWasConsumed")]
		bool AccessTimeWasConsumed { get; set; }

		[Export ("changeTimeWasConsumed")]
		bool ChangeTimeWasConsumed { get; set; }

		[Export ("modifyTimeWasConsumed")]
		bool ModifyTimeWasConsumed { get; set; }

		[Export ("addedTimeWasConsumed")]
		bool AddedTimeWasConsumed { get; set; }

		[Export ("birthTimeWasConsumed")]
		bool BirthTimeWasConsumed { get; set; }

		[Export ("backupTimeWasConsumed")]
		bool BackupTimeWasConsumed { get; set; }
	}

	[Mac (15, 0)]
	[BaseType (typeof(NSObject))]
	interface FSItemGetAttributesRequest : INSSecureCoding
	{
		[Export ("uidWanted")]
		bool UidWanted { get; set; }

		[Export ("gidWanted")]
		bool GidWanted { get; set; }

		[Export ("typeWanted")]
		bool TypeWanted { get; set; }

		[Export ("modeWanted")]
		bool ModeWanted { get; set; }

		[Export ("numLinksWanted")]
		bool NumLinksWanted { get; set; }

		[Export ("bsdFlagsWanted")]
		bool BsdFlagsWanted { get; set; }

		[Export ("sizeWanted")]
		bool SizeWanted { get; set; }

		[Export ("allocSizeWanted")]
		bool AllocSizeWanted { get; set; }

		[Export ("fileidWanted")]
		bool FileIdWanted { get; set; }

		[Export ("parentidWanted")]
		bool ParentIdWanted { get; set; }

		[Export ("accessTimeWanted")]
		bool AccessTimeWanted { get; set; }

		[Export ("changeTimeWanted")]
		bool ChangeTimeWanted { get; set; }

		[Export ("modifyTimeWanted")]
		bool ModifyTimeWanted { get; set; }

		[Export ("addedTimeWanted")]
		bool AddedTimeWanted { get; set; }

		[Export ("birthTimeWanted")]
		bool BirthTimeWanted { get; set; }

		[Export ("backupTimeWanted")]
		bool BackupTimeWanted { get; set; }
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSItem
	{
	}

	[Mac (15, 0)]
	[BaseType (typeof (FSItem))]
	interface FSUnaryItem
	{
		[Export ("queue", ArgumentSemantic.Retain)]
		DispatchQueue Queue { get; }
	}

	[Partial]
	interface FSKitConstants
	{
		[Field ("FSKitVersionNumber")]
		double FSKitVersionNumber { get; }

		[Field ("FSKitVersionString")]
		[Internal]
		IntPtr _FSKitVersionString { get; }

		[Static]
		string FSKitVersionString {
			[Wrap ("Marshal.PtrToStringUTF8 (_FSKitVersionString)!")]
			get;
		}
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSKitUtils
	{
		[Static]
		[Export ("stringWithFormatString:locale:arguments:")]
		string GetString (string localizedFormat, NSLocale locale, NSObject[] arguments);

		[Static]
		[Export ("stringWithFormatString:locale:arguments:")]
		NSString GetString (NSString localizedFormat, NSLocale locale, NSObject[] arguments);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSTaskMessageOps
	{
		[Abstract]
		[Export ("logMessage:")]
		void LogMessage (string str);

		[Abstract]
		[Export ("prompt:replyHandler:")]
		void Prompt (string prompt, Action<NSString, NSError> reply);

		[Abstract]
		[Export ("promptTrueFalse:replyHandler:")]
		void PromptTrueFalse (string prompt, Action<bool, NSError> reply);

		[Abstract]
		[Export ("completed:replyHandler:")]
		void Completed ([NullAllowed] NSError error, Action<int, NSError> reply);

		// Deprecated, so don't bind (the managed signature would also conflict with the other Completed signature)
		// [Export ("completed:reply:")]
		// void Completed ([NullAllowed] NSError error, Action<int, NSError> reply);
	}

	interface IFSTaskMessageOps {}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSMessageConnection : INSSecureCoding, FSTaskMessageOps
	{
		[Export ("locale")]
		NSLocale Locale { get; }

		[Async]
		[Export ("connect:")]
		void Connect (Action<NSError> reply);

		[Export ("logLocalizedMessage:table:bundle:array:")]
		void LogLocalizedMessage (string formatString, string tableName, NSBundle bundle, [Params] [NullAllowed] NSObject[] array);

		// Variadic arguments; this is complicated to bind and shouldn't be needed because there's an overload that takes an array.
		// [Export ("logLocalizedMessage:table:bundle:arguments:")]
		// void LogLocalizedMessage (string formatString, string tableName, NSBundle bundle, va_list[] argList);

		// Variadic arguments; this is complicated to bind and shouldn't be needed because there's an overload that takes an array.
		// [Internal]
		// [Export ("logLocalizedMessage:table:bundle:", IsVariadic = true)]
		// void LogLocalizedMessage (string formatString, string tableName, NSBundle bundle, IntPtr varArgs);

		[Internal]
		[Export ("localizedMessage:table:bundle:", IsVariadic = true)]
		NSString GetLocalizedMessage (NSString message, NSString tableName, NSBundle bundle, IntPtr varArgs);
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSModuleIdentity
	{
		[Export ("bundleIdentifier")]
		string BundleIdentifier { get; }

		[Export ("attributes")]
		NSDictionary<NSString, NSObject> Attributes { get; }

		[Export ("url")]
		NSUrl Url { get; }

		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; }

		[Export ("system")]
		bool IsSystem { [Bind ("isSystem")] get; }
	}

	[Mac (15, 0)]
	public enum FSMatchResult
	{
		NotRecognized = 0,
		Recognized,
		UsableButLimited,
		Usable,
	}

	[Mac (15, 0)]
	public enum FSResourceKind
	{
		Generic = 0,
		BlockDevice,
		PathUrl,
		ServerUrl,
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSResource : INSSecureCoding
	{
		[Export ("kind")]
		FSResourceKind Kind { get; }

		[Export ("revoked")]
		bool Revoked { get; [Bind ("revoke:")] set; }

		[Static]
		[Export ("dynamicCast:")]
		[return: NullAllowed]
		FSResource DynamicCast (NSObject candidate);
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSKitMetaBlockRange
	{
		[Export ("startBlockOffset")]
		long StartBlockOffset { get; }

		[Export ("blockLength")]
		uint BlockLength { get; }

		[Export ("numOfBlocks")]
		uint NumOfBlocks { get; }

		[Export ("initWithOffset:blockLength:numOfBlocks:")]
		NativeHandle Constructor (long startBlockOffset, uint blockLength, uint numOfBlocks);

		[Static]
		[Export ("rangeWithOffset:blockLength:numOfBlocks:")]
		FSKitMetaBlockRange Create (long startBlockOffset, uint blockLength, uint numOfBlocks);
	}

	[Mac (15, 0)]
	[BaseType (typeof (FSResource))]
	interface FSBlockDeviceResource
	{
		[Export ("initProxyForBSDName:")]
		NativeHandle Constructor (string bsdName);

		[Export ("initProxyForBSDName:writable:")]
		NativeHandle Constructor (string bsdName, bool isWritable);

		[Static]
		[Export ("proxyResourceForBSDName:")]
		[return: NullAllowed]
		FSBlockDeviceResource Create (string bsdName);

		[Static]
		[Export ("proxyResourceForBSDName:writable:")]
		[return: NullAllowed]
		FSBlockDeviceResource Create (string bsdName, bool writable);

		[Export ("bsdName", ArgumentSemantic.Strong)]
		string BsdName { get; }

		[Export ("writable")]
		bool Writable { get; }

		[Export ("blockSize")]
		nuint BlockSize { get; }

		[Export ("blockCount")]
		nuint BlockCount { get; }

		[Export ("physicalBlockSize")]
		nuint PhysicalBlockSize { get; }

		[Export ("terminated")]
		bool Terminated { get; [Bind ("terminate:")] set; }

		[Export ("readInto:startingAt:length:replyHandler:")]
		void Read (IntPtr buffer, long offset, nuint nbytes, Action<nuint, NSError> reply);

		[Export ("synchronousReadInto:startingAt:length:replyHandler:")]
		void SynchronousRead (IntPtr buffer, long offset, nuint nbytes, Action<nuint, NSError> reply);

		[Export ("writeFrom:startingAt:length:replyHandler:")]
		void Write (IntPtr buffer, long offset, nuint nbytes, Action<nuint, NSError> reply);

		[Export ("synchronousWriteFrom:startingAt:length:replyHandler:")]
		void SynchronousWrite (IntPtr buffer, long offset, nuint nbytes, Action<nuint, NSError> reply);

		[Export ("synchronousMetaReadInto:startingAt:length:replyHandler:")]
		void SynchronousMetaRead (IntPtr buffer, long offset, nuint length, Action<NSError> reply);

		[Export ("synchronousMetaReadInto:startingAt:length:readAheadExtents:readAheadCount:replyHandler:")]
		void SynchronousMetaRead (IntPtr buffer, long offset, nuint length, IntPtr readAheadExtents, int readAheadExtentsCount, Action<NSError> reply);

		[Export ("metaWriteFrom:startingAt:length:replyHandler:")]
		void MetaWrite (IntPtr buffer, long offset, nuint length, Action<NSError> reply);

		[Export ("synchronousMetaWriteFrom:startingAt:length:replyHandler:")]
		void SynchronousMetaWrite (IntPtr buffer, long offset, nuint length, Action<NSError> reply);

		[Export ("synchronousDelayedMetaWriteFrom:startingAt:length:replyHandler:")]
		void SynchronousDelayedMetaWrite (IntPtr buffer, long offset, nuint length, Action<NSError> reply);

		[Export ("synchronousMetaFlushWithReplyHandler:")]
		[Async]
		void SynchronousMetaFlush (Action<NSError> reply);

		[Export ("synchronousMetaClear:wait:replyHandler:")]
		void SynchronousMetaClear (FSKitMetaBlockRange[] rangesToClear, bool wait, Action<NSError> reply);

		[Export ("synchronousMetaPurge:replyHandler:")]
		void SynchronousMetaPurge (FSKitMetaBlockRange[] rangesToPurge, Action<NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSManageableResourceSimpleMaintenanceOps
	{
		[Export ("checkWithParameters:connection:taskID:replyHandler:")]
		void Check (string[] parameters, FSMessageConnection connection, NSUuid taskId, Action<NSProgress, NSError> reply);

		[Export ("formatWithParameters:connection:taskID:replyHandler:")]
		void Format (string[] parameters, FSMessageConnection connection, NSUuid taskId, Action<NSProgress, NSError> reply);
	}

	[Mac (15, 0)]
	[BaseType (typeof(FSResource), Name = "FSPathURLResource")]
	interface FSPathUrlResource
	{
		[Export ("url", ArgumentSemantic.Strong)]
		NSUrl Url { get; }

		[Static]
		[Export ("resourceWithURL:")]
		[return: NullAllowed]
		FSPathUrlResource Create (NSUrl url);
	}

	delegate void FSBlockDeviceOperationsProbeResult (FSMatchResult result, [NullAllowed] string name, [NullAllowed] FSContainerIdentifier containerId, [NullAllowed] NSError error);

	[Mac (15, 0)]
	[Protocol]
	interface FSBlockDeviceOperations
	{
		[Export ("probeResource:replyHandler:")]
		void ProbeResource (FSResource resource, FSBlockDeviceOperationsProbeResult reply);
	}

	[Mac (15, 0)]
	public enum FSTaskType : byte
	{
		Check = 0,
		Format,
		Activate,
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface FSTaskOption : INSSecureCoding
	{
		[Static]
		[Export ("optionWithoutValue:")]
		[return: NullAllowed]
		FSTaskOption CreateWithoutValue (string option);

		[Static]
		[Export ("option:value:")]
		[return: NullAllowed]
		FSTaskOption Create (string option, string value);

		[Export ("hasValue")]
		bool HasValue { get; }

		[Export ("option", ArgumentSemantic.Retain)]
		string Option { get; }

		[Export ("optionValue", ArgumentSemantic.Retain)]
		string OptionValue { get; }
	}

	delegate void FSTaskOptionsBundleCreateErrorHandler (NSError error, [NullAllowed] string option);
	delegate void FSTaskOptionsBundleEnumerator (int ch, [NullAllowed] string optarg, nuint idx, out bool stop);

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSTaskOptionsBundle : INSSecureCoding
	{
		[Static]
		[Export ("bundleForArguments:count:extension:operationType:errorHandler:")]
		[Internal]
		FSTaskOptionsBundle _Create (IntPtr argv, int argc, string extensionId, FSTaskType taskType, FSTaskOptionsBundleCreateErrorHandler errorHandler);

		[Static]
		[Export ("resetOptionEnumeration")]
		void ResetOptionEnumeration ();

		[Export ("addOption:")]
		void AddOption (FSTaskOption opt);

		[Export ("enumerateOptionsWithBlock:")]
		void Enumerate (FSTaskOptionsBundleEnumerator block);

		[Export ("options", ArgumentSemantic.Copy)]
		FSTaskOption[] Options { get; }

		[Export ("parameters", ArgumentSemantic.Copy)]
		string[] Parameters { get; }
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSUnaryFileSystem : FSFileSystemBase {
	}

	delegate void FSUnaryFileSystemOperationsLoadResourceResult ([NullAllowed] FSVolume volume, [NullAllowed] NSError error);

	[Mac (15, 0)]
	[Protocol]
	interface FSUnaryFileSystemOperations
	{
		[Export ("loadResource:options:replyHandler:")]
		void LoadResource (FSResource resource, FSTaskOptionsBundle options, FSUnaryFileSystemOperationsLoadResourceResult reply);

		[Export ("didFinishLoading")]
		void DidFinishLoading ();
	}

	[Mac (15, 0)]
	[BaseType (typeof (FSEntityIdentifier))]
	interface FSVolumeIdentifier {
	}

	[Mac (15, 0)]
	public enum FSVolumeState
	{
		NotReady = 0,
		Ready,
		Active,
	}

	delegate int FSDirEntryPacker (FSFileName name, FSItemType itemType, ulong itemId, ulong nextCookie, [NullAllowed] FSItemAttributes itemAttributes, bool isLast);

	[Mac (15, 0)]
	[Flags]
	public enum FSKitAccessMask : uint
	{
		ReadData = (1u << 1),
		ListDirectory = ReadData,
		WriteData = (1u << 2),
		AddFile = WriteData,
		Execute = (1u << 3),
		Search = Execute,
		Delete = (1u << 4),
		AppendData = (1u << 5),
		AddSubdirectory = AppendData,
		DeleteChild = (1u << 6),
		ReadAttributes = (1u << 7),
		WriteAttributes = (1u << 8),
		ReadExtAttributes = (1u << 9),
		WriteExtAttributes = (1u << 10),
		ReadSecurity = (1u << 11),
		WriteSecurity = (1u << 12),
		TakeOwnership = (1u << 13),
	}

	[Mac (15, 0)]
	[Flags]
	public enum FSKitXattrCreateRequirementAndFlags : uint
	{
		MustCreateXattr = 0x2,
		MustReplaceXattr = 0x4,
		AlwaysSetXattr = 0x6,
		DeleteXattr = 0x8,
	}

	[Mac (15, 0)]
	[Flags]
	public enum FSKitBlockmapFlags : uint
	{
		Read = 0x100,
		Write = 0x200,
		Async = 0x400,
		NoCache = 0x800,
		FileIssued = 0x1000,
	}

	[Mac (15, 0)]
	[Flags]
	public enum FSKitPreallocateFlags : uint
	{
		All = 0x2,
		Contig = 0x4,
		FromEOF = 0x10,
		FromVol = 0x20,
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSVolumeSupportedCapabilities : INSSecureCoding
	{
		[Export ("supportsPersistentObjectIDs")]
		bool SupportsPersistentObjectIds { get; set; }

		[Export ("supportsSymLinks")]
		bool SupportsSymLinks { get; set; }

		[Export ("supportsHardLinks")]
		bool SupportsHardLinks { get; set; }

		[Export ("supportsJournal")]
		bool SupportsJournal { get; set; }

		[Export ("supportsJournalActive")]
		bool SupportsJournalActive { get; set; }

		[Export ("supportsNoRootTimes")]
		bool SupportsNoRootTimes { get; set; }

		[Export ("supportsSparseFiles")]
		bool SupportsSparseFiles { get; set; }

		[Export ("supportsZeroRuns")]
		bool SupportsZeroRuns { get; set; }

		[Export ("supportsCaseSensitive")]
		bool SupportsCaseSensitive { get; set; }

		[Export ("supportsCasePreserving")]
		bool SupportsCasePreserving { get; set; }

		[Export ("supportsFastStatFS")]
		bool SupportsFastStatFS { get; set; }

		[Export ("supports2TBFiles")]
		bool Supports2TBFiles { get; set; }

		[Export ("supportsOpenDenyModes")]
		bool SupportsOpenDenyModes { get; set; }

		[Export ("supportsHiddenFiles")]
		bool SupportsHiddenFiles { get; set; }

		[Export ("supportsNoVolumeSizes")]
		bool SupportsNoVolumeSizes { get; set; }

		[Export ("supports64BitObjectIDs")]
		bool Supports64BitObjectIds { get; set; }

		[Export ("supportsDocumentID")]
		bool SupportsDocumentId { get; set; }

		[Export ("supportsNoImmutableFiles")]
		bool SupportsNoImmutableFiles { get; set; }

		[Export ("supportsNoSettingFilePermissions")]
		bool SupportsNoSettingFilePermissions { get; set; }

		[Export ("supportsSharedSpace")]
		bool SupportsSharedSpace { get; set; }

		[Export ("supportsVolumeGroups")]
		bool SupportsVolumeGroups { get; set; }
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSVolumeDescription : INSSecureCoding
	{
		[Export ("volumeID", ArgumentSemantic.Copy)]
		FSVolumeIdentifier VolumeId { get; }

		[Export ("volumeName")]
		string VolumeName { get; }

		[Export ("volumeState")]
		FSVolumeState VolumeState { get; }

		[Static]
		[Export ("volumeDescriptionWithID:name:state:")]
		FSVolumeDescription Create (FSVolumeIdentifier id, string name, FSVolumeState state);
	}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	interface FSVolume
	{
		[Export ("volumeID", ArgumentSemantic.Strong)]
		FSVolumeIdentifier VolumeId { get; set; }

		[Export ("volumeSupportedCapabilities")]
		FSVolumeSupportedCapabilities VolumeSupportedCapabilities { get; }

		[Export ("volumeName", ArgumentSemantic.Strong)]
		string VolumeName { get; set; }

		[Export ("volumeState", ArgumentSemantic.Assign)]
		FSVolumeState VolumeState { get; set; }

		[Export ("wasTerminated")]
		bool WasTerminated { get; set; }

		[Static]
		[Export ("pathConfUnlimited")]
		int PathConfUnlimited { get; }

		[NullAllowed, Export ("globalWorkQueue", ArgumentSemantic.Retain)]
		DispatchQueue GlobalWorkQueue { get; set; }

		[Export ("renameWorkQueue", ArgumentSemantic.Retain)]
		DispatchQueue RenameWorkQueue { get; set; }
	}

	[Mac (15, 0)]
	[Flags]
	public enum FSRenameItemOptions : ulong
	{
		FSRenameItemOptionReserved = 0x1,
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumePathConfOperations
	{
		[Abstract]
		[Export ("PC_LINK_MAX")]
		int PcLinkMax { get; }

		[Abstract]
		[Export ("PC_NAME_MAX")]
		int PcNameMax { get; }

		[Abstract]
		[Export ("PC_CHOWN_RESTRICTED")]
		int PcChownRestricted { get; }

		[Abstract]
		[Export ("PC_NO_TRUNC")]
		int PcNoTrunc { get; }

		[Abstract]
		[Export ("PC_CASE_SENSITIVE")]
		int PcCaseSensitive { get; }

		[Abstract]
		[Export ("PC_CASE_PRESERVING")]
		int PcCasePreserving { get; }

		[Abstract]
		[Export ("PC_XATTR_SIZE_BITS")]
		int PxXattrSizeBits { get; }

		[Abstract]
		[Export ("PC_FILESIZEBITS")]
		int PcFileSizeBits { get; }
	}

	interface IFSVolumePathConfOperations {}

	[Mac (15, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface FSKitStatfsResult : INSSecureCoding
	{
		[Export ("blockSize")]
		ulong BlockSize { get; }

		[Export ("ioSize")]
		ulong IoSize { get; }

		[Export ("totalBlocks")]
		ulong TotalBlocks { get; }

		[Export ("availableBlocks")]
		ulong AvailableBlocks { get; }

		[Export ("freeBlocks")]
		ulong FreeBlocks { get; }

		[Export ("totalBytes")]
		ulong TotalBytes { get; }

		[Export ("availableBytes")]
		ulong AvailableBytes { get; }

		[Export ("freeBytes")]
		ulong FreeBytes { get; }

		[Export ("totalFiles")]
		ulong TotalFiles { get; }

		[Export ("freeFiles")]
		ulong FreeFiles { get; }

		[Export ("fsSubType")]
		uint FsSubType { get; }

		[Export ("fsTypeName")]
		string FsTypeName { get; }

		[Static]
		[Export ("statFSWithBlockSize:ioSize:totalBlocks:availableBlocks:freeBlocks:totalFiles:freeFiles:fsSubType:fsTypeName:")]
		FSKitStatfsResult Create (ulong blockSize, ulong ioSize, ulong totalBlocks, ulong availableBlocks, ulong freeBlocks, ulong totalFiles, ulong freeFiles, uint fsSubType, string fsTypeName);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeOperations : FSVolumePathConfOperations
	{
		[Abstract]
		[Export ("volumeStatistics")]
		FSKitStatfsResult VolumeStatistics { get; }

		[Abstract]
		[Export ("setNewState:forced:replyHandler:")]
		void SetNewState (FSVolumeState wantedState, bool forced, Action<FSVolumeState, NSError> reply);

		[Abstract]
		[Export ("mount:replyHandler:")]
		void Mount (FSTaskOptionsBundle options, Action<FSItem, NSError> reply);

		[Abstract]
		[Export ("unmount:")]
		void Unmount (Action reply);

		[Abstract]
		[Export ("synchronize:")]
		void Synchronize (Action<NSError> reply);

		[Abstract]
		[Export ("getItemAttributes:requestedAttributes:replyHandler:")]
		void GetItemAttributes (FSItem item, FSItemGetAttributesRequest desired, Action<FSItemAttributes, NSError> reply);

		[Abstract]
		[Export ("setItemAttributes:requestedAttributes:replyHandler:")]
		void SetItemAttributes (FSItem item, FSItemSetAttributesRequest newAttributes, Action<FSItemAttributes, NSError> reply);

		[Abstract]
		[Export ("lookupName:inDirectory:replyHandler:")]
		void LookupName (FSFileName name, FSItem directory, Action<FSItem, NSError> reply);

		[Abstract]
		[Export ("reclaim:replyHandler:")]
		void Reclaim (FSItem item, Action<NSError> reply);

		[Abstract]
		[Export ("readSymbolicLink:replyHandler:")]
		void ReadSymbolicLink (FSItem item, Action<FSFileName, NSError> reply);

		[Abstract]
		[Export ("createItemNamed:type:inDirectory:attributes:replyHandler:")]
		void CreateItem (FSFileName name, FSItemType type, FSItem directory, FSItemSetAttributesRequest newAttributes, Action<FSItem, NSError> reply);

		[Abstract]
		[Export ("createSymbolicLinkNamed:inDirectory:attributes:linkContents:replyHandler:")]
		void CreateSymbolicLink (FSFileName name, FSItem directory, FSItemSetAttributesRequest newAttributes, NSData contents, Action<FSItem, NSError> reply);

		[Abstract]
		[Export ("createLinkof:named:inDirectory:replyHandler:")]
		void CreateLink (FSItem item, FSFileName name, FSItem directory, Action<NSError> reply);

		[Abstract]
		[Export ("removeItem:named:fromDirectory:replyHandler:")]
		void RemoveItem (FSItem item, FSFileName name, FSItem directory, Action<NSError> reply);

		[Abstract]
		[Export ("renameItem:inDirectory:named:toDirectory:newName:overItem:withOptions:replyHandler:")]
		void RenameItem (FSItem item, FSItem sourceDirectory, FSFileName sourceName, FSItem destinationDirectory, FSFileName destinationName, [NullAllowed] FSItem overItem, FSRenameItemOptions options, Action<NSError> reply);

		[Abstract]
		[Export ("enumerateDirectory:startingAtCookie:verifier:provideAttributes:attributes:usingBlock:replyHandler:")]
		void EnumerateDirectory (FSItem directory, ulong cookie, ulong verifier, bool provideAttributes, [NullAllowed] FSItemGetAttributesRequest attributes, FSDirEntryPacker packer, Action<ulong, NSError> reply);

		[Abstract]
		[Export ("activate:replyHandler:")]
		void Activate (FSTaskOptionsBundle options, Action<FSItem, NSError> reply);

		[Abstract]
		[Export ("deactivate:replyHandler:")]
		void Deactivate (nuint options, Action<NSError> reply);

		[Export ("otherAttributeNamed:of:replyHandler:")]
		void GetOtherAttribute (FSFileName name, FSItem item, Action<NSData, NSError> reply);

		[Export ("setOtherAttributeNamed:of:with:replyHandler:")]
		void SetOtherAttribute (FSFileName name, FSItem item, [NullAllowed] NSData newData, Action<NSData, NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeXattrOperations
	{
		[Export ("xattrOperationsInhibited")]
		bool XattrOperationsInhibited { get; set; }

		[Abstract]
		[Export ("xattrOf:named:replyHandler:")]
		void GetXattr (FSItem item, FSFileName name, Action<NSData, NSError> reply);

		[Abstract]
		[Export ("setXattrOf:named:value:how:replyHandler:")]
		void SetXattr (FSItem item, FSFileName name, [NullAllowed] NSData value, FSKitXattrCreateRequirementAndFlags how, Action<NSError> reply);

		[Abstract]
		[Export ("listXattrsOf:replyHandler:")]
		void ListXattrs (FSItem item, Action<NSArray<NSString>, NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeLimitedXattrOperations
	{
		[Export ("limitedXattrOperationsInhibited")]
		bool LimitedXattrOperationsInhibited { get; set; }

		[Abstract]
		[Export ("supportedXattrNamesOf:")]
		string[] GetSupportedXattrNames (FSItem item);

		[Abstract]
		[Export ("xattrOf:named:replyHandler:")]
		void GetXattr (FSItem item, FSFileName name, Action<NSData, NSError> reply);

		[Abstract]
		[Export ("setXattrOf:named:value:how:replyHandler:")]
		void SetXattr (FSItem item, FSFileName name, [NullAllowed] NSData value, FSKitXattrCreateRequirementAndFlags how, Action<NSError> reply);

		[Abstract]
		[Export ("listXattrsOf:replyHandler:")]
		void ListXattrs (FSItem item, Action<string[], NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeOpenCloseOperations
	{
		[Abstract]
		[Export ("openItem:withMode:replyHandler:")]
		void OpenItem (FSItem item, int mode, Action<NSError> reply);

		[Abstract]
		[Export ("closeItem:keepingMode:replyHandler:")]
		void CloseItem (FSItem item, int mode, Action<NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeReadWriteOperations
	{
		[Abstract]
		[Export ("readFromFile:offset:length:buffer:replyHandler:")]
		void ReadFromFile (FSItem item, ulong offset, nuint length, FSMutableFileDataBuffer buffer, Action<nuint, NSError> reply);

		[Abstract]
		[Export ("writeToFile:offset:buffer:replyHandler:")]
		void WriteToFile (FSItem item, ulong offset, NSData buffer, Action<nuint, NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeAccessCheckOperations
	{
		[Abstract]
		[Export ("checkAccessTo:requestedAccess:replyHandler:")]
		void CheckAccess (FSItem theItem, FSKitAccessMask access, Action<int, NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeCloneOperations
	{
		[Abstract]
		[Export ("makeCloneOf:inDirectory:named:attributes:usingFlags:replyHandler:")]
		void MakeClone (FSItem sourceFile, FSItem inDirectory, FSFileName name, FSItemSetAttributesRequest attrs, uint flags, Action<FSItem, NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeRenameOperations
	{
		[Abstract]
		[Export ("renameOperationsInhibited")]
		bool RenameOperationsInhibited { get; set; }

		[Abstract]
		[Export ("renameVolume:replyHandler:")]
		void RenameVolume (FSFileName name, Action<FSFileName, NSError> reply);
	}

	[Mac (15, 0)]
	public enum FSExtentType
	{
		Data = 0,
		Zero = 1,
	}

	delegate int FSExtentPacker (FSBlockDeviceResource resource, FSExtentType type, ulong logOffset, ulong phyOffset, uint length);

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumeKernelOffloadedIOOperations
	{
		[Abstract]
		[Export ("blockmapFile:range:startIO:flags:operationID:usingPacker:replyHandler:")]
		void BlockmapFile (FSItem item, NSRange theRange, uint starting, FSKitBlockmapFlags flags, ulong operationId, FSExtentPacker packer, Action<NSError> reply);

		[Abstract]
		[Export ("endIO:range:status:flags:operationID:replyHandler:")]
		void EndIo (FSItem item, NSRange originalRange, int ioStatus, FSKitBlockmapFlags flags, ulong operationId, Action<NSError> reply);

		[Abstract]
		[Export ("createItemNamed:type:inDirectory:attributes:usingPacker:replyHandler:")]
		void CreateItem (FSFileName name, FSItemType type, FSItem directory, FSItemSetAttributesRequest newAttributes, FSExtentPacker packer, Action<FSItem, NSError> reply);

		[Abstract]
		[Export ("lookupName:inDirectory:usingPacker:replyHandler:")]
		void LookupName (FSFileName name, FSItem directory, FSExtentPacker packer, Action<FSItem, NSError> reply);
	}

	[Mac (15, 0)]
	[Protocol]
	interface FSVolumePreallocateOperations
	{
		[Abstract]
		[Export ("preallocateOperationsInhibited")]
		bool PreallocateOperationsInhibited { get; set; }

		[Abstract]
		[Export ("preallocate:offset:length:flags:usingPacker:replyHandler:")]
		void Preallocate (FSItem item, ulong offset, nuint length, FSKitPreallocateFlags flags, FSExtentPacker packer, Action<nuint, NSError> reply);
	}

	[Partial]
	interface FSTaskParameterConstant {
		[Field ("FSTaskParameterConstantForceLoad")]
		NSString ForceLoad { get; }

		[Field ("FSTaskParameterConstantReadOnly")]
		NSString ReadOnly { get; }
	}
}

#endif // NET
