
namespace CoreTelephony {

	[iOS (26, 0), Mac (26, 0), MacCatalyst (26, 0)]
	[Native]
	public enum CTCellularPlanCapability : long {
		Only,
		AndVoice,
	}

	/// <summary>Encapsulates a unique identifier for a call and it's state.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkingInternet/Reference/CTCall/index.html">Apple documentation for <c>CTCall</c></related>
	[MacCatalyst (14, 0)]
	[Deprecated (PlatformName.MacCatalyst, 14, 0, message: Constants.UseCallKitInstead)]
	[Deprecated (PlatformName.iOS, 10, 0, message: Constants.UseCallKitInstead)]
	[BaseType (typeof (NSObject))]
	interface CTCall {
		/// <summary>Developers should not use this deprecated property. Developers should use 'CallKit' instead.</summary>
		[Export ("callID")]
		string CallID { get; }

		/// <summary>Gets the state of the call.</summary>
		[Export ("callState")]
		string CallState { get; }

	}

	/// <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreTelephony/CTCellularData">Apple documentation for <c>CTCellularData</c></related>
	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface CTCellularData {
		/// <summary>Gets or sets the handler for cellular data restriction updates.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed, Export ("cellularDataRestrictionDidUpdateNotifier", ArgumentSemantic.Copy)]
		Action<CTCellularDataRestrictedState> RestrictionDidUpdateNotifier { get; set; }

		/// <summary>Gets the current restricted state of cellular data.</summary>
		[Export ("restrictedState")]
		CTCellularDataRestrictedState RestrictedState { get; }
	}

	/// <summary>Defines constants describing various telephone radio technogies.</summary>
	[MacCatalyst (14, 0)]
	[Static]
	interface CTRadioAccessTechnology {
		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyGPRS</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyGPRS")]
		NSString GPRS { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyEdge</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyEdge")]
		NSString Edge { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyWCDMA</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyWCDMA")]
		NSString WCDMA { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyHSDPA</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyHSDPA")]
		NSString HSDPA { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyHSUPA</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyHSUPA")]
		NSString HSUPA { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMA1x</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyCDMA1x")]
		NSString CDMA1x { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMAEVDORev0</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyCDMAEVDORev0")]
		NSString CDMAEVDORev0 { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMAEVDORevA</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyCDMAEVDORevA")]
		NSString CDMAEVDORevA { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyCDMAEVDORevB</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyCDMAEVDORevB")]
		NSString CDMAEVDORevB { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyeHRPD</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyeHRPD")]
		NSString EHRPD { get; }

		/// <summary>Represents the value associated with the constant CTRadioAccessTechnologyLTE</summary>
		///         <value>
		///         </value>
		[Field ("CTRadioAccessTechnologyLTE")]
		NSString LTE { get; }

		[iOS (14, 1)]
		[MacCatalyst (14, 1)]
		[Field ("CTRadioAccessTechnologyNRNSA")]
		NSString NRNsa { get; }

		[iOS (14, 1)]
		[MacCatalyst (14, 1)]
		[Field ("CTRadioAccessTechnologyNR")]
		NSString NR { get; }
	}

	interface ICTTelephonyNetworkInfoDelegate { }

	[MacCatalyst (14, 0)]
	[iOS (13, 0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface CTTelephonyNetworkInfoDelegate {

		[Export ("dataServiceIdentifierDidChange:")]
		void DataServiceIdentifierDidChange (string identifier);
	}

	/// <summary>A class that holds information on the application user's cellular service provider.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkingInternet/Reference/CTTelephonyNetworkInfo/index.html">Apple documentation for <c>CTTelephonyNetworkInfo</c></related>
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSObject))]
	interface CTTelephonyNetworkInfo {
		/// <summary>Gets the subscriber cellular provider.</summary>
		[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'ServiceSubscriberCellularProviders' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'ServiceSubscriberCellularProviders' instead.")]
		[Export ("subscriberCellularProvider", ArgumentSemantic.Retain)]
		[NullAllowed]
		CTCarrier SubscriberCellularProvider { get; }

		/// <summary>Gets or sets the handler for cellular provider updates.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'ServiceSubscriberCellularProvidersDidUpdateNotifier' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'ServiceSubscriberCellularProvidersDidUpdateNotifier' instead.")]
		[NullAllowed] // by default this property is null
		[Export ("subscriberCellularProviderDidUpdateNotifier")]
		Action<CTCarrier> CellularProviderUpdatedEventHandler { get; set; }

		/// <summary>Gets the current radio access technology.</summary>
		[Deprecated (PlatformName.iOS, 12, 0, message: "Use 'ServiceCurrentRadioAccessTechnology' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'ServiceCurrentRadioAccessTechnology' instead.")]
		[Export ("currentRadioAccessTechnology")]
		[NullAllowed]
		NSString CurrentRadioAccessTechnology { get; }

		/// <summary>Gets the service subscriber cellular providers.</summary>
		[MacCatalyst (14, 0)]
		[Deprecated (PlatformName.iOS, 16, 0)]
		[Deprecated (PlatformName.MacCatalyst, 16, 0)]
		[NullAllowed]
		[Export ("serviceSubscriberCellularProviders", ArgumentSemantic.Retain)]
		NSDictionary<NSString, CTCarrier> ServiceSubscriberCellularProviders { get; }

		/// <summary>Gets the current radio access technology for each service.</summary>
		[MacCatalyst (14, 0)]
		[NullAllowed]
		[Export ("serviceCurrentRadioAccessTechnology", ArgumentSemantic.Retain)]
		NSDictionary<NSString, NSString> ServiceCurrentRadioAccessTechnology { get; }

		/// <summary>Gets or sets the handler for service subscriber updates.</summary>
		[MacCatalyst (14, 0)]
		[Deprecated (PlatformName.iOS, 16, 0)]
		[Deprecated (PlatformName.MacCatalyst, 16, 0)]
		[NullAllowed]
		[Export ("serviceSubscriberCellularProvidersDidUpdateNotifier", ArgumentSemantic.Copy)]
		Action<NSString> ServiceSubscriberCellularProvidersDidUpdateNotifier { get; set; }

		[MacCatalyst (14, 0)]
		[Notification]
		[Field ("CTServiceRadioAccessTechnologyDidChangeNotification")]
		NSString ServiceRadioAccessTechnologyDidChangeNotification { get; }

		[iOS (13, 0)]
		[MacCatalyst (14, 0)]
		[NullAllowed, Export ("dataServiceIdentifier")]
		string DataServiceIdentifier { get; }

		[iOS (13, 0)]
		[MacCatalyst (14, 0)]
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ICTTelephonyNetworkInfoDelegate Delegate { get; set; }

		[iOS (13, 0)]
		[MacCatalyst (14, 0)]
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	/// <summary>Holds a list of current calls and triggers events when their states change.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkingInternet/Reference/CTCallCenter/index.html">Apple documentation for <c>CTCallCenter</c></related>
	[MacCatalyst (14, 0)]
	[Deprecated (PlatformName.MacCatalyst, 14, 0, message: Constants.UseCallKitInstead)]
	[Deprecated (PlatformName.iOS, 10, 0, message: Constants.UseCallKitInstead)]
	[BaseType (typeof (NSObject))]
	interface CTCallCenter {
		/// <summary>Developers should not use this deprecated property. Developers should use 'CallKit' instead.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		[NullAllowed] // by default this property is null
		[Export ("callEventHandler")]
		Action<CTCall> CallEventHandler { get; set; }

		/// <summary>Gets the current active calls.</summary>
		[Export ("currentCalls")]
		[NullAllowed]
		NSSet CurrentCalls { get; }

	}

	/// <summary>Contains information about the application user's home cellular service provider.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/NetworkingInternet/Reference/CTCarrier/index.html">Apple documentation for <c>CTCarrier</c></related>
	[Deprecated (PlatformName.MacCatalyst, 16, 0, message: Constants.UseCallKitInstead)]
	[Deprecated (PlatformName.iOS, 16, 0, message: Constants.UseCallKitInstead)]
	[MacCatalyst (14, 0)]
	[BaseType (typeof (NSObject))]
	interface CTCarrier {
		/// <summary>Gets the mobile country code.</summary>
		[NullAllowed]
		[Export ("mobileCountryCode")]
		string MobileCountryCode { get; }

		/// <summary>Gets the mobile network code.</summary>
		[NullAllowed]
		[Export ("mobileNetworkCode")]
		string MobileNetworkCode { get; }

		/// <summary>Gets the ISO country code.</summary>
		[NullAllowed]
		[Export ("isoCountryCode")]
		string IsoCountryCode { get; }

		/// <summary>Gets whether VoIP is allowed on the carrier.</summary>
		[Export ("allowsVOIP")]
		bool AllowsVoip { get; }

		/// <summary>Gets the carrier name.</summary>
		[NullAllowed]
		[Export ("carrierName")]
		string CarrierName { get; }
	}

	interface ICTSubscriberDelegate { }

	[NoMacCatalyst]
	[Protocol]
	interface CTSubscriberDelegate {
		/// <param name="subscriber">The subscriber whose token was refreshed.</param>
		/// <summary>Called when the subscriber token is refreshed.</summary>
		
		[Abstract]
		[Export ("subscriberTokenRefreshed:")]
		void SubscriberTokenRefreshed (CTSubscriber subscriber);
	}

	/// <summary>Carrier information for a subscriber.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/library/ios/documentation/CoreTelephony/Reference/CTSubscriber/index.html">Apple documentation for <c>CTSubscriber</c></related>
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	partial interface CTSubscriber {
		/// <summary>Gets the carrier token data.</summary>
		[Export ("carrierToken")]
		[NullAllowed]
		NSData CarrierToken { get; }

		/// <summary>Gets the subscriber identifier.</summary>
		[Export ("identifier")]
		string Identifier { get; }

		/// <summary>Gets or sets the weak delegate.</summary>
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		/// <summary>Gets or sets the strongly-typed delegate.</summary>
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		ICTSubscriberDelegate Delegate { get; set; }

		// available since iOS 6 according to the headers
		[Export ("refreshCarrierToken")]
		bool RefreshCarrierToken ();

		[iOS (18, 0)]
		[Export ("SIMInserted")]
		bool IsSimInserted { [Bind ("isSIMInserted")] get; }
	}

	/// <summary>Information on a subscriber to a telephone service.</summary>
	///     
	///     <related type="externalDocumentation" href="https://developer.apple.com/reference/CoreTelephony/CTSubscriberInfo">Apple documentation for <c>CTSubscriberInfo</c></related>
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	partial interface CTSubscriberInfo {
		/// <summary>Gets the subscriber.</summary>
		[Deprecated (PlatformName.iOS, 12, 1, message: "Use 'Subscribers' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 13, 1, message: "Use 'Subscribers' instead.")]
		[Static]
		[Export ("subscriber")]
		CTSubscriber Subscriber { get; }

		/// <summary>Gets all subscribers.</summary>
		[Static]
		[Export ("subscribers")]
		CTSubscriber [] Subscribers { get; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface CTCellularPlanProvisioningRequest : NSSecureCoding {
		/// <summary>Gets or sets the SMDP+ address.</summary>
		[Export ("address")]
		string Address { get; set; }

		/// <summary>Gets or sets the matching identifier.</summary>
		[NullAllowed, Export ("matchingID")]
		string MatchingId { get; set; }

		/// <summary>Gets or sets the OID.</summary>
		[NullAllowed, Export ("OID")]
		string Oid { get; set; }

		/// <summary>Gets or sets the confirmation code.</summary>
		[NullAllowed, Export ("confirmationCode")]
		string ConfirmationCode { get; set; }

		/// <summary>Gets or sets the ICCID.</summary>
		[NullAllowed, Export ("ICCID")]
		string Iccid { get; set; }

		/// <summary>Gets or sets the EID.</summary>
		[NullAllowed, Export ("EID")]
		string Eid { get; set; }
	}

	[MacCatalyst (13, 1)]
	[BaseType (typeof (NSObject))]
	interface CTCellularPlanProvisioning {
		/// <summary>Gets whether the device supports adding a cellular plan.</summary>
		[Export ("supportsCellularPlan")]
		bool SupportsCellularPlan { get; }

		/// <param name="request">The provisioning request.</param>
		/// <param name="completionHandler">The completion handler called with the result.</param>
		/// <summary>Adds a cellular plan with the specified request.</summary>
		[Async (XmlDocs = """
			<param name="request">The provisioning request.</param>
			<summary>Adds a cellular plan with the specified request.</summary>
			<returns>A task representing the asynchronous operation.</returns>
			
			""")]
		[Export ("addPlanWith:completionHandler:")]
		void AddPlan (CTCellularPlanProvisioningRequest request, Action<CTCellularPlanProvisioningAddPlanResult> completionHandler);

		[iOS (16, 0), MacCatalyst (16, 0)]
		[Export ("supportsEmbeddedSIM")]
		bool SupportsEmbeddedSim { get; }

		[Async]
		[NoMacCatalyst] /* headers say yes, but introspection says no, so keep it out of Mac Catalyst for now */
		[NoTV, NoMac, iOS (26, 0)]
		[Export ("addPlanWithRequest:properties:completionHandler:")]
		void AddPlan (CTCellularPlanProvisioningRequest request, [NullAllowed] CTCellularPlanProperties properties, CTCellularPlanProvisioningAddPlanCompletionHandler completionHandler);

		[Async]
		[NoTV, NoMac, iOS (26, 0), MacCatalyst (26, 0)]
		[Export ("updateCellularPlanProperties:completionHandler:")]
		void UpdateCellularPlan (CTCellularPlanProperties properties, CTCellularPlanProvisioningUpdateCellularPlanCompletionHandler completionHandler);
	}

	delegate void CTCellularPlanProvisioningAddPlanCompletionHandler (CTCellularPlanProvisioningAddPlanResult result);
	delegate void CTCellularPlanProvisioningUpdateCellularPlanCompletionHandler ([NullAllowed] NSError error);

	/// <summary>Represents lifecycle properties for a cellular plan.</summary>
	[NoTV, NoMac, iOS (26, 4), MacCatalyst (26, 4)]
	[BaseType (typeof (NSObject))]
	interface CTCellularPlanLifecycleProperties : NSSecureCoding {
		/// <summary>Gets or sets the expiration date of the cellular plan.</summary>
		[Export ("expirationDate", ArgumentSemantic.Assign)]
		NSDateComponents ExpirationDate { get; set; }
	}

	[NoTV, NoMac, iOS (26, 0), MacCatalyst (26, 0)]
	[BaseType (typeof (NSObject))]
	interface CTCellularPlanProperties : NSSecureCoding {
		[NullAllowed, Export ("associatedIccid")]
		string AssociatedIccid { get; set; }

		[Export ("simCapability", ArgumentSemantic.Assign)]
		CTCellularPlanCapability SimCapability { get; set; }

		[Export ("supportedRegionCodes", ArgumentSemantic.Assign)]
		string [] SupportedRegionCodes { get; set; }

		/// <summary>Gets or sets the lifecycle-related properties of the cellular plan.</summary>
		[iOS (26, 4), MacCatalyst (26, 4)]
		[NullAllowed, Export ("lifecycleProperties", ArgumentSemantic.Assign)]
		CTCellularPlanLifecycleProperties LifecycleProperties { get; set; }
	}

	[iOS (26, 0), MacCatalyst (26, 0), NoTV, NoMac]
	[BaseType (typeof (NSObject))]
	interface CTCellularPlanStatus {
		[Async]
		[Static]
		[Export ("getTokenWithCompletion:")]
		void GetToken (CTCellularPlanStatusGetTokenCompletionHandler completionHandler);

		[Async]
		[Static]
		[Export ("checkValidityOfToken:completionHandler:")]
		void CheckValidity (string token, CTCellularPlanStatusCheckValidityCompletionHandler completionHandler);
	}

	delegate void CTCellularPlanStatusGetTokenCompletionHandler ([NullAllowed] string token, [NullAllowed] NSError error);
	delegate void CTCellularPlanStatusCheckValidityCompletionHandler (bool isValid, [NullAllowed] NSError error);
}
