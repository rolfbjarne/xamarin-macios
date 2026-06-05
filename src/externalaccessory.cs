//
// externalaccessory.cs: API definition for ExternalAccessory binding
//
// Copyright 2012-2014 Xamarin Inc. All rights reserved.
//

using CoreFoundation;
#if !MONOMAC
using UIKit;
#endif

namespace ExternalAccessory {

	/// <summary>Provides information about a connected external accessory.</summary>
		
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EAAccessory_class/index.html">Apple documentation for <c>EAAccessory</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (EAAccessoryDelegate) })]
	// Objective-C exception thrown.  Name: EAAccessoryInitException Reason: -init not supported. EAAccessoryManager is responsible for creating all objects.
	[DisableDefaultCtor]
	interface EAAccessory {
		/// <summary>Gets a Boolean value that tells whether the accessory is connected to the device.</summary>
		[Export ("connected")]
		bool Connected { [Bind ("isConnected")] get; }

		/// <summary>Gets the unique connection identifier.</summary>
		[Export ("connectionID")]
		nuint ConnectionID { get; }

		/// <summary>Gets the accessory display name.</summary>
		[Export ("name")]
		string Name { get; }

		/// <summary>Gets the accessory manufacturer.</summary>
		[Export ("manufacturer")]
		string Manufacturer { get; }

		/// <summary>Gets the model number for the accessory.</summary>
		[Export ("modelNumber")]
		string ModelNumber { get; }

		/// <summary>Gets the serial number of the accessory.</summary>
		[Export ("serialNumber")]
		string SerialNumber { get; }

		/// <summary>Gets the firmware revision for the accessory.</summary>
		[Export ("firmwareRevision")]
		string FirmwareRevision { get; }

		/// <summary>Gets the hardware revision for the accessory.</summary>
		[Export ("hardwareRevision")]
		string HardwareRevision { get; }

		/// <summary>Gets an array of descriptions of supported protocols for the accessory.</summary>
		[Export ("protocolStrings")]
		string [] ProtocolStrings { get; }

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[Export ("delegate", ArgumentSemantic.Assign)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the ExternalAccessory.IEAAccessoryDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the ExternalAccessory.IEAAccessoryDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IEAAccessoryDelegate Delegate { get; set; }

		/// <summary>Gets the connected accessories.</summary>
		[Deprecated (PlatformName.iOS, 13, 0)]
		[Deprecated (PlatformName.TvOS, 13, 0)]
		[Deprecated (PlatformName.MacOSX, 10, 14)]
		[MacCatalyst (13, 1)]
		[Deprecated (PlatformName.MacCatalyst, 13, 1)]
		[Export ("dockType")]
		string DockType { get; }
	}

	interface IEAAccessoryDelegate { }

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface EAAccessoryDelegate {
		/// <param name="accessory">The disconnected accessory.</param>
		/// <summary>Called when an accessory is disconnected.</summary>
		[Export ("accessoryDidDisconnect:"), EventArgs ("EAAccessory", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void Disconnected (EAAccessory accessory);
	}

	[MacCatalyst (13, 1)]
	interface EAAccessoryEventArgs {
		/// <summary>Gets the connected accessories.</summary>
		[Export ("EAAccessoryKey")]
		EAAccessory Accessory { get; }

		/// <summary>Gets the connected accessories.</summary>
		[Export ("EAAccessorySelectedKey")]
		EAAccessory Selected { get; }
	}

	/// <summary>Used to enumerate the external accessories connected.</summary>
		
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EAAccessoryManager_class/index.html">Apple documentation for <c>EAAccessoryManager</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	// Objective-C exception thrown.  Name: EAAccessoryManagerInitException Reason: -init is not supported. Use +sharedAccessoryManager.
	[DisableDefaultCtor]
	interface EAAccessoryManager {
		/// <summary>Gets the name of the accessory.</summary>
		[Static]
		[Export ("sharedAccessoryManager")]
		EAAccessoryManager SharedAccessoryManager { get; }

		/// <summary>Gets the manufacturer of the accessory.</summary>
		[Export ("registerForLocalNotifications")]
		void RegisterForLocalNotifications ();

		/// <summary>Gets the model number of the accessory.</summary>
		[Export ("unregisterForLocalNotifications")]
		void UnregisterForLocalNotifications ();

		/// <summary>Gets the serial number of the accessory.</summary>
		[Export ("connectedAccessories")]
		EAAccessory [] ConnectedAccessories { get; }

		[Field ("EAAccessoryDidConnectNotification")]
		[Notification (typeof (EAAccessoryEventArgs))]
		NSString DidConnectNotification { get; }

		[Field ("EAAccessoryDidDisconnectNotification")]
		[Notification (typeof (EAAccessoryEventArgs))]
		NSString DidDisconnectNotification { get; }

		// [Introduced (PlatformName.MacCatalyst, 14, 0)]
		/// <param name="predicate">
		///   <para>The predicate for filtering, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		///         <param name="completion">
		///   <para>The predicate options, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Shows the Bluetooth accessory picker UI.</summary>
		[NoMacCatalyst] // selector does not respond
		[NoMac]
		[Export ("showBluetoothAccessoryPickerWithNameFilter:completion:")]
		[Async (XmlDocs = """
			<param name="predicate">The predicate for filtering, or <see langword="null" />.</param>
			<summary>Shows the Bluetooth accessory picker UI.</summary>
			<returns>A task that represents the asynchronous ShowBluetoothAccessoryPicker operation</returns>
			<remarks>
			          <para copied="true">The ShowBluetoothAccessoryPickerAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          
			        </remarks>
			""")]
		void ShowBluetoothAccessoryPicker ([NullAllowed] NSPredicate predicate, [NullAllowed] Action<NSError> completion);
	}

	/// <summary>The EASession is used to communicate with the external hardware accessory.</summary>
		
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EASession_class/index.html">Apple documentation for <c>EASession</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	// Objective-C exception thrown.  Name: EASessionInitException Reason: -init not supported. use -initWithAccessory:forProtocol.
	[DisableDefaultCtor]
	interface EASession {
		/// <param name="accessory">The accessory to open the session for.</param>
		/// <param name="protocol">The protocol string to use for the session.</param>
		/// <summary>Creates a new session with the specified accessory and protocol.</summary>
		
		[Export ("initWithAccessory:forProtocol:")]
		NativeHandle Constructor (EAAccessory accessory, string protocol);

		/// <summary>Gets the accessory for this session.</summary>
		[NullAllowed]
		[Export ("accessory")]
		EAAccessory Accessory { get; }

		/// <summary>Gets the protocol string for this session.</summary>
		[NullAllowed]
		[Export ("protocolString")]
		string ProtocolString { get; }

		/// <summary>Gets the input stream for receiving data.</summary>
		[NullAllowed]
		[Export ("inputStream")]
		NSInputStream InputStream { get; }

		/// <summary>Gets the output stream for sending data.</summary>
		[NullAllowed]
		[Export ("outputStream")]
		NSOutputStream OutputStream { get; }
	}

	/// <summary>An MFI Wireless Accessory Configuration accessory that is currently unconfigured.</summary>
		
	/// <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EAWiFiUnconfiguredAccessory_Class/index.html">Apple documentation for <c>EAWiFiUnconfiguredAccessory</c></related>
	[NoMac]
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface EAWiFiUnconfiguredAccessory {
		/// <summary>Gets the name of the accessory.</summary>
		[Export ("name")]
		string Name { get; }

		/// <summary>Gets the protocol string of the accessory.</summary>
		[Export ("manufacturer")]
		string Manufacturer { get; }

		/// <summary>Gets the manufacturer of the accessory.</summary>
		[Export ("model")]
		string Model { get; }

		/// <summary>Gets the model number of the accessory.</summary>
		[Export ("ssid")]
		string Ssid { get; }

		/// <summary>Gets the firmware revision of the accessory.</summary>
		[Export ("macAddress")]
		string MacAddress { get; }

		/// <summary>Gets the hardware revision of the accessory.</summary>
		[Export ("properties")]
		EAWiFiUnconfiguredAccessoryProperties Properties { get; }
	}

	interface IEAWiFiUnconfiguredAccessoryBrowserDelegate { }

	// This class is exposed for tvOS in the headers, but there's no available initializer (so it can't be constructed)
	// The API is also clearly unusable (you can list the unconfigured accessories, but you can't search for them first...)
	/// <summary>Provides the MFI Wireless Accessory Configuration process, including scanning, connecting, and configuring compatible accessories.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EAWiFiUnconfiguredAccessoryBrowser_Class/index.html">Apple documentation for <c>EAWiFiUnconfiguredAccessoryBrowser</c></related>
	[NoTV] // 
	[NoMac]
	[MacCatalyst (13, 1)]
#if TVOS
	[BaseType (typeof (NSObject))]
#else
	[BaseType (typeof (NSObject), Delegates = new string [] { "WeakDelegate" }, Events = new Type [] { typeof (EAWiFiUnconfiguredAccessoryBrowserDelegate) })]
#endif
	// There's a designated initializer, which leads to think that the default ctor
	// should not be used (documentation says nothing).
	[DisableDefaultCtor]
	interface EAWiFiUnconfiguredAccessoryBrowser {

		/// <param name="accessoryBrowserDelegate">
		///   <para>The name of the nib file, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <param name="queue">
		///   <para>The bundle containing the nib, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Creates the view controller from the specified nib and bundle.</summary>
		
		[MacCatalyst (14, 0)] // the headers lie, not usable until at least Mac Catalyst 14.0
		[NoTV]
		[Export ("initWithDelegate:queue:")]
		[DesignatedInitializer] // according to header comment (but not in attributes)
		NativeHandle Constructor ([NullAllowed] IEAWiFiUnconfiguredAccessoryBrowserDelegate accessoryBrowserDelegate, [NullAllowed] DispatchQueue queue);

		/// <summary>An object that can respond to the delegate protocol for this type</summary>
		///         <value>The instance that will respond to events and data requests.</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>   Methods must be decorated with the [Export ("selectorName")] attribute to respond to each method from the protocol.   Alternatively use the Delegate method which is strongly typed and does not require the [Export] attributes on methods.</para>
		///         </remarks>
		[NoTV] // no member is available
		[MacCatalyst (13, 1)]
		[Export ("delegate", ArgumentSemantic.Weak)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		/// <summary>An instance of the ExternalAccessory.IEAWiFiUnconfiguredAccessoryBrowserDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the ExternalAccessory.IEAWiFiUnconfiguredAccessoryBrowserDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[NoTV] // no member is available
		[MacCatalyst (13, 1)]
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IEAWiFiUnconfiguredAccessoryBrowserDelegate Delegate { get; set; }

		/// <summary>Gets or sets whether to show already-paired accessories.</summary>
		[Export ("unconfiguredAccessories", ArgumentSemantic.Copy)]
		NSSet UnconfiguredAccessories { get; }

		/// <param name="predicate">
		///   <para>The filter predicate, or <see langword="null" />.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Gets or sets the predicate for filtering accessories.</summary>
		[MacCatalyst (14, 0)] // the headers lie, not usable until at least Mac Catalyst 14.0
		[NoTV]
		[Export ("startSearchingForUnconfiguredAccessoriesMatchingPredicate:")]
		void StartSearchingForUnconfiguredAccessories ([NullAllowed] NSPredicate predicate);

		/// <summary>Gets the selected accessories.</summary>
		[MacCatalyst (14, 0)] // the headers lie, not usable until at least Mac Catalyst 14.0
		[NoTV]
		[Export ("stopSearchingForUnconfiguredAccessories")]
		void StopSearchingForUnconfiguredAccessories ();

#if !MONOMAC
		/// <param name="accessory">The configured accessory.</param>
		/// <param name="viewController">The Wi-Fi configuration view controller.</param>
		/// <summary>Called when accessory configuration is complete.</summary>
		[MacCatalyst (14, 0)] // the headers lie, not usable until at least Mac Catalyst 14.0
		[NoTV]
		[Export ("configureAccessory:withConfigurationUIOnViewController:")]
		void ConfigureAccessory (EAWiFiUnconfiguredAccessory accessory, UIViewController viewController);
#endif
	}

	/// <summary>Delegate object for <see cref="ExternalAccessory.EAWiFiUnconfiguredAccessoryBrowser" />, providing events related to scanning, connecting, and configuring compatible accessories.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/ExternalAccessory/Reference/EAWiFiUnconfiguredAccessoryBrowserDelegate_Protocol/index.html">Apple documentation for <c>EAWiFiUnconfiguredAccessoryBrowserDelegate</c></related>
	[NoMac]
	[NoTV] // no member is available
	[MacCatalyst (13, 1)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface EAWiFiUnconfiguredAccessoryBrowserDelegate {

		/// <param name="browser">The browser view controller.</param>
		/// <param name="state">The new browser state.</param>
		/// <summary>Called when the browser state changes.</summary>
		[Abstract]
		[Export ("accessoryBrowser:didUpdateState:"), EventArgs ("EAWiFiUnconfiguredAccessory", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DidUpdateState (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessoryBrowserState state);

		/// <param name="browser">The browser view controller.</param>
		/// <param name="accessories">The already-paired accessories.</param>
		/// <summary>Called when already-paired accessories are found.</summary>
		[Abstract]
		[Export ("accessoryBrowser:didFindUnconfiguredAccessories:"), EventArgs ("EAWiFiUnconfiguredAccessoryBrowser", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DidFindUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories);

		/// <param name="browser">The browser view controller.</param>
		/// <param name="accessories">The newly discovered accessories.</param>
		/// <summary>Called when new accessories are discovered.</summary>
		[Abstract]
		[Export ("accessoryBrowser:didRemoveUnconfiguredAccessories:"), EventArgs ("EAWiFiUnconfiguredAccessoryBrowser", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DidRemoveUnconfiguredAccessories (EAWiFiUnconfiguredAccessoryBrowser browser, NSSet accessories);

		/// <param name="browser">The browser view controller.</param>
		/// <param name="accessory">The accessory that was configured.</param>
		/// <param name="status">The configuration status.</param>
		/// <summary>Called when an accessory configuration event occurs.</summary>
		[Abstract]
		[Export ("accessoryBrowser:didFinishConfiguringAccessory:withStatus:"), EventArgs ("EAWiFiUnconfiguredAccessoryDidFinish", XmlDocs = """
			<summary>Event raised by the object.</summary>
			<remarks>If developers do not assign a value to this event, this will reset the value for the WeakDelegate property to an internal handler that maps delegates to events.</remarks>
			""")]
		void DidFinishConfiguringAccessory (EAWiFiUnconfiguredAccessoryBrowser browser, EAWiFiUnconfiguredAccessory accessory, EAWiFiUnconfiguredAccessoryConfigurationStatus status);
	}
}
