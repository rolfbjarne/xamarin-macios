using System;
using ObjCRuntime;
using Foundation;

namespace HomeKit {

	[MacCatalyst (14, 0)]
	[Native ("HMErrorCode")]
	public enum HMError : long {
		UnexpectedError = -1,
		AlreadyExists = 1,
		NotFound = 2,
		InvalidParameter = 3,
		AccessoryNotReachable = 4,
		ReadOnlyCharacteristic = 5,
		WriteOnlyCharacteristic = 6,
		NotificationNotSupported = 7,
		OperationTimedOut = 8,
		AccessoryPoweredOff = 9,
		AccessDenied = 10,
		ObjectAssociatedToAnotherHome = 11,
		ObjectNotAssociatedToAnyHome = 12,
		ObjectAlreadyAssociatedToHome = 13,
		AccessoryIsBusy = 14,
		OperationInProgress = 15,
		AccessoryOutOfResources = 16,
		InsufficientPrivileges = 17,
		AccessoryPairingFailed = 18,
		InvalidDataFormatSpecified = 19,
		NilParameter = 20,
		UnconfiguredParameter = 21,
		InvalidClass = 22,
		OperationCancelled = 23,
		RoomForHomeCannotBeInZone = 24,
		NoActionsInActionSet = 25,
		NoRegisteredActionSets = 26,
		MissingParameter = 27,
		FireDateInPast = 28,
		RoomForHomeCannotBeUpdated = 29,
		ActionInAnotherActionSet = 30,
		ObjectWithSimilarNameExistsInHome = 31,
		HomeWithSimilarNameExists = 32,
		RenameWithSimilarName = 33,
		CannotRemoveNonBridgeAccessory = 34,
		NameContainsProhibitedCharacters = 35,
		NameDoesNotStartWithValidCharacters = 36,
		UserIDNotEmailAddress = 37,
		UserDeclinedAddingUser = 38,
		UserDeclinedRemovingUser = 39,
		UserDeclinedInvite = 40,
		UserManagementFailed = 41,
		RecurrenceTooSmall = 42,
		InvalidValueType = 43,
		ValueLowerThanMinimum = 44,
		ValueHigherThanMaximum = 45,
		StringLongerThanMaximum = 46,
		HomeAccessNotAuthorized = 47,
		OperationNotSupported = 48,
		MaximumObjectLimitReached = 49,
		AccessorySentInvalidResponse = 50,
		StringShorterThanMinimum = 51,
		GenericError = 52,
		SecurityFailure = 53,
		CommunicationFailure = 54,
		MessageAuthenticationFailed = 55,
		InvalidMessageSize = 56,
		AccessoryDiscoveryFailed = 57,
		ClientRequestError = 58,
		AccessoryResponseError = 59,
		NameDoesNotEndWithValidCharacters = 60,
		AccessoryIsBlocked = 61,
		InvalidAssociatedServiceType = 62,
		ActionSetExecutionFailed = 63,
		ActionSetExecutionPartialSuccess = 64,
		ActionSetExecutionInProgress = 65,
		AccessoryOutOfCompliance = 66,
		DataResetFailure = 67,
		NotificationAlreadyEnabled = 68,
		RecurrenceMustBeOnSpecifiedBoundaries = 69,
		DateMustBeOnSpecifiedBoundaries = 70,
		CannotActivateTriggerTooFarInFuture = 71,
		RecurrenceTooLarge = 72,
		ReadWritePartialSuccess = 73,
		ReadWriteFailure = 74,
		NotSignedIntoiCloud = 75,
		KeychainSyncNotEnabled = 76,
		CloudDataSyncInProgress = 77,
		NetworkUnavailable = 78,
		AddAccessoryFailed = 79,
		MissingEntitlement = 80,
		CannotUnblockNonBridgeAccessory = 81,
		DeviceLocked = 82,
		CannotRemoveBuiltinActionSet = 83,
		LocationForHomeDisabled = 84,
		NotAuthorizedForLocationServices = 85,
		// iOS 9.3
		ReferToUserManual = 86,
		// iOS 10.0
		InvalidOrMissingAuthorizationData = 87,
		BridgedAccessoryNotReachable = 88,
		NotAuthorizedForMicrophoneAccess = 89,
		// iOS 10.2
		IncompatibleNetwork = 90,
		// iOS 11
		NoHomeHub = 91,
		IncompatibleHomeHub = 92, // HMErrorCodeNoCompatibleHomeHub introduced and deprecated on iOS 11. HMErrorCodeIncompatibleHomeHub = HMErrorCodeNoCompatibleHomeHub.
		IncompatibleAccessory = 93,
		ObjectWithSimilarNameExists = 95,
		OwnershipFailure = 96,
		MaximumAccessoriesOfTypeInHome = 97,
		WiFiCredentialGenerationFailed = 98,
		// iOS 14
		EnterpriseNetworkNotSupported = 99,
		TimedOutWaitingForAccessory = 100,
		AccessoryCommunicationFailure = 101,
		FailedToJoinNetwork = 102,
		// iOS 15
		AccessoryIsSuspended = 103,
	}


	// conveniance enum (ObjC uses NSString)
	[MacCatalyst (14, 0)]
	public enum HMCharacteristicType {
		None,

		[Field ("HMCharacteristicTypePowerState")]
		PowerState,

		[Field ("HMCharacteristicTypeHue")]
		Hue,

		[Field ("HMCharacteristicTypeSaturation")]
		Saturation,

		[Field ("HMCharacteristicTypeBrightness")]
		Brightness,

		[Field ("HMCharacteristicTypeTemperatureUnits")]
		TemperatureUnits,

		[Field ("HMCharacteristicTypeCurrentTemperature")]
		CurrentTemperature,

		[Field ("HMCharacteristicTypeTargetTemperature")]
		TargetTemperature,

		[Field ("HMCharacteristicTypeCurrentHeatingCooling")]
		CurrentHeatingCooling,

		[Field ("HMCharacteristicTypeTargetHeatingCooling")]
		TargetHeatingCooling,

		[Field ("HMCharacteristicTypeCoolingThreshold")]
		CoolingThreshold,

		[Field ("HMCharacteristicTypeHeatingThreshold")]
		HeatingThreshold,

#if !NET
		[Obsolete ("This value does not exist anymore and will always return null.")]
		HeatingCoolingStatus,
#endif

		[Field ("HMCharacteristicTypeCurrentRelativeHumidity")]
		CurrentRelativeHumidity,

		[Field ("HMCharacteristicTypeTargetRelativeHumidity")]
		TargetRelativeHumidity,

		[Field ("HMCharacteristicTypeCurrentDoorState")]
		CurrentDoorState,

		[Field ("HMCharacteristicTypeTargetDoorState")]
		TargetDoorState,

		[Field ("HMCharacteristicTypeObstructionDetected")]
		ObstructionDetected,

		[Field ("HMCharacteristicTypeName")]
		Name,

		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use 'HMAccessory.Manufacturer' instead.")]
		[Deprecated (PlatformName.WatchOS, 4, 0, message: "Use 'HMAccessory.Manufacturer' instead.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use 'HMAccessory.Manufacturer' instead.")]
		[Field ("HMCharacteristicTypeManufacturer")]
		Manufacturer,

		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use 'HMAccessory.Model' instead.")]
		[Deprecated (PlatformName.WatchOS, 4, 0, message: "Use 'HMAccessory.Model' instead.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use 'HMAccessory.Model' instead.")]
		[Field ("HMCharacteristicTypeModel")]
		Model,

		[Deprecated (PlatformName.TvOS, 11, 0, message: "No longer supported.")]
		[Deprecated (PlatformName.WatchOS, 4, 0, message: "No longer supported.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "No longer supported.")]
		[Field ("HMCharacteristicTypeSerialNumber")]
		SerialNumber,

		[Field ("HMCharacteristicTypeIdentify")]
		Identify,

		[Field ("HMCharacteristicTypeRotationDirection")]
		RotationDirection,

		[Field ("HMCharacteristicTypeRotationSpeed")]
		RotationSpeed,

		[Field ("HMCharacteristicTypeOutletInUse")]
		OutletInUse,

		[Field ("HMCharacteristicTypeVersion")]
		Version,

		[Field ("HMCharacteristicTypeLogs")]
		Logs,

		[Field ("HMCharacteristicTypeAudioFeedback")]
		AudioFeedback,

		[Field ("HMCharacteristicTypeAdminOnlyAccess")]
		AdminOnlyAccess,

		[Field ("HMCharacteristicTypeMotionDetected")]
		MotionDetected,

		[Field ("HMCharacteristicTypeCurrentLockMechanismState")]
		CurrentLockMechanismState,

		[Field ("HMCharacteristicTypeTargetLockMechanismState")]
		TargetLockMechanismState,

		[Field ("HMCharacteristicTypeLockMechanismLastKnownAction")]
		LockMechanismLastKnownAction,

		[Field ("HMCharacteristicTypeLockManagementControlPoint")]
		LockManagementControlPoint,

		[Field ("HMCharacteristicTypeLockManagementAutoSecureTimeout")]
		LockManagementAutoSecureTimeout,

		[Field ("HMCharacteristicTypeAirParticulateDensity")]
		AirParticulateDensity,

		[Field ("HMCharacteristicTypeAirParticulateSize")]
		AirParticulateSize,

		[Field ("HMCharacteristicTypeAirQuality")]
		AirQuality,

		[Field ("HMCharacteristicTypeBatteryLevel")]
		BatteryLevel,

		[Field ("HMCharacteristicTypeCarbonDioxideDetected")]
		CarbonDioxideDetected,

		[Field ("HMCharacteristicTypeCarbonDioxideLevel")]
		CarbonDioxideLevel,

		[Field ("HMCharacteristicTypeCarbonDioxidePeakLevel")]
		CarbonDioxidePeakLevel,

		[Field ("HMCharacteristicTypeCarbonMonoxideDetected")]
		CarbonMonoxideDetected,

		[Field ("HMCharacteristicTypeCarbonMonoxideLevel")]
		CarbonMonoxideLevel,

		[Field ("HMCharacteristicTypeCarbonMonoxidePeakLevel")]
		CarbonMonoxidePeakLevel,

		[Field ("HMCharacteristicTypeChargingState")]
		ChargingState,

		[Field ("HMCharacteristicTypeContactState")]
		ContactState,

		[Field ("HMCharacteristicTypeCurrentSecuritySystemState")]
		CurrentSecuritySystemState,

		[Field ("HMCharacteristicTypeCurrentHorizontalTilt")]
		CurrentHorizontalTilt,

		[Field ("HMCharacteristicTypeCurrentLightLevel")]
		CurrentLightLevel,

		[Field ("HMCharacteristicTypeCurrentPosition")]
		CurrentPosition,

		[Field ("HMCharacteristicTypeCurrentVerticalTilt")]
		CurrentVerticalTilt,

		[Deprecated (PlatformName.TvOS, 11, 0, message: "Use 'HMAccessory.FirmwareVersion' instead.")]
		[Deprecated (PlatformName.WatchOS, 4, 0, message: "Use 'HMAccessory.FirmwareVersion' instead.")]
		[Deprecated (PlatformName.iOS, 11, 0, message: "Use 'HMAccessory.FirmwareVersion' instead.")]
		[Field ("HMCharacteristicTypeFirmwareVersion")]
		FirmwareVersion,

		[Field ("HMCharacteristicTypeHardwareVersion")]
		HardwareVersion,

		[Field ("HMCharacteristicTypeHoldPosition")]
		HoldPosition,

		[Field ("HMCharacteristicTypeInputEvent")]
		InputEvent,

		[Field ("HMCharacteristicTypeLeakDetected")]
		LeakDetected,

		[Field ("HMCharacteristicTypeOccupancyDetected")]
		OccupancyDetected,

		[Field ("HMCharacteristicTypeOutputState")]
		OutputState,

		[Field ("HMCharacteristicTypePositionState")]
		PositionState,

		[Field ("HMCharacteristicTypeSmokeDetected")]
		SmokeDetected,

		[Field ("HMCharacteristicTypeSoftwareVersion")]
		SoftwareVersion,

		[Field ("HMCharacteristicTypeStatusActive")]
		StatusActive,

		[Field ("HMCharacteristicTypeStatusFault")]
		StatusFault,

		[Field ("HMCharacteristicTypeStatusJammed")]
		StatusJammed,

		[Field ("HMCharacteristicTypeStatusLowBattery")]
		StatusLowBattery,

		[Field ("HMCharacteristicTypeStatusTampered")]
		StatusTampered,

		[Field ("HMCharacteristicTypeTargetSecuritySystemState")]
		TargetSecuritySystemState,

		[Field ("HMCharacteristicTypeTargetHorizontalTilt")]
		TargetHorizontalTilt,

		[Field ("HMCharacteristicTypeTargetPosition")]
		TargetPosition,

		[Field ("HMCharacteristicTypeTargetVerticalTilt")]
		TargetVerticalTilt,

		[Field ("HMCharacteristicTypeStreamingStatus")]
		StreamingStatus,

		[Field ("HMCharacteristicTypeSetupStreamEndpoint")]
		SetupStreamEndpoint,

		[Field ("HMCharacteristicTypeSupportedVideoStreamConfiguration")]
		SupportedVideoStreamConfiguration,

		[Field ("HMCharacteristicTypeSupportedAudioStreamConfiguration")]
		SupportedAudioStreamConfiguration,

		[Field ("HMCharacteristicTypeSupportedRTPConfiguration")]
		SupportedRtpConfiguration,

		[Field ("HMCharacteristicTypeSelectedStreamConfiguration")]
		SelectedStreamConfiguration,

		[Field ("HMCharacteristicTypeVolume")]
		Volume,

		[Field ("HMCharacteristicTypeMute")]
		Mute,

		[Field ("HMCharacteristicTypeNightVision")]
		NightVision,

		[Field ("HMCharacteristicTypeOpticalZoom")]
		OpticalZoom,

		[Field ("HMCharacteristicTypeDigitalZoom")]
		DigitalZoom,

		[Field ("HMCharacteristicTypeImageRotation")]
		ImageRotation,

		[Field ("HMCharacteristicTypeImageMirroring")]
		ImageMirroring,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeActive")]
		Active,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeCurrentAirPurifierState")]
		CurrentAirPurifierState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeTargetAirPurifierState")]
		TargetAirPurifierState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeCurrentFanState")]
		CurrentFanState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeCurrentHeaterCoolerState")]
		CurrentHeaterCoolerState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeCurrentHumidifierDehumidifierState")]
		CurrentHumidifierDehumidifierState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeCurrentSlatState")]
		CurrentSlatState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeWaterLevel")]
		WaterLevel,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeFilterChangeIndication")]
		FilterChangeIndication,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeFilterLifeLevel")]
		FilterLifeLevel,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeFilterResetChangeIndication")]
		FilterResetChangeIndication,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeLockPhysicalControls")]
		LockPhysicalControls,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeSwingMode")]
		SwingMode,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeTargetHeaterCoolerState")]
		TargetHeaterCoolerState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeTargetHumidifierDehumidifierState")]
		TargetHumidifierDehumidifierState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeTargetFanState")]
		TargetFanState,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeSlatType")]
		SlatType,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeCurrentTilt")]
		CurrentTilt,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeTargetTilt")]
		TargetTilt,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeOzoneDensity")]
		OzoneDensity,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeNitrogenDioxideDensity")]
		NitrogenDioxideDensity,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeSulphurDioxideDensity")]
		SulphurDioxideDensity,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypePM2_5Density")]
		PM2_5Density,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypePM10Density")]
		PM10Density,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeVolatileOrganicCompoundDensity")]
		VolatileOrganicCompoundDensity,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeDehumidifierThreshold")]
		DehumidifierThreshold,

		[Watch (3, 1, 1)]
		[Field ("HMCharacteristicTypeHumidifierThreshold")]
		HumidifierThreshold,

		[Field ("HMCharacteristicTypeSecuritySystemAlarmType")]
		SecuritySystemAlarmType,

		[Field ("HMCharacteristicTypeLabelNamespace")]
		LabelNamespace,

		[Field ("HMCharacteristicTypeLabelIndex")]
		LabelIndex,

		[iOS (11, 0), Watch (4, 0), TV (11, 0)]
		[Field ("HMCharacteristicTypeColorTemperature")]
		ColorTemperature,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMCharacteristicTypeProgramMode")]
		ProgramMode,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMCharacteristicTypeInUse")]
		InUse,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMCharacteristicTypeSetDuration")]
		SetDuration,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMCharacteristicTypeRemainingDuration")]
		RemainingDuration,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMCharacteristicTypeValveType")]
		ValveType,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMCharacteristicTypeIsConfigured")]
		IsConfigured,
	}

	// conveniance enum (ObjC uses NSString)
	public enum HMCharacteristicMetadataUnits {
		None,
		Celsius,
		Fahrenheit,
		Percentage,
		ArcDegree,
		Seconds,
		Lux,
		PartsPerMillion,
		MicrogramsPerCubicMeter,
	}

	// conveniance enum (ObjC uses NSString)
	[MacCatalyst (14, 0)]
	[Flags]
	public enum HMServiceType {
		None,

		[Field ("HMServiceTypeLightbulb")]
		LightBulb,

		[Field ("HMServiceTypeSwitch")]
		Switch,

		[Field ("HMServiceTypeThermostat")]
		Thermostat,

		[Field ("HMServiceTypeGarageDoorOpener")]
		GarageDoorOpener,

		[Field ("HMServiceTypeAccessoryInformation")]
		AccessoryInformation,

		[Field ("HMServiceTypeFan")]
		Fan,

		[Field ("HMServiceTypeOutlet")]
		Outlet,

		[Field ("HMServiceTypeLockMechanism")]
		LockMechanism,

		[Field ("HMServiceTypeLockManagement")]
		LockManagement,

		[Field ("HMServiceTypeAirQualitySensor")]
		AirQualitySensor,

		[Field ("HMServiceTypeBattery")]
		Battery,

		[Field ("HMServiceTypeCarbonDioxideSensor")]
		CarbonDioxideSensor,

		[Field ("HMServiceTypeCarbonMonoxideSensor")]
		CarbonMonoxideSensor,

		[Field ("HMServiceTypeContactSensor")]
		ContactSensor,

		[Field ("HMServiceTypeDoor")]
		Door,

		[Field ("HMServiceTypeHumiditySensor")]
		HumiditySensor,

		[Field ("HMServiceTypeLeakSensor")]
		LeakSensor,

		[Field ("HMServiceTypeLightSensor")]
		LightSensor,

		[Field ("HMServiceTypeMotionSensor")]
		MotionSensor,

		[Field ("HMServiceTypeOccupancySensor")]
		OccupancySensor,

		[Field ("HMServiceTypeSecuritySystem")]
		SecuritySystem,

		[Field ("HMServiceTypeStatefulProgrammableSwitch")]
		StatefulProgrammableSwitch,

		[Field ("HMServiceTypeStatelessProgrammableSwitch")]
		StatelessProgrammableSwitch,

		[Field ("HMServiceTypeSmokeSensor")]
		SmokeSensor,

		[Field ("HMServiceTypeTemperatureSensor")]
		TemperatureSensor,

		[Field ("HMServiceTypeWindow")]
		Window,

		[Field ("HMServiceTypeWindowCovering")]
		WindowCovering,

		[Field ("HMServiceTypeCameraRTPStreamManagement")]
		CameraRtpStreamManagement,

		[Field ("HMServiceTypeCameraControl")]
		CameraControl,

		[Field ("HMServiceTypeMicrophone")]
		Microphone,

		[Field ("HMServiceTypeSpeaker")]
		Speaker,

		[Field ("HMServiceTypeDoorbell")]
		Doorbell,

		[Watch (3, 1, 1)]
		[Field ("HMServiceTypeAirPurifier")]
		AirPurifier,

		[Watch (3, 1, 1)]
		[Field ("HMServiceTypeVentilationFan")]
		VentilationFan,

		[Watch (3, 1, 1)]
		[Field ("HMServiceTypeFilterMaintenance")]
		FilterMaintenance,

		[Watch (3, 1, 1)]
		[Field ("HMServiceTypeHeaterCooler")]
		HeaterCooler,

		[Watch (3, 1, 1)]
		[Field ("HMServiceTypeHumidifierDehumidifier")]
		HumidifierDehumidifier,

		[Watch (3, 1, 1)]
		[Field ("HMServiceTypeSlats")]
		Slats,

		[Field ("HMServiceTypeLabel")]
		Label,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMServiceTypeIrrigationSystem")]
		IrrigationSystem,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMServiceTypeValve")]
		Valve,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMServiceTypeFaucet")]
		Faucet,
	}

	// conveniance enum (ObjC uses NSString)
	public enum HMCharacteristicMetadataFormat {
		None,
		Bool,
		Int,
		Float,
		String,
		Array,
		Dictionary,
		UInt8,
		UInt16,
		UInt32,
		UInt64,
		Data,
		Tlv8
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueDoorState : long {
		Open = 0,
		Closed,
		Opening,
		Closing,
		Stopped
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueHeatingCooling : long {
		Off = 0,
		Heat,
		Cool,
		Auto
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueRotationDirection : long {
		Clockwise = 0,
		CounterClockwise
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueTemperatureUnit : long {
		Celsius = 0,
		Fahrenheit
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueLockMechanismState : long {
		Unsecured = 0,
		Secured,
		Jammed,
		Unknown
	}

	[MacCatalyst (14, 0)]
	[Native ("HMCharacteristicValueLockMechanismLastKnownAction")]
	// in iOS 8.3 this was renamed HMCharacteristicValueLockMechanismLastKnownAction but that would be a breaking change for us
	public enum HMCharacteristicValueLockMechanism : long {
		LastKnownActionSecuredUsingPhysicalMovementInterior = 0,
		LastKnownActionUnsecuredUsingPhysicalMovementInterior,
		LastKnownActionSecuredUsingPhysicalMovementExterior,
		LastKnownActionUnsecuredUsingPhysicalMovementExterior,
		LastKnownActionSecuredWithKeypad,
		LastKnownActionUnsecuredWithKeypad,
		LastKnownActionSecuredRemotely,
		LastKnownActionUnsecuredRemotely,
		LastKnownActionSecuredWithAutomaticSecureTimeout,
		LastKnownActionSecuredUsingPhysicalMovement,
		LastKnownActionUnsecuredUsingPhysicalMovement,
	}

	[MacCatalyst (14, 0)]
	[Native ("HMCharacteristicValueAirParticulateSize")]
	public enum HMCharacteristicValueAirParticulate : long {
		Size2_5 = 0,
		Size10
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCurrentSecuritySystemState : long {
		StayArm = 0,
		AwayArm,
		NightArm,
		Disarmed,
		Triggered
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValuePositionState : long {
		Closing = 0,
		Opening,
		Stopped
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueTargetSecuritySystemState : long {
		StayArm = 0,
		AwayArm,
		NightArm,
		Disarm
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueBatteryStatus : long {
		Normal = 0,
		Low
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueJammedStatus : long {
		None = 0,
		Jammed
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueTamperedStatus : long {
		None = 0,
		Tampered
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueLeakStatus : long {
		None = 0,
		Detected
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueSmokeDetectionStatus : long {
		None = 0,
		Detected
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueChargingState : long {
		None = 0,
		InProgress,
		[Watch (3, 1, 1)]
		NotChargeable,
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueContactState : long {
		Detected = 0,
		None,
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueStatusFault : long {
		NoFault = 0,
		GeneralFault
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCarbonMonoxideDetectionStatus : long {
		NotDetected = 0,
		Detected
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCarbonDioxideDetectionStatus : long {
		NotDetected = 0,
		Detected
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueOccupancyStatus : long {
		NotOccupied = 0,
		Occupied
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueSecuritySystemAlarmType : long {
		NoAlarm = 0,
		Unknown
	}

	// conveniance enum (ObjC uses NSString)
	public enum HMActionSetType {
		Unknown = -1,
		WakeUp,
		Sleep,
		HomeDeparture,
		HomeArrival,
		UserDefined,
		TriggerOwned,
	}

	[MacCatalyst (14, 0)]
	// conveniance enum (ObjC uses NSString)
	public enum HMAccessoryCategoryType {
		[Field ("HMAccessoryCategoryTypeOther")]
		Other = 0,

		[Field ("HMAccessoryCategoryTypeSecuritySystem")]
		SecuritySystem,

		[Field ("HMAccessoryCategoryTypeBridge")]
		Bridge,

		[Field ("HMAccessoryCategoryTypeDoor")]
		Door,

		[Field ("HMAccessoryCategoryTypeDoorLock")]
		DoorLock,

		[Field ("HMAccessoryCategoryTypeFan")]
		Fan,

		[Field ("HMAccessoryCategoryTypeGarageDoorOpener")]
		GarageDoorOpener,

#if !WATCH && !TVOS
		[Obsolete ("Use 'GarageDoorOpener' instead.")]
		[NoTV]
		DoorOpener = GarageDoorOpener,
#endif

		[Field ("HMAccessoryCategoryTypeLightbulb")]
		Lightbulb,

		[Field ("HMAccessoryCategoryTypeOutlet")]
		Outlet,

		[Field ("HMAccessoryCategoryTypeProgrammableSwitch")]
		ProgrammableSwitch,

		[Field ("HMAccessoryCategoryTypeSensor")]
		Sensor,

		[Field ("HMAccessoryCategoryTypeSwitch")]
		Switch,

		[Field ("HMAccessoryCategoryTypeThermostat")]
		Thermostat,

		[Field ("HMAccessoryCategoryTypeWindow")]
		Window,

		[Field ("HMAccessoryCategoryTypeWindowCovering")]
		WindowCovering,

		[Field ("HMAccessoryCategoryTypeRangeExtender")]
		RangeExtender,

		[Field ("HMAccessoryCategoryTypeIPCamera")]
		IPCamera,

		[Field ("HMAccessoryCategoryTypeVideoDoorbell")]
		VideoDoorbell,

		[Watch (3, 1, 1)]
		[Field ("HMAccessoryCategoryTypeAirPurifier")]
		AirPurifier,

		[Watch (3, 1, 1)]
		[Field ("HMAccessoryCategoryTypeAirHeater")]
		AirHeater,

		[Watch (3, 1, 1)]
		[Field ("HMAccessoryCategoryTypeAirConditioner")]
		AirConditioner,

		[Watch (3, 1, 1)]
		[Field ("HMAccessoryCategoryTypeAirHumidifier")]
		AirHumidifier,

		[Watch (3, 1, 1)]
		[Field ("HMAccessoryCategoryTypeAirDehumidifier")]
		AirDehumidifier,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMAccessoryCategoryTypeSprinkler")]
		Sprinkler,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMAccessoryCategoryTypeFaucet")]
		Faucet,

		[Watch (4, 2), TV (11, 2), iOS (11, 2)]
		[Field ("HMAccessoryCategoryTypeShowerHead")]
		ShowerHead,
	}

	[MacCatalyst (14, 0)]
	public enum HMSignificantEvent {

		[Field ("HMSignificantEventSunrise")]
		Sunrise,

		[Field ("HMSignificantEventSunset")]
		Sunset,
	}

	[iOS (13, 0), TV (13, 0), Watch (6, 0), NoMac, MacCatalyst (14, 0)]
	[Flags]
	[Native]
	public enum HMHomeManagerAuthorizationStatus : ulong {
		Determined = 1 << 0,
		Restricted = 1 << 1,
		Authorized = 1 << 2,
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueAirQuality : long {
		Unknown = 0,
		Excellent,
		Good,
		Fair,
		Inferior,
		Poor
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCameraStreamState : ulong {
		Starting = 1,
		Streaming = 2,
		Stopping = 3,
		NotStreaming = 4
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCameraAudioStreamSetting : ulong {
		Muted = 1,
		IncomingAudioAllowed = 2,
		BidirectionalAudioAllowed = 3
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueLockPhysicalControlsState : long {
		NotLocked = 0,
		Locked,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCurrentAirPurifierState : long {
		Inactive = 0,
		Idle,
		Active,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueTargetAirPurifierState : long {
		Manual = 0,
		Automatic,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCurrentSlatState : long {
		Stationary = 0,
		Jammed,
		Oscillating,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueSlatType : long {
		Horizontal = 0,
		Vertical,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueFilterChange : long {
		NotNeeded = 0,
		Needed,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCurrentFanState : long {
		Inactive = 0,
		Idle,
		Active,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueTargetFanState : long {
		Manual = 0,
		Automatic,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCurrentHeaterCoolerState : long {
		Inactive = 0,
		Idle,
		Heating,
		Cooling,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueTargetHeaterCoolerState : long {
		Automatic = 0,
		Heat,
		Cool,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueCurrentHumidifierDehumidifierState : long {
		Inactive = 0,
		Idle,
		Humidifying,
		Dehumidifying,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueTargetHumidifierDehumidifierState : long {
		Automatic = 0,
		Humidify,
		Dehumidify,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueSwingMode : long {
		Disabled = 0,
		Enabled,
	}

	[Watch (3, 1, 1)]
	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueActivationState : long {
		Inactive = 0,
		Active,
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueInputEvent : long {
		SinglePress = 0,
		DoublePress,
		LongPress,
	}

	[MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueLabelNamespace : long {
		Dot = 0,
		Numeral,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0), MacCatalyst (14, 0)]
	[Native]
	public enum HMEventTriggerActivationState : ulong {
		Disabled = 0,
		DisabledNoHomeHub = 1,
		DisabledNoCompatibleHomeHub = 2,
		DisabledNoLocationServicesAuthorization = 3,
		Enabled = 4,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0), MacCatalyst (14, 0)]
	[Native]
	public enum HMHomeHubState : ulong {
		NotAvailable = 0,
		Connected,
		Disconnected,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0), MacCatalyst (14, 0)]
	[Native]
	public enum HMPresenceEventType : ulong {
		EveryEntry = 1,
		EveryExit = 2,
		FirstEntry = 3,
		LastExit = 4,
		AtHome = FirstEntry,
		NotAtHome = LastExit,
	}

	[Watch (4, 0), TV (11, 0), iOS (11, 0), MacCatalyst (14, 0)]
	[Native]
	public enum HMPresenceEventUserType : ulong {
		CurrentUser = 1,
		HomeUsers = 2,
		CustomUsers = 3,
	}

	[Watch (4, 2), TV (11, 2), iOS (11, 2), MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueProgramMode : long {
		NotScheduled = 0,
		Scheduled,
		ScheduleOverriddenToManual,
	}

	[Watch (4, 2), TV (11, 2), iOS (11, 2), MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueUsageState : long {
		NotInUse = 0,
		InUse,
	}

	[Watch (4, 2), TV (11, 2), iOS (11, 2), MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueValveType : long {
		GenericValve = 0,
		Irrigation,
		ShowerHead,
		WaterFaucet,
	}

	[Watch (4, 2), TV (11, 2), iOS (11, 2), MacCatalyst (14, 0)]
	[Native]
	public enum HMCharacteristicValueConfigurationState : long {
		NotConfigured = 0,
		Configured,
	}

	[Introduced (PlatformName.MacCatalyst, 14, 0)]
	[NoMac]
	[Native]
	public enum HMCharacteristicValueTargetDoorState : long {
		Open = 0,
		Closed = 1,
	}

	[Introduced (PlatformName.MacCatalyst, 14, 0)]
	[NoMac]
	[Native]
	public enum HMCharacteristicValueCurrentHeatingCooling : long {
		Off = 0,
		Heat = 1,
		Cool = 2,
	}

	[Introduced (PlatformName.MacCatalyst, 14, 0)]
	[NoMac]
	[Native]
	public enum HMCharacteristicValueTargetLockMechanismState : long {
		Unsecured = 0,
		Secured = 1,
	}
}
