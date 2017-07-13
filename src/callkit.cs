﻿//
// CallKit bindings
//
// Authors:
//	Alex Soto  <alex.soto@xamarin.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
//

using System;
using XamCore.AVFoundation;
using XamCore.CoreFoundation;
using XamCore.Foundation;
using XamCore.ObjCRuntime;

#if XAMCORE_2_0
namespace XamCore.CallKit {

	[Introduced (PlatformName.iOS, 10, 0)]
	[Native]
	public enum CXCallDirectoryEnabledStatus : nint {
		Unknown = 0,
		Disabled = 1,
		Enabled = 2
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[ErrorDomain ("CXErrorDomain")]
	[Native]
	public enum CXErrorCode : nint {
		Unknown = 0
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[ErrorDomain ("CXErrorDomainIncomingCall")]
	[Native]
	public enum CXErrorCodeIncomingCallError : nint {
		Unknown = 0,
		Unentitled = 1,
		CallUuidAlreadyExists = 2,
		FilteredByDoNotDisturb = 3,
		FilteredByBlockList = 4
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[ErrorDomain ("CXErrorDomainRequestTransaction")]
	[Native]
	public enum CXErrorCodeRequestTransactionError : nint {
		Unknown = 0,
		Unentitled = 1,
		UnknownCallProvider = 2,
		EmptyTransaction = 3,
		UnknownCallUuid = 4,
		CallUuidAlreadyExists = 5,
		InvalidAction = 6,
		MaximumCallGroupsReached = 7
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[ErrorDomain ("CXErrorDomainCallDirectoryManager")]
	[Native]
	public enum CXErrorCodeCallDirectoryManagerError : nint {
		Unknown = 0,
		NoExtensionFound = 1,
		LoadingInterrupted = 2,
		EntriesOutOfOrder = 3,
		DuplicateEntries = 4,
		MaximumEntriesExceeded = 5,
		ExtensionDisabled = 6,
		CurrentlyLoading = 7,
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[Native]
	public enum CXPlayDtmfCallActionType : nint {
		SingleTone = 1,
		SoftPause = 2,
		HardPause = 3
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[Native]
	public enum CXCallEndedReason : nint {
		Failed = 1,
		RemoteEnded = 2,
		Unanswered = 3,
		AnsweredElsewhere = 4,
		DeclinedElsewhere = 5
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[Native]
	public enum CXHandleType : nint {
		Generic = 1,
		PhoneNumber = 2,
		EmailAddress = 3
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CXHandle : NSCopying, NSSecureCoding {

		[Export ("type")]
		CXHandleType Type { get; }

		[Export ("value")]
		string Value { get; }

		[Export ("initWithType:value:")]
		[DesignatedInitializer]
		IntPtr Constructor (CXHandleType type, string value);

		[Export ("isEqualToHandle:")]
		bool IsEqual (CXHandle handle);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	interface CXAction : NSCopying, NSSecureCoding {

		[Export ("UUID", ArgumentSemantic.Copy)]
		NSUuid Uuid { get; }

		[Export ("complete", ArgumentSemantic.Assign)]
		bool Complete { [Bind ("isComplete")] get; }

		[Export ("timeoutDate", ArgumentSemantic.Strong)]
		NSDate TimeoutDate { get; }

		[Export ("fulfill")]
		void Fulfill ();

		[Export ("fail")]
		void Fail ();
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (CXCallAction))]
	[DisableDefaultCtor]
	interface CXAnswerCallAction {

		[Export ("initWithCallUUID:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid);

		[Export ("fulfillWithDateConnected:")]
		void Fulfill (NSDate dateConnected);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CXCall {

		[Export ("UUID", ArgumentSemantic.Copy)]
		NSUuid Uuid { get; }

		[Export ("outgoing")]
		bool Outgoing { [Bind ("isOutgoing")] get; }

		[Export ("onHold")]
		bool OnHold { [Bind ("isOnHold")] get; }

		[Export ("hasConnected")]
		bool HasConnected { get; }

		[Export ("hasEnded")]
		bool HasEnded { get; }

		[Export ("isEqualToCall:")]
		bool IsEqual (CXCall call);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (CXAction))]
	[DisableDefaultCtor]
	interface CXCallAction {

		[Export ("callUUID", ArgumentSemantic.Copy)]
		NSUuid CallUuid { get; }

		[Export ("initWithCallUUID:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	interface CXCallController {

		[Export ("initWithQueue:")]
		[DesignatedInitializer]
		IntPtr Constructor (DispatchQueue queue);

		[Export ("callObserver", ArgumentSemantic.Strong)]
		CXCallObserver CallObserver { get; }

		[Async]
		[Export ("requestTransaction:completion:")]
		void RequestTransaction (CXTransaction transaction, Action<NSError> completion);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSExtensionContext))]
	interface CXCallDirectoryExtensionContext {

		[Export ("addBlockingEntryWithNextSequentialPhoneNumber:")]
		void AddBlockingEntry (/* CXCallDirectoryPhoneNumber -> int64_t */ long phoneNumber);

		[Export ("addIdentificationEntryWithNextSequentialPhoneNumber:label:")]
		void AddIdentificationEntry (/* CXCallDirectoryPhoneNumber -> int64_t */ long phoneNumber, string label);

		[Async]
		[Export ("completeRequestWithCompletionHandler:")]
		void CompleteRequest ([NullAllowed] Action<bool> completion);

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		ICXCallDirectoryExtensionContextDelegate Delegate { get; set; }
	}

	interface ICXCallDirectoryExtensionContextDelegate {}

	[Introduced (PlatformName.iOS, 10, 0)]
	[Protocol][Model]
	[BaseType (typeof (NSObject))]
	interface CXCallDirectoryExtensionContextDelegate {

		[Abstract]
		[Export ("requestFailedForExtensionContext:withError:")]
		void RequestFailed (CXCallDirectoryExtensionContext extensionContext, NSError error);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	interface CXCallDirectoryManager {

		[Static]
		[Export ("sharedInstance")]
		CXCallDirectoryManager SharedInstance { get; }

		[Async]
		[Export ("reloadExtensionWithIdentifier:completionHandler:")]
		void ReloadExtension (string identifier, [NullAllowed] Action<NSError> completion);

		[Async]
		[Export ("getEnabledStatusForExtensionWithIdentifier:completionHandler:")]
		void GetEnabledStatusForExtension (string identifier, Action<CXCallDirectoryEnabledStatus, NSError> completion);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	interface CXCallDirectoryProvider : NSExtensionRequestHandling {

	}

	interface ICXCallObserverDelegate { }

	[Introduced (PlatformName.iOS, 10, 0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface CXCallObserverDelegate {

		[Abstract]
		[Export ("callObserver:callChanged:")]
		void CallChanged (CXCallObserver callObserver, CXCall call);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	interface CXCallObserver {

		[Export ("calls", ArgumentSemantic.Copy)]
		CXCall [] Calls { get; }

		[Export ("setDelegate:queue:")]
		void SetDelegate ([NullAllowed] ICXCallObserverDelegate aDelegate, [NullAllowed] DispatchQueue queue);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	interface CXCallUpdate : NSCopying {

		[NullAllowed, Export ("remoteHandle", ArgumentSemantic.Copy)]
		CXHandle RemoteHandle { get; set; }

		[NullAllowed, Export ("localizedCallerName")]
		string LocalizedCallerName { get; set; }

		[Export ("supportsHolding", ArgumentSemantic.Assign)]
		bool SupportsHolding { get; set; }

		[Export ("supportsGrouping", ArgumentSemantic.Assign)]
		bool SupportsGrouping { get; set; }

		[Export ("supportsUngrouping", ArgumentSemantic.Assign)]
		bool SupportsUngrouping { get; set; }

		[Export ("supportsDTMF", ArgumentSemantic.Assign)]
		bool SupportsDtmf { get; set; }

		[Export ("hasVideo")]
		bool HasVideo { get; set; }
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (CXCallAction))]
	interface CXEndCallAction {

		[Export ("initWithCallUUID:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid);

		[Export ("fulfillWithDateEnded:")]
		void Fulfill (NSDate dateEnded);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (CXCallAction), Name = "CXPlayDTMFCallAction")]
	interface CXPlayDtmfCallAction {

		[Export ("initWithCallUUID:digits:type:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid, string digits, CXPlayDtmfCallActionType type);

		[Export ("digits")]
		string Digits { get; set; }

		[Export ("type", ArgumentSemantic.Assign)]
		CXPlayDtmfCallActionType Type { get; set; }
	}

	interface ICXProviderDelegate { }

	[Protocol, Model]
	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	interface CXProviderDelegate {

		[Abstract]
		[Export ("providerDidReset:")]
		void DidReset (CXProvider provider);

		[Export ("providerDidBegin:")]
		void DidBegin (CXProvider provider);

		[Export ("provider:executeTransaction:")]
		bool ExecuteTransaction (CXProvider provider, CXTransaction transaction);

		[Export ("provider:performStartCallAction:")]
		void PerformStartCallAction (CXProvider provider, CXStartCallAction action);

		[Export ("provider:performAnswerCallAction:")]
		void PerformAnswerCallAction (CXProvider provider, CXAnswerCallAction action);

		[Export ("provider:performEndCallAction:")]
		void PerformEndCallAction (CXProvider provider, CXEndCallAction action);

		[Export ("provider:performSetHeldCallAction:")]
		void PerformSetHeldCallAction (CXProvider provider, CXSetHeldCallAction action);

		[Export ("provider:performSetMutedCallAction:")]
		void PerformSetMutedCallAction (CXProvider provider, CXSetMutedCallAction action);

		[Export ("provider:performSetGroupCallAction:")]
		void PerformSetGroupCallAction (CXProvider provider, CXSetGroupCallAction action);

		[Export ("provider:performPlayDTMFCallAction:")]
		void PerformPlayDtmfCallAction (CXProvider provider, CXPlayDtmfCallAction action);

		[Export ("provider:timedOutPerformingAction:")]
		void TimedOutPerformingAction (CXProvider provider, CXAction action);

		[Export ("provider:didActivateAudioSession:")]
		void DidActivateAudioSession (CXProvider provider, AVAudioSession audioSession);

		[Export ("provider:didDeactivateAudioSession:")]
		void DidDeactivateAudioSession (CXProvider provider, AVAudioSession audioSession);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CXProvider {

		[Export ("initWithConfiguration:")]
		[DesignatedInitializer]
		IntPtr Constructor (CXProviderConfiguration configuration);

		[Export ("setDelegate:queue:")]
		void SetDelegate ([NullAllowed] ICXProviderDelegate aDelegate, [NullAllowed] DispatchQueue queue);

		[Async]
		[Export ("reportNewIncomingCallWithUUID:update:completion:")]
		void ReportNewIncomingCall (NSUuid uuid, CXCallUpdate update, Action<NSError> completion);

		[Export ("reportCallWithUUID:updated:")]
		void ReportCall (NSUuid uuid, CXCallUpdate update);

		[Export ("reportCallWithUUID:endedAtDate:reason:")]
		void ReportCall (NSUuid uuid, [NullAllowed] NSDate dateEnded, CXCallEndedReason endedReason);

		[Export ("reportOutgoingCallWithUUID:startedConnectingAtDate:")]
		void ReportConnectingOutgoingCall (NSUuid uuid, [NullAllowed] NSDate dateStartedConnecting);

		[Export ("reportOutgoingCallWithUUID:connectedAtDate:")]
		void ReportConnectedOutgoingCall (NSUuid uuid, [NullAllowed] NSDate dateConnected);

		[Export ("configuration", ArgumentSemantic.Copy)]
		CXProviderConfiguration Configuration { get; set; }

		[Export ("invalidate")]
		void Invalidate ();

		[Export ("pendingTransactions", ArgumentSemantic.Copy)]
		CXTransaction [] PendingTransactions { get; }

		[Export ("pendingCallActionsOfClass:withCallUUID:")]
		CXCallAction [] GetPendingCallActions (Class callActionClass, NSUuid callUuid);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CXProviderConfiguration : NSCopying {

		[Export ("localizedName")]
		string LocalizedName { get; }

		[NullAllowed, Export ("ringtoneSound", ArgumentSemantic.Strong)]
		string RingtoneSound { get; set; }

		[Advice ("Squared image 40x40 points")]
		[NullAllowed, Export ("iconTemplateImageData", ArgumentSemantic.Copy)]
		NSData IconTemplateImageData { get; set; }

		[Export ("maximumCallGroups")]
		nuint MaximumCallGroups { get; set; }

		[Export ("maximumCallsPerCallGroup")]
		nuint MaximumCallsPerCallGroup { get; set; }

		[Export ("supportsVideo")]
		bool SupportsVideo { get; set; }

		[Export ("supportedHandleTypes", ArgumentSemantic.Copy)]
		NSSet<NSNumber> SupportedHandleTypes { get; set; }

		[Export ("initWithLocalizedName:")]
		IntPtr Constructor (string localizedName);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (CXCallAction))]
	[DisableDefaultCtor]
	interface CXSetGroupCallAction {

		[Export ("initWithCallUUID:callUUIDToGroupWith:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid, [NullAllowed] NSUuid callUuidToGroupWith);

		[NullAllowed, Export ("callUUIDToGroupWith", ArgumentSemantic.Assign)]
		NSUuid CallUuidToGroupWith { get; set; }
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (CXCallAction))]
	interface CXSetHeldCallAction {

		[Export ("initWithCallUUID:onHold:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid, bool onHold);

		[Export ("onHold")]
		bool OnHold { [Bind ("isOnHold")] get; set; }
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (CXCallAction))]
	[DisableDefaultCtor]
	interface CXSetMutedCallAction {

		[Export ("initWithCallUUID:muted:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid, bool muted);

		[Export ("muted")]
		bool Muted { [Bind ("isMuted")] get; set; }
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[DisableDefaultCtor]
	[BaseType (typeof (CXCallAction))]
	interface CXStartCallAction {

		// initWithCallUUID: explicitly marked with NS_UNAVAILABLE

		[Export ("initWithCallUUID:handle:")]
		[DesignatedInitializer]
		IntPtr Constructor (NSUuid callUuid, CXHandle callHandle);

		[Export ("handle", ArgumentSemantic.Copy)]
		CXHandle CallHandle { get; set; }

		[NullAllowed, Export ("contactIdentifier")]
		string ContactIdentifier { get; set; }

		[Export ("video")]
		bool Video { [Bind ("isVideo")] get; set; }

		[Export ("fulfillWithDateStarted:")]
		void Fulfill (NSDate dateStarted);
	}

	[Introduced (PlatformName.iOS, 10, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // there's a designated initializer that does not accept null
	interface CXTransaction : NSCopying, NSSecureCoding {

		[Export ("initWithActions:")]
		[DesignatedInitializer]
		IntPtr Constructor (CXAction[] actions);

		[Export ("initWithAction:")]
		IntPtr Constructor (CXAction action);

		[Export ("UUID", ArgumentSemantic.Copy)]
		NSUuid Uuid { get; }

		[Export ("complete", ArgumentSemantic.Assign)]
		bool Complete { [Bind ("isComplete")] get; }

		[Export ("actions", ArgumentSemantic.Copy)]
		CXAction [] Actions { get; }

		[Export ("addAction:")]
		void AddAction (CXAction action);
	}
}
#endif // XAMCORE_2_0
