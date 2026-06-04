//
// Enums.cs: Enums definitions for CoreBluetooth
//
// Authors:
//   Miguel de Icaza (miguel@xamarin.com)
//   Marek Safar (marek.safar@gmail.com)
//
// Copyright 2011-2014 Xamarin Inc
//

#nullable enable

namespace CoreBluetooth {

	[MacCatalyst (13, 1)]
	[Native]
	public enum CBManagerState : long {
		/// <summary>Indicates unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates resetting.</summary>
		Resetting,
		/// <summary>Indicates unsupported.</summary>
		Unsupported,
		/// <summary>Indicates unauthorized.</summary>
		Unauthorized,
		/// <summary>Indicates powered off.</summary>
		PoweredOff,
		/// <summary>Indicates powered on.</summary>
		PoweredOn,
	}

	// NSInteger -> CBCentralManager.h
	/// <summary>Enumerates possible states of a <see cref="CoreBluetooth.CBCentralManager" />.</summary>
	[Deprecated (PlatformName.iOS, 10, 0, message: "Use 'CBManagerState' instead.")]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'CBManagerState' instead.")]
	[Native]
	public enum CBCentralManagerState : long {
		/// <summary>Indicates unknown.</summary>
		Unknown = CBManagerState.Unknown,
		/// <summary>Indicates resetting.</summary>
		Resetting = CBManagerState.Resetting,
		/// <summary>Indicates unsupported.</summary>
		Unsupported = CBManagerState.Unsupported,
		/// <summary>Indicates unauthorized.</summary>
		Unauthorized = CBManagerState.Unauthorized,
		/// <summary>Indicates powered off.</summary>
		PoweredOff = CBManagerState.PoweredOff,
		/// <summary>Indicates powered on.</summary>
		PoweredOn = CBManagerState.PoweredOn,
	}

	// NSInteger -> CBPeripheralManager.h
	/// <summary>Enumerates the possible states of the <see cref="CoreBluetooth.CBPeripheralManager" />.</summary>
	[Deprecated (PlatformName.iOS, 10, 0, message: "Use 'CBManagerState' instead.")]
	[MacCatalyst (13, 1)]
	[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'CBManagerState' instead.")]
	[Native]
	public enum CBPeripheralManagerState : long {
		/// <summary>Indicates unknown.</summary>
		Unknown = CBManagerState.Unknown,
		/// <summary>Indicates resetting.</summary>
		Resetting = CBManagerState.Resetting,
		/// <summary>Indicates unsupported.</summary>
		Unsupported = CBManagerState.Unsupported,
		/// <summary>Indicates unauthorized.</summary>
		Unauthorized = CBManagerState.Unauthorized,
		/// <summary>Indicates powered off.</summary>
		PoweredOff = CBManagerState.PoweredOff,
		/// <summary>Indicates powered on.</summary>
		PoweredOn = CBManagerState.PoweredOn,
	}

	// NSInteger -> CBPeripheralManager.h
	/// <summary>Enumerates the possible connection states of a <see cref="CoreBluetooth.CBPeripheral" />.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum CBPeripheralState : long {
		/// <summary>Indicates that the peripheral is not connected.</summary>
		Disconnected,
		/// <summary>Indicates that the peripheral is connecting.</summary>
		Connecting,
		/// <summary>Indicates that the peripheral is connected.</summary>
		Connected,
		/// <summary>Indicates that the peripheral is disconnecting.</summary>
		[MacCatalyst (13, 1)]
		Disconnecting,
	}

	// NSUInteger -> CBCharacteristic.h
	/// <summary>The possible properties of a characteristic. A characteristic may have multiple properties.</summary>
	[MacCatalyst (13, 1)]
	[Flags]
	[Native]
	public enum CBCharacteristicProperties : ulong {
		/// <summary>Indicates broadcast.</summary>
		Broadcast = 1,
		/// <summary>Indicates read.</summary>
		Read = 2,
		/// <summary>Indicates write without response.</summary>
		WriteWithoutResponse = 4,
		/// <summary>Indicates write.</summary>
		Write = 8,
		/// <summary>Indicates notify.</summary>
		Notify = 16,
		/// <summary>Indicates indicate.</summary>
		Indicate = 32,
		/// <summary>Indicates authenticated signed writes.</summary>
		AuthenticatedSignedWrites = 64,
		/// <summary>Indicates extended properties.</summary>
		ExtendedProperties = 128,
		/// <summary>Indicates notify encryption required.</summary>
		[MacCatalyst (13, 1)]
		NotifyEncryptionRequired = 0x100,
		/// <summary>Indicates indicate encryption required.</summary>
		[MacCatalyst (13, 1)]
		IndicateEncryptionRequired = 0x200,
	}

	/// <summary>Errors possible during Bluetooth LE transactions.</summary>
	[MacCatalyst (13, 1)]
	[ErrorDomain ("CBErrorDomain")]
	[Native] // NSInteger -> CBError.h
	public enum CBError : long {
		/// <summary>Indicates none.</summary>
		None = 0,
		/// <summary>Indicates unknown.</summary>
		Unknown = 0,
		/// <summary>Indicates invalid parameters.</summary>
		InvalidParameters,
		/// <summary>Indicates invalid handle.</summary>
		InvalidHandle,
		/// <summary>Indicates not connected.</summary>
		NotConnected,
		/// <summary>Indicates out of space.</summary>
		OutOfSpace,
		/// <summary>Indicates operation cancelled.</summary>
		OperationCancelled,
		/// <summary>Indicates connection timeout.</summary>
		ConnectionTimeout,
		/// <summary>Indicates peripheral disconnected.</summary>
		PeripheralDisconnected,
		/// <summary>Indicates UUID not allowed.</summary>
		UUIDNotAllowed,
		/// <summary>Indicates already advertising.</summary>
		AlreadyAdvertising,
		/// <summary>Indicates connection failed.</summary>
		ConnectionFailed,
		/// <summary>Indicates connection limit reached.</summary>
		ConnectionLimitReached,
		/// <summary>Indicates unknown device.</summary>
		UnknownDevice,
		/// <summary>Indicates operation not supported.</summary>
		OperationNotSupported,
		PeerRemovedPairingInformation,
		EncryptionTimedOut,
		TooManyLEPairedDevices = 16,
		LEGattExceededBackgroundNotificationLimit = 17,
		LEGattNearBackgroundNotificationLimit = 18,
	}

	/// <summary>Errors returned by a GATT server.</summary>
	[MacCatalyst (13, 1)]
	[ErrorDomain ("CBATTErrorDomain")]
	[Native] // NSInteger -> CBError.h
	public enum CBATTError : long {
		/// <summary>Indicates success.</summary>
		Success = 0,
		/// <summary>Indicates invalid handle.</summary>
		InvalidHandle,
		/// <summary>Indicates read not permitted.</summary>
		ReadNotPermitted,
		/// <summary>Indicates write not permitted.</summary>
		WriteNotPermitted,
		/// <summary>Indicates invalid pdu.</summary>
		InvalidPdu,
		/// <summary>Indicates insufficient authentication.</summary>
		InsufficientAuthentication,
		/// <summary>Indicates request not supported.</summary>
		RequestNotSupported,
		/// <summary>Indicates invalid offset.</summary>
		InvalidOffset,
		/// <summary>Indicates insufficient authorization.</summary>
		InsufficientAuthorization,
		/// <summary>Indicates prepare queue full.</summary>
		PrepareQueueFull,
		/// <summary>Indicates attribute not found.</summary>
		AttributeNotFound,
		/// <summary>Indicates attribute not long.</summary>
		AttributeNotLong,
		/// <summary>Indicates insufficient encryption key size.</summary>
		InsufficientEncryptionKeySize,
		/// <summary>Indicates invalid attribute value length.</summary>
		InvalidAttributeValueLength,
		/// <summary>Indicates unlikely error.</summary>
		UnlikelyError,
		/// <summary>Indicates insufficient encryption.</summary>
		InsufficientEncryption,
		/// <summary>Indicates unsupported group type.</summary>
		UnsupportedGroupType,
		/// <summary>Indicates insufficient resources.</summary>
		InsufficientResources,
	}

	// NSInteger -> CBPeripheral.h
	/// <summary>Enumerates the possible types of writes to a characteristic's value.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum CBCharacteristicWriteType : long {
		/// <summary>Indicates with response.</summary>
		WithResponse,
		/// <summary>Indicates without response.</summary>
		WithoutResponse,
	}

	// NSUInteger -> CBCharacteristic.h
	/// <summary>Enumerates the read, write, and encryption permissions for a characteristic's values.</summary>
	[MacCatalyst (13, 1)]
	[Flags]
	[Native]
	public enum CBAttributePermissions : ulong {
		/// <summary>Indicates readable.</summary>
		Readable = 1,
		/// <summary>Indicates writeable.</summary>
		Writeable = 1 << 1,
		/// <summary>Indicates read encryption required.</summary>
		ReadEncryptionRequired = 1 << 2,
		/// <summary>Indicates write encryption required.</summary>
		WriteEncryptionRequired = 1 << 3,
	}

	// NSInteger -> CBPeripheralManager.h
	/// <summary>The connection latency of the <see cref="CoreBluetooth.CBPeripheralManager" />.</summary>
	[MacCatalyst (13, 1)]
	[Native]
	public enum CBPeripheralManagerConnectionLatency : long {
		/// <summary>Indicates low.</summary>
		Low = 0,
		/// <summary>Indicates medium.</summary>
		Medium,
		/// <summary>Indicates high.</summary>
		High,
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum CBConnectionEvent : long {
		Disconnected = 0,
		Connected = 1,
	}

	[Flags, iOS (13, 0), TV (13, 0), NoMac]
	[MacCatalyst (13, 1)]
	[Native]
	public enum CBCentralManagerFeature : ulong {
		ExtendedScanAndConnect = 1uL << 0,
	}

	[iOS (13, 0), TV (13, 0)]
	[MacCatalyst (13, 1)]
	[Native]
	public enum CBManagerAuthorization : long {
		NotDetermined = 0,
		Restricted,
		Denied,
		AllowedAlways,
	}
}
