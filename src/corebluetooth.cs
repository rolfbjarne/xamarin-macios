//
// corebluetooth.cs: API definitions for CoreBluetooth
//
// Authors:
//   Miguel de Icaza (miguel@xamarin.com)
//   Marek Safar (marek.safar@gmail.com)
//
// Copyright 2011-2013 Xamarin Inc
//
using System.ComponentModel;

using CoreFoundation;

namespace CoreBluetooth {

	/// <summary>Class that uniquely identifies a Bluetooth device.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreBluetooth/CBAttribute">Apple documentation for <c>CBAttribute</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface CBAttribute {
		/// <summary>Gets the UUID of the attribute.</summary>
		[Export ("UUID")]
		CBUUID UUID { get; [NotImplemented] set; }
	}

	/// <summary>Contains options for initializing a Bluetooth central manager.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("CBCentralManager")]
	interface CBCentralInitOptions {
		/// <summary>Gets or sets whether to show a power alert when Bluetooth is off.</summary>
		[Export ("OptionShowPowerAlertKey")]
		bool ShowPowerAlert { get; set; }

		/// <summary>Gets or sets the restore identifier for state restoration.</summary>
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("OptionRestoreIdentifierKey")]
		string RestoreIdentifier { get; set; }
	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreBluetooth/CBManager">Apple documentation for <c>CBManager</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CBManager {
		/// <summary>Gets the current state of the Bluetooth manager.</summary>
		[Export ("state", ArgumentSemantic.Assign)]
		CBManagerState State { get; }

		[Internal]
		[iOS (13, 0)]
		[NoTV]
		[NoMac]
		[MacCatalyst (13, 1)]
		[Export ("authorization", ArgumentSemantic.Assign)]
		CBManagerAuthorization _IAuthorization { get; }

		[Internal]
		[iOS (13, 1)]
		[NoTV]
		[NoMac]
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("authorization", ArgumentSemantic.Assign)]
		CBManagerAuthorization _SAuthorization { get; }

		[TV (13, 0)]
		[NoiOS]
		[NoMacCatalyst]
		[Static]
		[Export ("authorization", ArgumentSemantic.Assign)]
		CBManagerAuthorization Authorization { get; }
	}

	[iOS (13, 0), TV (13, 0), NoMac]
	[MacCatalyst (13, 1)]
	[StrongDictionary ("CBConnectionEventMatchingOptionsKeys")]
	interface CBConnectionEventMatchingOptions {
		NSUuid [] PeripheralUuids { get; set; }
		CBUUID [] ServiceUuids { get; set; }
	}

	[iOS (13, 0), TV (13, 0), NoMac]
	[MacCatalyst (13, 1)]
	[Static]
	[Internal]
	interface CBConnectionEventMatchingOptionsKeys {
		[Field ("CBConnectionEventMatchingOptionPeripheralUUIDs")]
		NSString PeripheralUuidsKey { get; }
		[Field ("CBConnectionEventMatchingOptionServiceUUIDs")]
		NSString ServiceUuidsKey { get; }
	}

	[StrongDictionary ("CBConnectPeripheralOptionsKeys")]
	interface CBConnectPeripheralOptions {
		[MacCatalyst (13, 1)]
		bool NotifyOnConnection { get; set; }
		bool NotifyOnDisconnection { get; set; }
		[MacCatalyst (13, 1)]
		bool NotifyOnNotification { get; set; }
		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		bool EnableTransportBridging { get; set; }
		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		bool RequiresAncs { get; set; }
		[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
		bool EnableAutoReconnect { get; }
	}

	[Static]
	[Internal]
	interface CBConnectPeripheralOptionsKeys {
		[MacCatalyst (13, 1)]
		[Field ("CBConnectPeripheralOptionNotifyOnConnectionKey")]
		NSString NotifyOnConnectionKey { get; }
		[Field ("CBConnectPeripheralOptionNotifyOnDisconnectionKey")]
		NSString NotifyOnDisconnectionKey { get; }
		[MacCatalyst (13, 1)]
		[Field ("CBConnectPeripheralOptionNotifyOnNotificationKey")]
		NSString NotifyOnNotificationKey { get; }
		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Field ("CBConnectPeripheralOptionEnableTransportBridgingKey")]
		NSString EnableTransportBridgingKey { get; }
		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Field ("CBConnectPeripheralOptionRequiresANCS")]
		NSString RequiresAncsKey { get; }
		[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0)]
		[Field ("CBConnectPeripheralOptionEnableAutoReconnect")]
		NSString EnableAutoReconnectKey { get; }
	}

	/// <summary>Represents the local central device in Bluetooth LE.  Use the CBCentralManager to scan, discover and connect to remote peripherals.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBCentralManager_Class/index.html">Apple documentation for <c>CBCentralManager</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBManager), Delegates = new [] { "WeakDelegate" }, Events = new [] { typeof (CBCentralManagerDelegate) })]
	[DisableDefaultCtor] // crash (at dispose time) on OSX
	interface CBCentralManager {

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the CoreBluetooth.ICBCentralManagerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the CoreBluetooth.ICBCentralManagerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		ICBCentralManagerDelegate Delegate { get; set; }

		/// <param name="centralDelegate">
		///           <para>The delegate to receive central manager events.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="queue">
		///           <para>The dispatch queue for callbacks.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="CoreBluetooth.CBCentralManager" /> with the specified central delegate and dispatch queue.</summary>
		
		[Export ("initWithDelegate:queue:")]
		[PostGet ("WeakDelegate")]
		NativeHandle Constructor ([NullAllowed] ICBCentralManagerDelegate centralDelegate, [NullAllowed] DispatchQueue queue);

		/// <param name="centralDelegate">
		///           <para>The delegate to receive central manager events.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="queue">
		///           <para>The dispatch queue for callbacks.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="options">
		///           <para>The initialization options dictionary.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a new <see cref="CoreBluetooth.CBCentralManager" /> with the specified central delegate, dispatch queue, and options.</summary>
		
		[DesignatedInitializer]
		[MacCatalyst (13, 1)]
		[Export ("initWithDelegate:queue:options:")]
		[PostGet ("WeakDelegate")]
		NativeHandle Constructor ([NullAllowed] ICBCentralManagerDelegate centralDelegate, [NullAllowed] DispatchQueue queue, [NullAllowed] NSDictionary options);

		/// <param name="centralDelegate">The delegate to receive central manager events.</param>
		/// <param name="queue">The dispatch queue for callbacks.</param>
		/// <param name="options">The initialization options.</param>
		/// <summary>Creates a new <see cref="CoreBluetooth.CBCentralManager" /> with the specified central delegate, dispatch queue, and options.</summary>
		
		[MacCatalyst (13, 1)]
		[Wrap ("this (centralDelegate, queue, options.GetDictionary ())")]
		NativeHandle Constructor ([NullAllowed] ICBCentralManagerDelegate centralDelegate, [NullAllowed] DispatchQueue queue, CBCentralInitOptions options);

		[Export ("scanForPeripheralsWithServices:options:"), Internal]
		void ScanForPeripherals ([NullAllowed] NSArray serviceUUIDs, [NullAllowed] NSDictionary options);

		/// <summary>Tells the manager to stop scanning for peripherals.</summary>
		[Export ("stopScan")]
		void StopScan ();

		/// <param name="peripheral">Peripheral to connect to.</param>
		///         <param name="options">
		///           <para>Options to configure the peripheral connection, the keys include OptionAllowDuplicatesKey and OptionNotifyOnDisconnectionKey which should contain NSNumbers.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <summary>Connects to the specified peripheral (weakly typed parameter version).</summary>
		///         <remarks>
		///         </remarks>
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("connectPeripheral:options:")]
		void ConnectPeripheral (CBPeripheral peripheral, [NullAllowed] NSDictionary options);

		[Wrap ("ConnectPeripheral (peripheral, options.GetDictionary ())")]
		void ConnectPeripheral (CBPeripheral peripheral, [NullAllowed] CBConnectPeripheralOptions options);

		/// <param name="peripheral">The peripheral to cancel the connection to.</param>
		///         <summary>Cancels an active or pending connection to the specified <paramref name="peripheral" />.</summary>
		[Export ("cancelPeripheralConnection:")]
		void CancelPeripheralConnection (CBPeripheral peripheral);

		/// <summary>Represents the value associated with the constant CBCentralManagerScanOptionAllowDuplicatesKey</summary>
		///         <value>
		///         </value>
		[Field ("CBCentralManagerScanOptionAllowDuplicatesKey")]
		NSString ScanOptionAllowDuplicatesKey { get; }

		/// <summary>Gets the key for the start delay option when connecting to a peripheral.</summary>
		[MacCatalyst (13, 1)]
		[Field ("CBConnectPeripheralOptionStartDelayKey")]
		NSString OptionStartDelayKey { get; }

		/// <summary>Represents the value associated with the constant CBCentralManagerOptionRestoreIdentifierKey</summary>
		///         <value>
		///         </value>
		[Field ("CBCentralManagerOptionRestoreIdentifierKey")]
		[MacCatalyst (13, 1)]
		NSString OptionRestoreIdentifierKey { get; }

		/// <summary>Represents the value associated with the constant CBCentralManagerRestoredStatePeripheralsKey</summary>
		///         <value>
		///         </value>
		[Field ("CBCentralManagerRestoredStatePeripheralsKey")]
		[MacCatalyst (13, 1)]
		NSString RestoredStatePeripheralsKey { get; }

		/// <summary>Represents the value associated with the constant CBCentralManagerRestoredStateScanServicesKey</summary>
		///         <value>
		///         </value>
		[Field ("CBCentralManagerRestoredStateScanServicesKey")]
		[MacCatalyst (13, 1)]
		NSString RestoredStateScanServicesKey { get; }

		/// <summary>Represents the value associated with the constant CBCentralManagerRestoredStateScanOptionsKey</summary>
		///         <value>
		///         </value>
		[Field ("CBCentralManagerRestoredStateScanOptionsKey")]
		[MacCatalyst (13, 1)]
		NSString RestoredStateScanOptionsKey { get; }

		/// <param name="identifiers">The identifiers of the peripherals to retrieve.</param>
		///         <summary>Returns all peripherals that are identified by the specified <paramref name="identifiers" />.</summary>
		/// <returns>An array of peripherals matching the specified identifiers.</returns>
		[MacCatalyst (13, 1)]
		[Export ("retrievePeripheralsWithIdentifiers:")]
		CBPeripheral [] RetrievePeripheralsWithIdentifiers ([Params] NSUuid [] identifiers);

		/// <param name="serviceUUIDs">The service UUIDs to match connected peripherals against.</param>
		///         <summary>Returns all connected peripherals that have services that are identified by the specified <paramref name="serviceUUIDs" />.</summary>
		/// <returns>An array of connected peripherals with matching services.</returns>
		[MacCatalyst (13, 1)]
		[Export ("retrieveConnectedPeripheralsWithServices:")]
		CBPeripheral [] RetrieveConnectedPeripherals ([Params] CBUUID [] serviceUUIDs);

		/// <summary>Represents the value associated with the constant CBCentralManagerOptionShowPowerAlertKey</summary>
		///         <value>
		///         </value>
		[Field ("CBCentralManagerOptionShowPowerAlertKey")]
		[MacCatalyst (13, 1)]
		NSString OptionShowPowerAlertKey { get; }

		[iOS (16, 0), NoMac, TV (16, 0), MacCatalyst (16, 0)]
		[Field ("CBCentralManagerOptionDeviceAccessForMedia")]
		NSString OptionDeviceAccessForMedia { get; }

		/// <summary>Represents the value associated with the constant CBCentralManagerScanOptionSolicitedServiceUUIDsKey</summary>
		///         <value>
		///         </value>
		[Field ("CBCentralManagerScanOptionSolicitedServiceUUIDsKey")]
		[MacCatalyst (13, 1)]
		NSString ScanOptionSolicitedServiceUUIDsKey { get; }

		/// <summary>Gets a Boolean value that tells whether the manager is currently scanning for peripherals.</summary>
		[MacCatalyst (13, 1)]
		[Export ("isScanning")]
		bool IsScanning { get; }

		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Static]
		[Export ("supportsFeatures:")]
		bool SupportsFeatures (CBCentralManagerFeature features);

		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Export ("registerForConnectionEventsWithOptions:")]
		void RegisterForConnectionEvents ([NullAllowed] NSDictionary options);

		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Wrap ("RegisterForConnectionEvents (options.GetDictionary ())")]
		void RegisterForConnectionEvents ([NullAllowed] CBConnectionEventMatchingOptions options);
	}

	[MacCatalyst (13, 1)]
	[StrongDictionary ("AdvertisementDataKeys")]
	interface AdvertisementData {
		/// <summary>Gets or sets the local name of the advertising peripheral.</summary>
		string LocalName { get; set; }
		/// <summary>Gets or sets the manufacturer-specific data.</summary>
		NSData ManufacturerData { get; set; }
		/// <summary>Gets or sets the service-specific data.</summary>
		NSDictionary<CBUUID, NSData> ServiceData { get; set; }
		/// <summary>Gets or sets the advertised service UUIDs.</summary>
		CBUUID [] ServiceUuids { get; set; }
		/// <summary>Gets or sets the overflow service UUIDs.</summary>
		CBUUID [] OverflowServiceUuids { get; set; }
		/// <summary>Gets or sets the transmit power level.</summary>
		NSNumber TxPowerLevel { get; set; }
		/// <summary>Gets or sets whether the peripheral is connectable.</summary>
		bool IsConnectable { get; set; }
		/// <summary>Gets or sets the solicited service UUIDs.</summary>
		CBUUID [] SolicitedServiceUuids { get; set; }
	}

	[MacCatalyst (13, 1)]
	[Static, Internal]
	interface AdvertisementDataKeys {
		[Field ("CBAdvertisementDataLocalNameKey")]
		NSString LocalNameKey { get; }

		[Field ("CBAdvertisementDataManufacturerDataKey")]
		NSString ManufacturerDataKey { get; }

		[Field ("CBAdvertisementDataServiceDataKey")]
		NSString ServiceDataKey { get; }

		[Field ("CBAdvertisementDataServiceUUIDsKey")]
		NSString ServiceUuidsKey { get; }

		[MacCatalyst (13, 1)]
		[Field ("CBAdvertisementDataOverflowServiceUUIDsKey")]
		NSString OverflowServiceUuidsKey { get; }

		[Field ("CBAdvertisementDataTxPowerLevelKey")]
		NSString TxPowerLevelKey { get; }

		[MacCatalyst (13, 1)]
		[Field ("CBAdvertisementDataIsConnectable")]
		NSString IsConnectableKey { get; }

		[MacCatalyst (13, 1)]
		[Field ("CBAdvertisementDataSolicitedServiceUUIDsKey")]
		NSString SolicitedServiceUuidsKey { get; }
	}

	/// <summary>Possible values for the options parameter in calls to <see cref="CoreBluetooth.CBCentralManager.ScanForPeripherals(CoreBluetooth.CBUUID[],Foundation.NSDictionary)" />.</summary>
	[MacCatalyst (13, 1)]
	[StrongDictionary ("PeripheralScanningOptionsKeys")]
	interface PeripheralScanningOptions { }

	[MacCatalyst (13, 1)]
	[StrongDictionary ("RestoredStateKeys")]
	interface RestoredState {
		/// <summary>Gets or sets the restored peripherals.</summary>
		CBPeripheral [] Peripherals { get; set; }
		/// <summary>Gets or sets the restored scan services.</summary>
		CBPeripheral [] ScanServices { get; set; }
		/// <summary>Gets or sets the restored scan options.</summary>
		PeripheralScanningOptions ScanOptions { get; set; }
	}

	[MacCatalyst (13, 1)]
	[Static, Internal]
	interface RestoredStateKeys {
		[MacCatalyst (13, 1)]
		[Field ("CBCentralManagerRestoredStatePeripheralsKey")]
		NSString PeripheralsKey { get; }

		[MacCatalyst (13, 1)]
		[Field ("CBCentralManagerRestoredStateScanServicesKey")]
		NSString ScanServicesKey { get; }

		[MacCatalyst (13, 1)]
		[Field ("CBCentralManagerRestoredStateScanOptionsKey")]
		NSString ScanOptionsKey { get; }
	}

	interface ICBCentralManagerDelegate { }

	/// <summary>Delegate objects for <see cref="CoreBluetooth.CBCentralManager" /> objects.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBCentralManagerDelegate_Protocol/index.html">Apple documentation for <c>CBCentralManagerDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface CBCentralManagerDelegate {
		/// <param name="central">The central manager whose state was updated.</param>
		/// <summary>Called when the central manager state is updated.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Abstract]
		[Export ("centralManagerDidUpdateState:")]
		void UpdatedState (CBCentralManager central);

		/// <param name="central">The central manager that discovered the peripheral.</param>
		/// <param name="peripheral">The discovered peripheral.</param>
		/// <param name="advertisementData">The advertisement data.</param>
		/// <param name="RSSI">The received signal strength indicator.</param>
		/// <summary>Called when a peripheral is discovered during scanning.</summary>
		[Export ("centralManager:didDiscoverPeripheral:advertisementData:RSSI:"), EventArgs ("CBDiscoveredPeripheral", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
#if XAMCORE_5_0
		void DiscoveredPeripheral (CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber rssi);
#else
		void DiscoveredPeripheral (CBCentralManager central, CBPeripheral peripheral, NSDictionary advertisementData, NSNumber RSSI);
#endif

		/// <param name="central">The central manager.</param>
		/// <param name="peripheral">The peripheral that was connected.</param>
		/// <summary>Called when a connection to a peripheral is established.</summary>
		[Export ("centralManager:didConnectPeripheral:"), EventArgs ("CBPeripheral", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void ConnectedPeripheral (CBCentralManager central, CBPeripheral peripheral);

		/// <param name="central">The central manager.</param>
		/// <param name="peripheral">The peripheral that failed to connect.</param>
		/// <param name="error">The error that caused the failure.</param>
		/// <summary>Called when a connection to a peripheral fails.</summary>
		[Export ("centralManager:didFailToConnectPeripheral:error:"), EventArgs ("CBPeripheralError", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void FailedToConnectPeripheral (CBCentralManager central, CBPeripheral peripheral, [NullAllowed] NSError error);

		/// <param name="central">The central manager.</param>
		/// <param name="peripheral">The peripheral that was disconnected.</param>
		/// <param name="error">The error that caused the disconnection, if any.</param>
		/// <summary>Called when a peripheral is disconnected.</summary>
		[Export ("centralManager:didDisconnectPeripheral:error:"), EventArgs ("CBPeripheralError", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DisconnectedPeripheral (CBCentralManager central, CBPeripheral peripheral, [NullAllowed] NSError error);

		/// <param name="central">The central manager.</param>
		/// <param name="dict">The dictionary of restored state.</param>
		/// <summary>Called when the central manager is restored by the system.</summary>
		[Export ("centralManager:willRestoreState:"), EventArgs ("CBWillRestore", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void WillRestoreState (CBCentralManager central, NSDictionary dict);

		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Export ("centralManager:connectionEventDidOccur:forPeripheral:"), EventArgs ("CBPeripheralConnectionEvent")]
		void ConnectionEventDidOccur (CBCentralManager central, CBConnectionEvent connectionEvent, CBPeripheral peripheral);

		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Export ("centralManager:didUpdateANCSAuthorizationForPeripheral:"), EventArgs ("CBAncsAuthorizationUpdate")]
		void DidUpdateAncsAuthorization (CBCentralManager central, CBPeripheral peripheral);

		[iOS (17, 0), TV (17, 0), Mac (14, 0), MacCatalyst (17, 0), EventArgs ("CBPeripheralDiconnectionEvent")]
		[Export ("centralManager:didDisconnectPeripheral:timestamp:isReconnecting:error:")]
		void DidDisconnectPeripheral (CBCentralManager central, CBPeripheral peripheral, double timestamp, bool isReconnecting, [NullAllowed] NSError error);
	}

	/// <summary>Keys used to lookup dictionary values from the NSDictionary received as AParameter in <see cref="CoreBluetooth.CBCentralManagerDelegate.DiscoveredPeripheral(CoreBluetooth.CBCentralManager,CoreBluetooth.CBPeripheral,Foundation.NSDictionary,Foundation.NSNumber)" />.</summary>
	[MacCatalyst (13, 1)]
	[Static]
	interface CBAdvertisement {
		/// <summary>Represents the value associated with the constant CBAdvertisementDataServiceUUIDsKey</summary>
		///         <value>
		///         </value>
		[Field ("CBAdvertisementDataServiceUUIDsKey")]
		NSString DataServiceUUIDsKey { get; }

		/// <summary>Represents the value associated with the constant CBAdvertisementDataLocalNameKey</summary>
		///         <value>
		///         </value>
		[Field ("CBAdvertisementDataLocalNameKey")]
		NSString DataLocalNameKey { get; }

		/// <summary>Represents the value associated with the constant CBAdvertisementDataTxPowerLevelKey</summary>
		///         <value>
		///         </value>
		[Field ("CBAdvertisementDataTxPowerLevelKey")]
		NSString DataTxPowerLevelKey { get; }

		/// <summary>Represents the value associated with the constant CBAdvertisementDataManufacturerDataKey</summary>
		///         <value>
		///         </value>
		[Field ("CBAdvertisementDataManufacturerDataKey")]
		NSString DataManufacturerDataKey { get; }

		/// <summary>Represents the value associated with the constant CBAdvertisementDataServiceDataKey</summary>
		///         <value>
		///         </value>
		[Field ("CBAdvertisementDataServiceDataKey")]
		NSString DataServiceDataKey { get; }

		/// <summary>Represents the value associated with the constant CBAdvertisementDataOverflowServiceUUIDsKey</summary>
		///         <value>
		///         </value>
		[MacCatalyst (13, 1)]
		[Field ("CBAdvertisementDataOverflowServiceUUIDsKey")]
		NSString DataOverflowServiceUUIDsKey { get; }

		/// <summary>Represents the value associated with the constant CBAdvertisementDataIsConnectable</summary>
		///         <value>
		///         </value>
		[MacCatalyst (13, 1)]
		[Field ("CBAdvertisementDataIsConnectable")]
		NSString IsConnectable { get; }

		/// <summary>Represents the value associated with the constant CBAdvertisementDataSolicitedServiceUUIDsKey</summary>
		///         <value>
		///         </value>
		[MacCatalyst (13, 1)]
		[Field ("CBAdvertisementDataSolicitedServiceUUIDsKey")]
		NSString DataSolicitedServiceUUIDsKey { get; }

	}

	/// <summary>Characteristics of a remote peripheral.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBCharacteristic_Class/index.html">Apple documentation for <c>CBCharacteristic</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBAttribute))]
	[DisableDefaultCtor] // crash (at dispose time) on OSX
	interface CBCharacteristic {

		/// <summary>Gets or sets the characteristic properties.</summary>
		[Export ("properties")]
		CBCharacteristicProperties Properties { get; [NotImplemented ("Not available on CBCharacteristic, only available on CBMutableCharacteristic")] set; }

		/// <summary>Gets or sets the characteristic value.</summary>
		[NullAllowed]
		[Export ("value", ArgumentSemantic.Retain)]
		NSData Value { get; [NotImplemented ("Not available on CBCharacteristic, only available on CBMutableCharacteristic")] set; }

		/// <summary>Gets or sets the descriptors for the characteristic.</summary>
		[NullAllowed]
		[Export ("descriptors", ArgumentSemantic.Retain)]
		CBDescriptor [] Descriptors { get; [NotImplemented ("Not available on CBCharacteristic, only available on CBMutableCharacteristic")] set; }

		/// <summary>Developers should not use this deprecated property. </summary>
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("isBroadcasted")]
		bool IsBroadcasted { get; }

		/// <summary>Gets whether notifications are enabled for this characteristic.</summary>
		[Export ("isNotifying")]
		bool IsNotifying { get; }

		/// <summary>Gets the service that owns this characteristic.</summary>
		[NullAllowed]
		[Export ("service", ArgumentSemantic.Weak)]
		CBService Service { get; }
	}

	/// <summary>A mutable <see cref="CoreBluetooth.CBCharacteristic" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBMutableCharacteristic_Class/index.html">Apple documentation for <c>CBMutableCharacteristic</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBCharacteristic))]
	[DisableDefaultCtor]
	interface CBMutableCharacteristic {

		/// <param name="uuid">The UUID for the characteristic.</param>
		/// <param name="properties">The characteristic properties.</param>
		/// <param name="value">
		///           <para>Characteristic value to cache, if null, the value will be loaded on demand.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		/// <summary>Creates a mutable characteristic with the specified UUID, properties, value, and permissions.</summary>
		
		/// <summary>Creates a mutable characteristic with the specified UUID, properties, value, and permissions.</summary>
		
		[NoTV]
		[MacCatalyst (13, 1)]
		[DesignatedInitializer]
		[Export ("initWithType:properties:value:permissions:")]
		[PostGet ("UUID")]
		[PostGet ("Value")]
		NativeHandle Constructor (CBUUID uuid, CBCharacteristicProperties properties, [NullAllowed] NSData value, CBAttributePermissions permissions);

		/// <summary>Gets or sets the attribute permissions.</summary>
		[Export ("permissions", ArgumentSemantic.Assign)]
		CBAttributePermissions Permissions { get; set; }

		/// <summary>Gets or sets the attribute permissions.</summary>
		/// <summary>Gets or sets the characteristic properties.</summary>
		[Override]
		CBCharacteristicProperties Properties { get; set; }

		/// <summary>Gets or sets the characteristic properties.</summary>
		///         <value>
		/// <summary>Gets or sets the characteristic value.</summary>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("value", ArgumentSemantic.Retain)]
		[Override]
		NSData Value { get; set; }

		/// <summary>Gets or sets the characteristic value.</summary>
		///         <value>
		/// <summary>Gets or sets the descriptors for the characteristic.</summary>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed]
		[Export ("descriptors", ArgumentSemantic.Retain)]
		[Override]
		CBDescriptor [] Descriptors { get; set; }

		/// <summary>Gets or sets the descriptors.</summary>
		[Export ("subscribedCentrals")]
		/// <summary>Gets the centrals that are subscribed to notifications.</summary>
		CBCentral [] SubscribedCentrals { get; }
	}

	/// <summary>An immutable description of APeripheral's characteristic. See also <see cref="CoreBluetooth.CBMutableDescriptor" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBDescriptor_Class/index.html">Apple documentation for <c>CBDescriptor</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBAttribute))]
	[DisableDefaultCtor] // crash (at dispose time) on OSX
	interface CBDescriptor {

		/// <summary>Gets the descriptor value.</summary>
		[Export ("value", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSObject Value { get; }

		/// <summary>Gets the characteristic that owns this descriptor.</summary>
		[NullAllowed]
		[Export ("characteristic", ArgumentSemantic.Weak)]
		CBCharacteristic Characteristic { get; }
	}

	/// <summary>A mutable <see cref="CBDescriptor" />.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBMutableDescriptor_Class/index.html">Apple documentation for <c>CBMutableDescriptor</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBDescriptor))]
	[DisableDefaultCtor]
		/// <param name="uuid">The UUID for the descriptor.</param>
		/// <param name="descriptorValue">The value for the descriptor.</param>
		/// <summary>Creates a mutable descriptor with the specified UUID and value.</summary>
		
		
		[NoTV]
		[MacCatalyst (13, 1)]
		[DesignatedInitializer]
		[Export ("initWithType:value:")]
		[PostGet ("UUID")]
		[PostGet ("Value")]
		NativeHandle Constructor (CBUUID uuid, [NullAllowed] NSObject descriptorValue);
	}

	/// <summary>Represents a CoreBluetooth peripheral.</summary>
	///     <remarks>
	///       <para>
	/// 	CBPeripherals represent a remote peripheral that the device
	/// 	has discovered or has discovered and connected to.
	///       </para>
	///     </remarks>
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheral_Class/index.html">Apple documentation for <c>CBPeripheral</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBPeer), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (CBPeripheralDelegate) })]
	[DisableDefaultCtor] // crash (at dispose time) on OSX
	interface CBPeripheral : NSCopying {
		/// <summary>Gets the peripheral name.</summary>
		[Export ("name", ArgumentSemantic.Retain)]
		[NullAllowed]
		string Name { get; }

		/// <summary>Developers should not use this deprecated property. </summary>
		[Deprecated (PlatformName.iOS, 8, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("RSSI", ArgumentSemantic.Retain)]
		[NullAllowed]
		NSNumber RSSI { get; }

		/// <summary>The discovered <see cref="CoreBluetooth.CBService" />s of this peripheral.</summary>
		///         <value>Will be <see langword="null" /> until some time after <see cref="CoreBluetooth.CBPeripheral.DiscoverServices(CoreBluetooth.CBUUID[])" /> is called.</value>
		///         <remarks>
		///           <para>This property is mutated asynchronously subsequent to calls to <see cref="CoreBluetooth.CBPeripheral.DiscoverServices(CoreBluetooth.CBUUID[])" />. Application developers generally override <see cref="CoreBluetooth.CBPeripheralDelegate.DiscoveredService(CoreBluetooth.CBPeripheral,Foundation.NSError)" /> to enumerate services. </para>
		///         </remarks>
		[Export ("services", ArgumentSemantic.Retain)]
		[NullAllowed]
		CBService [] Services { get; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Weak), NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the CoreBluetooth.ICBPeripheralDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the CoreBluetooth.ICBPeripheralDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		ICBPeripheralDelegate Delegate { get; set; }

		/// <summary>Reads the signal strength of the peripheral.</summary>
		[Export ("readRSSI")]
		void ReadRSSI ();

		[Export ("discoverServices:"), Internal]
		void DiscoverServices ([NullAllowed] NSArray serviceUUIDs);

		[Export ("discoverIncludedServices:forService:"), Internal]
		void DiscoverIncludedServices ([NullAllowed] NSArray includedServiceUUIDs, CBService forService);

		[Export ("discoverCharacteristics:forService:"), Internal]
		void DiscoverCharacteristics ([NullAllowed] NSArray characteristicUUIDs, CBService forService);

		/// <param name="characteristic">The characteristic to read the value of.</param>
		///         <summary>Reads the value of the specified <paramref name="characteristic" />.</summary>
		[Export ("readValueForCharacteristic:")]
		void ReadValue (CBCharacteristic characteristic);

		/// <param name="data">The data to write.</param>
		/// <param name="characteristic">The characteristic to write to.</param>
		/// <param name="type">The write type (with or without response).</param>
		///         <summary>Writes <paramref name="data" /> to the specified <paramref name="characteristic" /> with the specified <paramref name="type" />.</summary>
		[Export ("writeValue:forCharacteristic:type:")]
		void WriteValue (NSData data, CBCharacteristic characteristic, CBCharacteristicWriteType type);

		/// <param name="enabled">Whether to enable or disable notifications.</param>
		/// <param name="characteristic">The characteristic to set notifications for.</param>
		///         <summary>Sets the notification status for the specified <paramref name="characteristic" />.</summary>
		[Export ("setNotifyValue:forCharacteristic:")]
		void SetNotifyValue (bool enabled, CBCharacteristic characteristic);

		/// <param name="characteristic">The characteristic to discover descriptors for.</param>
		///         <summary>Finds descriptors for the specified <paramref name="characteristic" />.</summary>
		[Export ("discoverDescriptorsForCharacteristic:")]
		void DiscoverDescriptors (CBCharacteristic characteristic);

		/// <param name="descriptor">The descriptor to read the value of.</param>
		///         <summary>Reads the value of the characteristic that is identified by the specified <paramref name="descriptor" />.</summary>
		[Export ("readValueForDescriptor:")]
		void ReadValue (CBDescriptor descriptor);

		/// <param name="data">The data to write.</param>
		///         <param name="descriptor">The descriptor to use for the data.</param>
		///         <summary>Writes <paramref name="data" /> to the characteristic that is identified by the specified <paramref name="descriptor" />.</summary>
		[Export ("writeValue:forDescriptor:")]
		void WriteValue (NSData data, CBDescriptor descriptor);

		/// <param name="type">The write type (with or without response).</param>
		///         <summary>Gets the maximum write length for data that is written to the values of the specified <paramref name="type" />.</summary>
		/// <returns>The maximum data length for the specified write type.</returns>
		[MacCatalyst (13, 1)]
		[Export ("maximumWriteValueLengthForType:")]
		nuint GetMaximumWriteValueLength (CBCharacteristicWriteType type);

		/// <summary>Gets the connection state for the peripheral.</summary>
		[MacCatalyst (13, 1)]
		[Export ("state")]
		CBPeripheralState State { get; }

		/// <summary>Gets whether the peripheral can send writes without a response.</summary>
		[MacCatalyst (13, 1)]
		[Export ("canSendWriteWithoutResponse")]
		bool CanSendWriteWithoutResponse { get; }

		/// <param name="psm">The PSM of the L2CAP channel to open.</param>
		/// <summary>Opens an L2CAP channel to the peripheral.</summary>
		[MacCatalyst (13, 1)]
		[Export ("openL2CAPChannel:")]
		void OpenL2CapChannel (ushort psm);

		[iOS (13, 0), TV (13, 0), NoMac]
		[MacCatalyst (13, 1)]
		[Export ("ancsAuthorized")]
		bool AncsAuthorized { get; }
	}

	interface ICBPeripheralDelegate { }

	/// <summary>Delegate object for <see cref="CoreBluetooth.CBPeripheral" />. Provides methods called on events relating to discovery, exploration, and interaction with a remote peripheral.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheralDelegate_Protocol/index.html">Apple documentation for <c>CBPeripheralDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface CBPeripheralDelegate {
		/// <param name="peripheral">The peripheral.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when service discovery completes.</summary>
		[Deprecated (PlatformName.MacOSX, 10, 13, message: "Use 'RssiRead' instead.")]
		[Deprecated (PlatformName.iOS, 8, 0, message: "Use 'RssiRead' instead.")]
		[Deprecated (PlatformName.TvOS, 9, 0, message: "Use 'RssiRead' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'RssiRead' instead.")]
		[Export ("peripheralDidUpdateRSSI:error:"), EventArgs ("NSError", true, XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void RssiUpdated (CBPeripheral peripheral, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral.</param>
		/// <param name="rssi">The current RSSI value.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when the RSSI value is read.</summary>
		[MacCatalyst (13, 1)]
		[Export ("peripheral:didReadRSSI:error:"), EventArgs ("CBRssi", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void RssiRead (CBPeripheral peripheral, NSNumber rssi, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when included services are discovered for a service.</summary>
		[Export ("peripheral:didDiscoverServices:"), EventArgs ("NSError", true, XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
#if XAMCORE_5_0
		void DiscoveredServices (CBPeripheral peripheral, [NullAllowed] NSError error);
#else
		void DiscoveredService (CBPeripheral peripheral, [NullAllowed] NSError error);
#endif

		/// <param name="peripheral">The peripheral.</param>
		/// <param name="service">The service whose characteristics were discovered.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when characteristics are discovered for a service.</summary>
		[Export ("peripheral:didDiscoverIncludedServicesForService:error:"), EventArgs ("CBService", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DiscoveredIncludedService (CBPeripheral peripheral, CBService service, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral.</param>
		/// <param name="service">The service whose characteristics were discovered.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when characteristics are discovered for a service.</summary>
		
		[Export ("peripheral:didDiscoverCharacteristicsForService:error:"), EventArgs ("CBService", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DiscoveredCharacteristics (CBPeripheral peripheral, CBService service, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral.</param>
		/// <param name="characteristic">The characteristic whose value was updated.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when a characteristic value is updated.</summary>
		[Export ("peripheral:didUpdateValueForCharacteristic:error:"), EventArgs ("CBCharacteristic", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void UpdatedCharacterteristicValue (CBPeripheral peripheral, CBCharacteristic characteristic, [NullAllowed] NSError error);
		/// <param name="peripheral">The peripheral.</param>
		/// <param name="characteristic">The characteristic whose value was written.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when a characteristic value write completes.</summary>
		/// <summary>Called when a characteristic value write completes.</summary>
		[Export ("peripheral:didWriteValueForCharacteristic:error:"), EventArgs ("CBCharacteristic", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void WroteCharacteristicValue (CBPeripheral peripheral, CBCharacteristic characteristic, [NullAllowed] NSError error);
		/// <param name="peripheral">The peripheral.</param>
		/// <param name="characteristic">The characteristic whose notification state changed.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when the notification state for a characteristic changes.</summary>
		/// <summary>Called when the notification state for a characteristic changes.</summary>
		[Export ("peripheral:didUpdateNotificationStateForCharacteristic:error:"), EventArgs ("CBCharacteristic", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void UpdatedNotificationState (CBPeripheral peripheral, CBCharacteristic characteristic, [NullAllowed] NSError error);
		/// <param name="peripheral">The peripheral.</param>
		/// <param name="characteristic">The characteristic whose descriptors were discovered.</param>
		/// <param name="characteristic">The characteristic whose descriptors were discovered.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when descriptors for a characteristic are discovered.</summary>
		[Export ("peripheral:didDiscoverDescriptorsForCharacteristic:error:"), EventArgs ("CBCharacteristic", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DiscoveredDescriptor (CBPeripheral peripheral, CBCharacteristic characteristic, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral.</param>
		/// <param name="descriptor">The descriptor whose value was updated.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when a descriptor value is updated.</summary>
		[Export ("peripheral:didUpdateValueForDescriptor:error:"), EventArgs ("CBDescriptor", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void UpdatedValue (CBPeripheral peripheral, CBDescriptor descriptor, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral.</param>
		/// <param name="descriptor">The descriptor whose value was written.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when a descriptor value write completes.</summary>
		[Export ("peripheral:didWriteValueForDescriptor:error:"), EventArgs ("CBDescriptor", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void WroteDescriptorValue (CBPeripheral peripheral, CBDescriptor descriptor, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral whose name was updated.</param>
		/// <summary>Called when the peripheral name changes.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("peripheralDidUpdateName:")]
		void UpdatedName (CBPeripheral peripheral);

		/// <param name="peripheral">The peripheral whose services were modified.</param>
		/// <param name="services">The invalidated services.</param>
		/// <summary>Called when services on a peripheral are modified.</summary>
		[Export ("peripheral:didModifyServices:"), EventArgs ("CBPeripheralServices", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void ModifiedServices (CBPeripheral peripheral, CBService [] services);

		/// <param name="peripheral">The peripheral.</param>
		///         <param name="channel">
		///           <para>The opened L2CAP channel, if successful.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">
		///           <para>The error, if any.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Called when an L2CAP channel is opened.</summary>
		[MacCatalyst (13, 1)]
		[EventArgs ("CBPeripheralOpenL2CapChannel", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("peripheral:didOpenL2CAPChannel:error:")]
		void DidOpenL2CapChannel (CBPeripheral peripheral, [NullAllowed] CBL2CapChannel channel, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral that is ready to send.</param>
		/// <summary>Called when the peripheral is ready to send a write without response.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[MacCatalyst (13, 1)]
		[Export ("peripheralIsReadyToSendWriteWithoutResponse:")]
		void IsReadyToSendWriteWithoutResponse (CBPeripheral peripheral);
	}

	/// <summary>Represents the services of a remote peripheral.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBService_Class/index.html">Apple documentation for <c>CBService</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBAttribute))]
	[DisableDefaultCtor] // crash (at dispose time) on OSX
	interface CBService {
		/// <summary>Gets the peer identifier for the peripheral.</summary>
		[MacCatalyst (13, 1)]
		[Export ("isPrimary")]
		bool Primary { get; }

		/// <summary>Gets the maximum amount of data that can be sent in a single write without response.</summary>
		[Export ("includedServices", ArgumentSemantic.Retain)]
		[NullAllowed]
		CBService [] IncludedServices { get; [NotImplemented ("Not available on 'CBService', only available on CBMutableService.")] set; }

		/// <summary>The list of characteristics discovered by this service.</summary>
		/// <value>Array of CBCharacteristic objects.</value>
		/// <remarks>
		///   The contents of this property are only updated after you
		///   have initiated a characteristic discovery using the <see cref="CoreBluetooth.CBPeripheral.DiscoverCharacteristics(CBUUID[],CBService)" />
		///   method.
		/// </remarks>
		[Export ("characteristics", ArgumentSemantic.Retain)]
		[NullAllowed]
		CBCharacteristic [] Characteristics { get; [NotImplemented ("Not available on 'CBService', only available on CBMutableService.")] set; }

		/// <summary>Gets whether the service is a primary service.</summary>
		[NullAllowed]
		[Export ("peripheral", ArgumentSemantic.Weak)]
		CBPeripheral Peripheral { get; }

	}

	/// <summary>A mutable <see cref="CoreBluetooth.CBService" />.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBMutableService_Class/index.html">Apple documentation for <c>CBMutableService</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBService))]
	[DisableDefaultCtor]
	interface CBMutableService {
		/// <param name="uuid">The UUID for the service.</param>
		/// <param name="primary">Whether the service is primary.</param>
		/// <summary>Creates a mutable service with the specified UUID and primary flag.</summary>
		
		[NoTV]
		[MacCatalyst (13, 1)]
		[DesignatedInitializer]
		[Export ("initWithType:primary:")]
		[PostGet ("UUID")]
		NativeHandle Constructor (CBUUID uuid, bool primary);

		/// <summary>Gets or sets the included services.</summary>
		[Export ("includedServices", ArgumentSemantic.Retain)]
		[Override]
		[NullAllowed]
		CBService [] IncludedServices { get; set; }  // TODO: check array type

		/// <summary>Gets or sets the characteristics for the service.</summary>
		[Export ("characteristics", ArgumentSemantic.Retain)]
		[Override]
		[NullAllowed]
		CBCharacteristic [] Characteristics { get; set; }   // TODO: check array type
	}

	/// <summary>Universal Unique Identifiers for the Bluetooth stack.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBUUID_Class/index.html">Apple documentation for <c>CBUUID</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // crash (at dispose time) on OSX
	interface CBUUID : NSCopying {
		/// <summary>Gets the UUID data.</summary>
		[Export ("data")]
		NSData Data { get; }

		/// <param name="theString">The UUID string.</param>
		/// <summary>Creates a CBUUID from a string representation.</summary>
		/// <returns>A new CBUUID instance.</returns>
		[Static]
		[MarshalNativeExceptions]
		[Export ("UUIDWithString:")]
		CBUUID FromString (string theString);

		/// <param name="theData">The UUID data.</param>
		/// <summary>Creates a CBUUID from NSData.</summary>
		/// <returns>A new CBUUID instance.</returns>
		[Static]
		[Export ("UUIDWithData:")]
		CBUUID FromData (NSData theData);

		/// <param name="theUUID">The native UUID to convert.</param>
		/// <summary>Creates a CBUUID from a CFUuid.</summary>
		/// <returns>A new CBUUID instance.</returns>
		[Deprecated (PlatformName.MacOSX, 10, 13)]
		[Deprecated (PlatformName.iOS, 9, 0)]
		[Deprecated (PlatformName.TvOS, 9, 0)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Static]
		[Export ("UUIDWithCFUUID:")]
		CBUUID FromCFUUID (IntPtr theUUID);

		/// <param name="theUUID">The NSUUID to convert.</param>
		/// <summary>Creates a CBUUID from an NSUUID.</summary>
		/// <returns>A new CBUUID instance.</returns>
		[Static]
		[MacCatalyst (13, 1)]
		[Export ("UUIDWithNSUUID:")]
		CBUUID FromNSUuid (NSUuid theUUID);

		/// <summary>Represents the value associated with the constant CBUUIDCharacteristicExtendedPropertiesString</summary>
		///         <value>
		///         </value>
		[Field ("CBUUIDCharacteristicExtendedPropertiesString")]
		NSString CharacteristicExtendedPropertiesString { get; }

		/// <summary>Represents the value associated with the constant CBUUIDCharacteristicUserDescriptionString</summary>
		///         <value>
		///         </value>
		[Field ("CBUUIDCharacteristicUserDescriptionString")]
		NSString CharacteristicUserDescriptionString { get; }

		/// <summary>Represents the value associated with the constant CBUUIDClientCharacteristicConfigurationString</summary>
		///         <value>
		///         </value>
		[Field ("CBUUIDClientCharacteristicConfigurationString")]
		NSString ClientCharacteristicConfigurationString { get; }

		/// <summary>Represents the value associated with the constant CBUUIDServerCharacteristicConfigurationString</summary>
		///         <value>
		///         </value>
		[Field ("CBUUIDServerCharacteristicConfigurationString")]
		NSString ServerCharacteristicConfigurationString { get; }

		/// <summary>Represents the value associated with the constant CBUUIDCharacteristicFormatString</summary>
		///         <value>
		///         </value>
		[Field ("CBUUIDCharacteristicFormatString")]
		NSString CharacteristicFormatString { get; }

		/// <summary>Represents the value associated with the constant CBUUIDCharacteristicAggregateFormatString</summary>
		///         <value>
		///         </value>
		[Field ("CBUUIDCharacteristicAggregateFormatString")]
		NSString CharacteristicAggregateFormatString { get; }

		/// <summary>Represents the value associated with the constant CBUUIDCharacteristicValidRangeString</summary>
		[MacCatalyst (13, 1)]
		[Field ("CBUUIDCharacteristicValidRangeString")]
		NSString CharacteristicValidRangeString { get; }

		[TV (18, 0), Mac (15, 0), iOS (18, 0), MacCatalyst (18, 0)]
		[Field ("CBUUIDCharacteristicObservationScheduleString")]
		NSString CharacteristicObservationScheduleString { get; }

		/// <summary>Gets the maximum write value length with response.</summary>
		[MacCatalyst (13, 1)]
		[Field ("CBUUIDL2CAPPSMCharacteristicString")]
		NSString L2CapPsmCharacteristicString { get; }

		/// <summary>Gets the maximum write value length without response.</summary>
		[MacCatalyst (13, 1)]
		[Export ("UUIDString")]
		string Uuid { get; }
	}

	/// <summary>An Attribute Protocol request for reading or writing.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBATTRequest_class/index.html">Apple documentation for <c>CBATTRequest</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface CBATTRequest {
		/// <summary>Gets the peer that is associated with this L2CAP channel.</summary>
		[Export ("central", ArgumentSemantic.Retain)]
		CBCentral Central { get; }

		/// <summary>Gets the input stream for reading data from the channel.</summary>
		[Export ("characteristic", ArgumentSemantic.Retain)]
		CBCharacteristic Characteristic { get; }

		/// <summary>Gets the output stream for writing data to the channel.</summary>
		[Export ("offset")]
		nint Offset { get; }

		/// <summary>Gets the PSM (Protocol/Service Multiplexer) for the channel.</summary>
		[Export ("value", ArgumentSemantic.Copy)]
		[NullAllowed]
		NSData Value { get; set; }
	}

	/// <summary>Used to identify centrals (that are not the current device).</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBCentral_Class/index.html">Apple documentation for <c>CBCentral</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (CBPeer))]
	// `delloc` a default instance crash applications and a default instance, without the ability to change the UUID, does not make sense
	[DisableDefaultCtor]
	interface CBCentral : NSCopying {
		/// <summary>Gets the state of the peripheral manager.</summary>
		[NoiOS]
		[NoTV]
		[NoMacCatalyst]
		[Export ("identifier")]
		NSUuid Identifier { get; }

		// Introduced with iOS7, but does not have NS_AVAILABLE
		/// <summary>Gets whether the peripheral is currently advertising.</summary>
		[Export ("maximumUpdateValueLength")]
		nuint MaximumUpdateValueLength { get; }
	}

	/// <summary>Manages published services per the <see cref="CBPeripheral" /> device's GATT database.</summary>
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheralManager_Class/index.html">Apple documentation for <c>CBPeripheralManager</c></related>
	[MacCatalyst (13, 1)]
	[DisableDefaultCtor]
	[BaseType (typeof (CBManager), Delegates = new [] { "WeakDelegate" }, Events = new [] { typeof (CBPeripheralManagerDelegate) })]
	interface CBPeripheralManager {

		/// <summary>Default constructor, initializes a new instance of this class.</summary>
		/// <remarks />
		[Export ("init")]
		NativeHandle Constructor ();

		/// <param name="peripheralDelegate">The delegate to receive peripheral manager events.</param>
		/// <param name="queue">
		///           <para>The dispatch queue for callbacks.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a peripheral manager with the specified delegate and queue.</summary>
		
		[NoTV]
		[MacCatalyst (13, 1)]
		[Export ("initWithDelegate:queue:")]
		[PostGet ("WeakDelegate")]
		NativeHandle Constructor ([NullAllowed] ICBPeripheralManagerDelegate peripheralDelegate, [NullAllowed] DispatchQueue queue);

		/// <param name="peripheralDelegate">The delegate to receive peripheral manager events.</param>
		/// <param name="queue">
		///           <para>The dispatch queue for callbacks.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="options">
		///           <para>The initialization options dictionary.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates a peripheral manager with the specified delegate, queue, and options.</summary>
		
		[NoTV]
		[MacCatalyst (13, 1)]
		[DesignatedInitializer]
		[Export ("initWithDelegate:queue:options:")]
		[PostGet ("WeakDelegate")]
		NativeHandle Constructor ([NullAllowed] ICBPeripheralManagerDelegate peripheralDelegate, [NullAllowed] DispatchQueue queue, [NullAllowed] NSDictionary options);

		/// <summary>An instance of the CoreBluetooth.ICBPeripheralManagerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the CoreBluetooth.ICBPeripheralManagerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[NullAllowed]
		[Wrap ("WeakDelegate")]
		ICBPeripheralManagerDelegate Delegate { get; set; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[NullAllowed]
		[Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the desired connection latency.</summary>
		[Export ("isAdvertising")]
		bool Advertising { get; }

		/// <param name="service">The service to add.</param>
		/// <summary>Adds a service to the peripheral manager.</summary>
		[Export ("addService:")]
		void AddService (CBMutableService service);

		/// <param name="service">The service to remove.</param>
		/// <summary>Removes a service from the peripheral manager.</summary>
		[Export ("removeService:")]
		void RemoveService (CBMutableService service);

		/// <summary>Removes all published services.</summary>
		[Export ("removeAllServices")]
		void RemoveAllServices ();

		/// <param name="request">The ATT request to respond to.</param>
		/// <param name="result">The result code for the response.</param>
		/// <summary>Responds to a read or write request.</summary>
		[Export ("respondToRequest:withResult:")]
		void RespondToRequest (CBATTRequest request, CBATTError result); // TODO: Could it return CBATTError?. This won't work because it's a value

		/// <param name="options">
		///           <para>The advertisement data dictionary.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Starts advertising the peripheral.</summary>
		[Export ("startAdvertising:")]
		void StartAdvertising ([NullAllowed] NSDictionary options);

		/// <param name="options">
		///           <para>Weakly typed set of options to advertise.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Stops advertising the peripheral.</summary>
		[Wrap ("StartAdvertising (options.GetDictionary ())")]
		void StartAdvertising ([NullAllowed] StartAdvertisingOptions options);

		/// <summary>Gets the key for the start advertising peripheral data option.</summary>
		[Export ("stopAdvertising")]
		void StopAdvertising ();

		/// <param name="latency">The desired connection latency.</param>
		/// <param name="connectedCentral">The central to set the latency for.</param>
		/// <summary>Sets the desired connection latency for a connected central.</summary>
		[Export ("setDesiredConnectionLatency:forCentral:")]
		void SetDesiredConnectionLatency (CBPeripheralManagerConnectionLatency latency, CBCentral connectedCentral);

		/// <param name="value">The updated value data.</param>
		/// <param name="characteristic">The characteristic whose value changed.</param>
		///         <param name="subscribedCentrals">
		///           <para>The centrals to notify, or <see langword="null" /> for all subscribed centrals.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Sends an updated characteristic value to subscribed centrals.</summary>
		/// <returns><see langword="true" /> if the value was queued for delivery; otherwise, <see langword="false" />.</returns>
		[Export ("updateValue:forCharacteristic:onSubscribedCentrals:")]
		bool UpdateValue (NSData value, CBMutableCharacteristic characteristic, [NullAllowed] CBCentral [] subscribedCentrals);

		/// <param name="encryptionRequired">Whether encryption is required.</param>
		/// <summary>Publishes an L2CAP channel with the specified encryption requirement.</summary>
		[MacCatalyst (13, 1)]
		[Export ("publishL2CAPChannelWithEncryption:")]
		void PublishL2CapChannel (bool encryptionRequired);

		/// <param name="psm">The PSM of the channel to unpublish.</param>
		/// <summary>Unpublishes a previously published L2CAP channel.</summary>
		[MacCatalyst (13, 1)]
		[Export ("unpublishL2CAPChannel:")]
		void UnpublishL2CapChannel (ushort psm);

		/// <summary>Represents the value associated with the constant CBPeripheralManagerOptionShowPowerAlertKey</summary>
		///         <value>
		///         </value>
		[Field ("CBPeripheralManagerOptionShowPowerAlertKey")]
		NSString OptionShowPowerAlertKey { get; }

		/// <summary>Represents the value associated with the constant CBPeripheralManagerOptionRestoreIdentifierKey</summary>
		///         <value>
		///         </value>
		[Field ("CBPeripheralManagerOptionRestoreIdentifierKey")]
		NSString OptionRestoreIdentifierKey { get; }

		/// <summary>Represents the value associated with the constant CBPeripheralManagerRestoredStateServicesKey</summary>
		///         <value>
		///         </value>
		[Field ("CBPeripheralManagerRestoredStateServicesKey")]
		NSString RestoredStateServicesKey { get; }

		/// <summary>Represents the value associated with the constant CBPeripheralManagerRestoredStateAdvertisementDataKey</summary>
		///         <value>
		///         </value>
		[Field ("CBPeripheralManagerRestoredStateAdvertisementDataKey")]
		NSString RestoredStateAdvertisementDataKey { get; }
	}

	interface ICBPeripheralManagerDelegate { }

	/// <summary>Delegate object for <see cref="CoreBluetooth.CBPeripheralManager" />. Adds methods for events relating to availability, publishing, advertising, and subscription.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreBluetooth/Reference/CBPeripheralManagerDelegate_Protocol/index.html">Apple documentation for <c>CBPeripheralManagerDelegate</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface CBPeripheralManagerDelegate {
		/// <param name="peripheral">The peripheral manager.</param>
		/// <summary>Called when the peripheral manager state is updated.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Abstract]
		[Export ("peripheralManagerDidUpdateState:")]
		void StateUpdated (CBPeripheralManager peripheral);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="dict">The restored state dictionary.</param>
		/// <summary>Called when the peripheral manager is restored by the system.</summary>
		[Export ("peripheralManager:willRestoreState:"), EventArgs ("CBWillRestore", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void WillRestoreState (CBPeripheralManager peripheral, NSDictionary dict);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when advertising starts or fails.</summary>
		[Export ("peripheralManagerDidStartAdvertising:error:"), EventArgs ("NSError", true, XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void AdvertisingStarted (CBPeripheralManager peripheral, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="service">The service that was added.</param>
		/// <param name="error">The error, if any.</param>
		/// <summary>Called when a service is added to the peripheral manager.</summary>
		[Export ("peripheralManager:didAddService:error:"), EventArgs ("CBPeripheralManagerService", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void ServiceAdded (CBPeripheralManager peripheral, CBService service, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="central">The central that subscribed.</param>
		/// <param name="characteristic">The characteristic that was subscribed to.</param>
		/// <summary>Called when a central subscribes to a characteristic.</summary>
		[Export ("peripheralManager:central:didSubscribeToCharacteristic:"), EventArgs ("CBPeripheralManagerSubscription", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void CharacteristicSubscribed (CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="central">The central that unsubscribed.</param>
		/// <param name="characteristic">The characteristic that was unsubscribed from.</param>
		/// <summary>Called when a central unsubscribes from a characteristic.</summary>
		[Export ("peripheralManager:central:didUnsubscribeFromCharacteristic:"), EventArgs ("CBPeripheralManagerSubscription", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void CharacteristicUnsubscribed (CBPeripheralManager peripheral, CBCentral central, CBCharacteristic characteristic);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="request">The read request from a central.</param>
		/// <summary>Called when a read request is received from a connected central.</summary>
		[Export ("peripheralManager:didReceiveReadRequest:"), EventArgs ("CBATTRequest", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void ReadRequestReceived (CBPeripheralManager peripheral, CBATTRequest request);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="requests">The write requests from a central.</param>
		/// <summary>Called when write requests are received from a connected central.</summary>
		[Export ("peripheralManager:didReceiveWriteRequests:"), EventArgs ("CBATTRequests", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void WriteRequestsReceived (CBPeripheralManager peripheral, CBATTRequest [] requests);

		/// <param name="peripheral">The peripheral manager that is ready to send.</param>
		/// <summary>Called when the peripheral manager is ready to send characteristic value updates.</summary>
		[EventArgs ("", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("peripheralManagerIsReadyToUpdateSubscribers:")]
		void ReadyToUpdateSubscribers (CBPeripheralManager peripheral);

		/// <param name="peripheral">The peripheral manager.</param>
		///         <param name="channel">
		///           <para>The opened L2CAP channel, if successful.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="error">
		///           <para>The error, if any.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Called when an L2CAP channel is opened.</summary>
		[MacCatalyst (13, 1)]
		[EventArgs ("CBPeripheralManagerOpenL2CapChannel", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("peripheralManager:didOpenL2CAPChannel:error:")]
		void DidOpenL2CapChannel (CBPeripheralManager peripheral, [NullAllowed] CBL2CapChannel channel, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="psm">The PSM of the published channel.</param>
		///         <param name="error">
		///           <para>The error, if any.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Called when an L2CAP channel is published.</summary>
		[MacCatalyst (13, 1)]
		[EventArgs ("CBPeripheralManagerL2CapChannelOperation", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("peripheralManager:didUnpublishL2CAPChannel:error:")]
		void DidUnpublishL2CapChannel (CBPeripheralManager peripheral, ushort psm, [NullAllowed] NSError error);

		/// <param name="peripheral">The peripheral manager.</param>
		/// <param name="psm">The PSM of the unpublished channel.</param>
		///         <param name="error">
		///           <para>The error, if any.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Called when an L2CAP channel is unpublished.</summary>
		[MacCatalyst (13, 1)]
		[EventArgs ("CBPeripheralManagerL2CapChannelOperation", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		[Export ("peripheralManager:didPublishL2CAPChannel:error:")]
		void DidPublishL2CapChannel (CBPeripheralManager peripheral, ushort psm, [NullAllowed] NSError error);
	}

	/// <summary>Class that represents a central or perhipheral Bluetooth device.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreBluetooth/CBPeer">Apple documentation for <c>CBPeer</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // CBPeer.h: - (instancetype)init NS_UNAVAILABLE;
	interface CBPeer : NSCopying {
		/// <summary>Gets the value of the read request characteristic.</summary>
		[Export ("identifier")]
		NSUuid Identifier { get; }
	}

	// The type is available in 32bits macOS 10.13 even if most properties are 64 bits only
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Name = "CBL2CAPChannel")]
	interface CBL2CapChannel {

		/// <summary>Gets the central that issued the request.</summary>
		[Export ("peer")]
		CBPeer Peer { get; }

		/// <summary>Gets the characteristic for the request.</summary>
		[Export ("inputStream")]
		NSInputStream InputStream { get; }

		/// <summary>Gets the offset for reading or writing the value.</summary>
		[Export ("outputStream")]
		NSOutputStream OutputStream { get; }

		/// <summary>Gets or sets the value to write to the characteristic.</summary>
		[Export ("PSM")]
		/* uint16_t */
		ushort Psm { get; }
	}
}
