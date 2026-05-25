//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.Versioning;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using CoreImage;
using SpriteKit;
using Foundation;
using ObjCRuntime;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace HomeKit {
	/// <summary>Enumerates possible failures in Home Kit operations.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	[Native ("HMErrorCode")]
	public enum HMError : long {
		/// <summary>An unexpected error occurred..</summary>
		UnexpectedError = -1,
		/// <summary>The container already has the object and another cannot be added.</summary>
		AlreadyExists = 1,
		/// <summary>The object was not found in the container.</summary>
		NotFound = 2,
		/// <summary>A parameter was invalid.</summary>
		InvalidParameter = 3,
		/// <summary>The accessory could not be reached.</summary>
		AccessoryNotReachable = 4,
		/// <summary>The characteristic cannot be written to.</summary>
		ReadOnlyCharacteristic = 5,
		/// <summary>The characteristic cannot be read.</summary>
		WriteOnlyCharacteristic = 6,
		/// <summary>The notification could not be enabled because it is not supported.</summary>
		NotificationNotSupported = 7,
		/// <summary>The operation timed out.</summary>
		OperationTimedOut = 8,
		/// <summary>The accessory was turned off.</summary>
		AccessoryPoweredOff = 9,
		/// <summary>Access to a resource was denied.</summary>
		AccessDenied = 10,
		/// <summary>The object could not be associated because it was already associated with another home.</summary>
		ObjectAssociatedToAnotherHome = 11,
		/// <summary>The operation could not be performed because the object was not associated with any home.</summary>
		ObjectNotAssociatedToAnyHome = 12,
		/// <summary>The object could not be associated because it was already associated with the home.</summary>
		ObjectAlreadyAssociatedToHome = 13,
		/// <summary>The accessory was busy.</summary>
		AccessoryIsBusy = 14,
		/// <summary>Another operation was in progress.</summary>
		OperationInProgress = 15,
		/// <summary>The accessory was out of resources.</summary>
		AccessoryOutOfResources = 16,
		/// <summary>The user lacked the privilege to perform the operation.</summary>
		InsufficientPrivileges = 17,
		/// <summary>The accessory could not be paired.</summary>
		AccessoryPairingFailed = 18,
		/// <summary>An invalid data format was specified.</summary>
		InvalidDataFormatSpecified = 19,
		/// <summary>A parameter that must not be <see langword="null" /> was supplied as <see langword="null" />.</summary>
		NilParameter = 20,
		/// <summary>The supplied parameter was not configured.</summary>
		UnconfiguredParameter = 21,
		/// <summary>An invalid abstract base class was used.</summary>
		InvalidClass = 22,
		/// <summary>The operation was canceled.</summary>
		OperationCancelled = 23,
		/// <summary>The room that specifies the entire home could not be added to a zone within the home.</summary>
		RoomForHomeCannotBeInZone = 24,
		/// <summary>An operation tried to execute an empty action set.</summary>
		NoActionsInActionSet = 25,
		/// <summary>An operation tried to activate a trigger that had no action sets.</summary>
		NoRegisteredActionSets = 26,
		/// <summary>A required parameter was missing.</summary>
		MissingParameter = 27,
		/// <summary>The date the action was to be fired was in the past.</summary>
		FireDateInPast = 28,
		/// <summary>An attempt was made to update the room for the entire home.</summary>
		RoomForHomeCannotBeUpdated = 29,
		/// <summary>The action was already in another action set and could not be added.</summary>
		ActionInAnotherActionSet = 30,
		/// <summary>The object could not be associated because another existing object has a similar name.</summary>
		ObjectWithSimilarNameExistsInHome = 31,
		/// <summary>A home with a similar name already exists.</summary>
		HomeWithSimilarNameExists = 32,
		/// <summary>An attempt was made to rename an object, but the new name was too similar to an existing object.</summary>
		RenameWithSimilarName = 33,
		/// <summary>The accessory could not be removed because it is bridged.</summary>
		CannotRemoveNonBridgeAccessory = 34,
		/// <summary>The supplied name contains prohibited characters.</summary>
		NameContainsProhibitedCharacters = 35,
		/// <summary>The supplied name started with invalid characters.</summary>
		NameDoesNotStartWithValidCharacters = 36,
		/// <summary>The supplied user ID was not an email address.</summary>
		UserIDNotEmailAddress = 37,
		/// <summary>A user declined to add the user.</summary>
		UserDeclinedAddingUser = 38,
		/// <summary>The user declined to remove a user.</summary>
		UserDeclinedRemovingUser = 39,
		/// <summary>A user declined an invitation from the user.</summary>
		UserDeclinedInvite = 40,
		/// <summary>An unspecified user management error occurred.</summary>
		UserManagementFailed = 41,
		/// <summary>The recurrence length was too small.</summary>
		RecurrenceTooSmall = 42,
		/// <summary>Data of an incorrect type were provided.</summary>
		InvalidValueType = 43,
		/// <summary>A value did not meet its required minimum.</summary>
		ValueLowerThanMinimum = 44,
		/// <summary>A value exceeded its allowed maximum.</summary>
		ValueHigherThanMaximum = 45,
		/// <summary>The maximum string length was exceeded.</summary>
		StringLongerThanMaximum = 46,
		/// <summary>Home access was not authorized.</summary>
		HomeAccessNotAuthorized = 47,
		/// <summary>The operation is not supported.</summary>
		OperationNotSupported = 48,
		/// <summary>The maximum number of objects have already been created or stored.</summary>
		MaximumObjectLimitReached = 49,
		/// <summary>The accessory's response was invalid.</summary>
		AccessorySentInvalidResponse = 50,
		/// <summary>The minimum string length was not met.</summary>
		StringShorterThanMinimum = 51,
		/// <summary>An unspecified error occurred.</summary>
		GenericError = 52,
		/// <summary>There was a security failure.</summary>
		SecurityFailure = 53,
		/// <summary>There was a communication error.</summary>
		CommunicationFailure = 54,
		/// <summary>The message could not be authenticated.</summary>
		MessageAuthenticationFailed = 55,
		/// <summary>The message size was invalid.</summary>
		InvalidMessageSize = 56,
		/// <summary>A failure occurred while attempting to discover an accessory.</summary>
		AccessoryDiscoveryFailed = 57,
		/// <summary>The was a client request error.</summary>
		ClientRequestError = 58,
		/// <summary>The accessory response indicated an error.</summary>
		AccessoryResponseError = 59,
		/// <summary>The supplied name ended with invalid characters.</summary>
		NameDoesNotEndWithValidCharacters = 60,
		/// <summary>The accessory was blocked.</summary>
		AccessoryIsBlocked = 61,
		/// <summary>The associated service type was invalid.</summary>
		InvalidAssociatedServiceType = 62,
		/// <summary>The action set failed to execute.</summary>
		ActionSetExecutionFailed = 63,
		/// <summary>The action set partially succeeded.</summary>
		ActionSetExecutionPartialSuccess = 64,
		/// <summary>The action set was already in progress.</summary>
		ActionSetExecutionInProgress = 65,
		/// <summary>The accessory was out of compliance.</summary>
		AccessoryOutOfCompliance = 66,
		/// <summary>Data resetting failed.</summary>
		DataResetFailure = 67,
		/// <summary>The notification could not be enabled because it already was enabled.</summary>
		NotificationAlreadyEnabled = 68,
		/// <summary>The recurrence was required to be within the specified boundaries, and it was not.</summary>
		RecurrenceMustBeOnSpecifiedBoundaries = 69,
		/// <summary>The date was required to be within specified boundaries, and it was not.</summary>
		DateMustBeOnSpecifiedBoundaries = 70,
		/// <summary>The trigger could not be activated because it takes place too far into the future.</summary>
		CannotActivateTriggerTooFarInFuture = 71,
		/// <summary>The recurrence length was too large.</summary>
		RecurrenceTooLarge = 72,
		/// <summary>The read or write partially succeeded.</summary>
		ReadWritePartialSuccess = 73,
		/// <summary>The read or write failed.</summary>
		ReadWriteFailure = 74,
		/// <summary>The user or application is not signed in to iCloud.</summary>
		NotSignedIntoiCloud = 75,
		/// <summary>Keychain synchronization was not enabled.</summary>
		KeychainSyncNotEnabled = 76,
		/// <summary>Data was synchronizing.</summary>
		CloudDataSyncInProgress = 77,
		/// <summary>The network was unavailable.</summary>
		NetworkUnavailable = 78,
		/// <summary>The accessory could not be added.</summary>
		AddAccessoryFailed = 79,
		/// <summary>An entitlement was missing.</summary>
		MissingEntitlement = 80,
		/// <summary>An accessory, accessed via a bridge, cannot be unblocked.</summary>
		CannotUnblockNonBridgeAccessory = 81,
		/// <summary>The device is locked.</summary>
		DeviceLocked = 82,
		/// <summary>The user attempted to remove a non-deletable <see cref="T:HomeKit.HMActionSet" />.</summary>
		CannotRemoveBuiltinActionSet = 83,
		/// <summary>The user has not made their home's location available.</summary>
		LocationForHomeDisabled = 84,
		/// <summary>The user has not explicitly allowed location services.</summary>
		NotAuthorizedForLocationServices = 85,
		/// <summary>The error should be diagnosed using the user manual.</summary>
		ReferToUserManual = 86,
		/// <summary>Authorization is required.</summary>
		InvalidOrMissingAuthorizationData = 87,
		/// <summary>The accessory, expected to be reachable via a bridge, is not reachable.</summary>
		BridgedAccessoryNotReachable = 88,
		/// <summary>The user has not explicitly allowed access to the device microphone.</summary>
		NotAuthorizedForMicrophoneAccess = 89,
		/// <summary>The network was not compatible.</summary>
		IncompatibleNetwork = 90,
		/// <summary>No compatible hub could be found.</summary>
		NoHomeHub = 91,
		/// <summary>The hub was not compatible.</summary>
		IncompatibleHomeHub = 92,
		/// <summary>The accessory could not be added because it was not compatible with HomeKit.</summary>
		IncompatibleAccessory = 93,
		ObjectWithSimilarNameExists = 95,
		OwnershipFailure = 96,
		MaximumAccessoriesOfTypeInHome = 97,
		WiFiCredentialGenerationFailed = 98,
		EnterpriseNetworkNotSupported = 99,
		TimedOutWaitingForAccessory = 100,
		AccessoryCommunicationFailure = 101,
		FailedToJoinNetwork = 102,
		AccessoryIsSuspended = 103,
		PartialCommunicationFailure = 104,
		HomeUpgradeRequired = 105,
		QuotaExceeded = 106,
	}
}
