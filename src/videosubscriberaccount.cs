//
// VideoSubscriberAccount bindings
//
// Authors:
//	Alex Soto  <alex.soto@xamarin.com>
//
// Copyright 2016 Xamarin Inc. All rights reserved.
// Copyright 2018-2019 Microsoft Corporation.
//

using System.ComponentModel;
#if MONOMAC
using UIViewController = AppKit.NSViewController;
#else
using UIKit;
#endif

namespace VideoSubscriberAccount {
	[TV (26, 0), NoMacCatalyst, Mac (26, 0), iOS (26, 0)]
	[Native]
	public enum VSAutoSignInAuthorization : long {
		NotDetermined = 0,
		Granted,
		Denied,
	}

	/// <summary>Encapsulates errors that may occur during attempts to verify credentials.</summary>
	[Native]
	[NoMacCatalyst]
	[ErrorDomain ("VSErrorDomain")]
	public enum VSErrorCode : long {
		/// <summary>The user has not affirmatively provided access.</summary>
		AccessNotGranted = 0,
		/// <summary>The requested provider is not supported.</summary>
		UnsupportedProvider = 1,
		/// <summary>The application cancelled the request.</summary>
		UserCancelled = 2,
		/// <summary>A transient error has occurred.</summary>
		ServiceTemporarilyUnavailable = 3,
		/// <summary>To be added.</summary>
		ProviderRejected = 4,
		/// <summary>The provider does not recognize the verification token provided by the app.</summary>
		InvalidVerificationToken = 5,
		Rejected = 6,
		Unsupported = 7,
	}

	/// <summary>Enumerates the types of access the app has to the user's subscription.</summary>
	[Native]
	[NoMacCatalyst]
	public enum VSAccountAccessStatus : long {
		/// <summary>The user has not interacted with the permissions dialog.</summary>
		NotDetermined = 0,
		/// <summary>The user is denied access and may not change permission.</summary>
		Restricted = 1,
		/// <summary>The user has denied the app access.</summary>
		Denied = 2,
		/// <summary>The user has granted the app access.</summary>
		Granted = 3,
	}

#if !XAMCORE_5_0
	[EditorBrowsable (EditorBrowsableState.Never)]
	[Obsolete ("Use 'VSUserAccountQueryOptions' instead.")]
	[TV (16, 0), Mac (13, 0), iOS (16, 0), NoMacCatalyst]
	[Native]
	enum VSUserAccountQueryOption : ulong {
		None = 0,
		AllDevices,
	}
#endif // !XAMCORE_5_0

	[TV (16, 0), NoMacCatalyst, iOS (16, 0), Mac (13, 0)]
	[Flags]
	[Native]
	public enum VSUserAccountQueryOptions : long {
		None = 0x0,
		AllDevices,
	}

	[TV (16, 0), NoMacCatalyst, iOS (16, 0), Mac (13, 0)]
	[Native]
	public enum VSUserAccountType : long {
		Free,
		Paid,
	}

	[TV (16, 0), NoMacCatalyst, iOS (16, 0), Mac (13, 0)]
	[Native]
	public enum VSOriginatingDeviceCategory : long {
		Mobile,
		Other,
	}


	[NoMacCatalyst]
	[Static]
	[Internal]
	interface VSErrorInfoKeys {

		[Field ("VSErrorInfoKeySAMLResponse")]
		NSString SamlResponseKey { get; }

		[Field ("VSErrorInfoKeySAMLResponseStatus")]
		NSString SamlResponseStatusKey { get; }

		[Field ("VSErrorInfoKeyUnsupportedProviderIdentifier")]
		NSString UnsupportedProviderIdentifierKey { get; }

		[Field ("VSErrorInfoKeyAccountProviderResponse")]
		NSString AccountProviderResponseKey { get; }
	}

	[NoMacCatalyst]
	[StrongDictionary ("VSErrorInfoKeys")]
	interface VSErrorInfo {

		/// <summary>Gets the SAML response string from the error info.</summary>
		/// <value>The SAML response string.</value>
		
		string SamlResponse { get; }

		/// <summary>Gets the SAML response status string from the error info.</summary>
		/// <value>The SAML response status string.</value>
		
		string SamlResponseStatus { get; }

		/// <summary>Gets the identifier of the unsupported provider.</summary>
		/// <value>The unsupported provider identifier string.</value>
		
		string UnsupportedProviderIdentifier { get; }

		/// <summary>Gets the account provider response from the error info.</summary>
		/// <value>The account provider response string.</value>
		
		string AccountProviderResponse { get; }
	}

	interface IVSAccountManagerDelegate { }

	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/videosubscriberaccount/vsaccountmanagerdelegate">Apple documentation for <c>VSAccountManagerDelegate</c></related>
	[Protocol, Model]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface VSAccountManagerDelegate {

		/// <param name="accountManager">The account manager.</param>
		/// <param name="viewController">The view controller to present.</param>
		///         <summary>Developers override this to specify the <see cref="UIKit.UIViewController" /> to be shown when the <see cref="VSAccountManager" /> requires user interaction.</summary>
		
		[Abstract]
		[NoMac]
		[Export ("accountManager:presentViewController:")]
		void PresentViewController (VSAccountManager accountManager, UIViewController viewController);

		/// <param name="accountManager">The account manager.</param>
		/// <param name="viewController">The view controller to dismiss.</param>
		///         <summary>Called after the user has interacted with the <paramref name="viewController" />.</summary>
		
		[Abstract]
		[NoMac]
		[Export ("accountManager:dismissViewController:")]
		void DismissViewController (VSAccountManager accountManager, UIViewController viewController);

		/// <param name="accountManager">The account manager.</param>
		/// <param name="accountProviderIdentifier">The identifier of the account provider.</param>
		/// <summary>Called to determine whether the specified provider should be authenticated.</summary>
		/// <returns><see langword="true" /> if the provider should be authenticated; otherwise, <see langword="false" />.</returns>
		
		[Export ("accountManager:shouldAuthenticateAccountProviderWithIdentifier:")]
		bool ShouldAuthenticateAccountProvider (VSAccountManager accountManager, string accountProviderIdentifier);
	}

	/// <summary>Coordinates access to the user's subscription.</summary>
	///     
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/videosubscriberaccount/vsaccountmanager">Apple documentation for <c>VSAccountManager</c></related>
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface VSAccountManager {

		/// <summary>An instance of the VideoSubscriberAccount.IVSAccountManagerDelegate model class which acts as the class delegate.</summary>
		///         <value>The instance of the VideoSubscriberAccount.IVSAccountManagerDelegate model class</value>
		///         <remarks>
		///           <para>The delegate instance assigned to this object will be used to handle events or provide data on demand to this class.</para>
		///           <para>When setting the Delegate or WeakDelegate values events will be delivered to the specified instance instead of being delivered to the C#-style events</para>
		///           <para>This is the strongly typed version of the object, developers should use the WeakDelegate property instead if they want to merely assign a class derived from NSObject that has been decorated with [Export] attributes.</para>
		///         </remarks>
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IVSAccountManagerDelegate Delegate { get; set; }

		/// <summary>Checks whether the user has provided permission for the app to access their subscription information.</summary>
		/// <param name="options">If not empty, may contain the key <see cref="VideoSubscriberAccount.VSCheckAccessOptionKeys" />.</param>
		/// <param name="completionHandler">Called by the system with the results of the permission check.</param>
		[NoMac]
		[Async (XmlDocs = """
			<summary>Checks whether the user has provided permission for the app to access their subscription information.</summary>
			<param name="options">If not empty, may contain the key <see cref="VideoSubscriberAccount.VSCheckAccessOptionKeys" />.</param>
			<returns>
			  <para class="improve-task-t-return-type-description">A task that represents the asynchronous CheckAccessStatus operation.  The value of the TResult parameter is of type System.Action&lt;VideoSubscriberAccount.VSAccountAccessStatus,Foundation.NSError&gt;.</para>
			</returns>
			""")]
		[Export ("checkAccessStatusWithOptions:completionHandler:")]
		void CheckAccessStatus (NSDictionary options, Action<VSAccountAccessStatus, NSError> completionHandler);

		/// <param name="accountMetadataRequest">The metadata request to enqueue.</param>
		/// <param name="completionHandler">Called with the metadata result or error.</param>
		/// <summary>Enqueues a request for account metadata.</summary>
		/// <returns>A result object that can be used to cancel the request.</returns>
		
		[NoMac]
		[Async (XmlDocs = """
			<param name="accountMetadataRequest">The metadata request to enqueue.</param>
			<summary>Enqueues a request for account metadata.</summary>
			<returns>
			          <para class="improve-task-t-return-type-description">A task that represents the asynchronous Enqueue operation.  The value of the TResult parameter is of type System.Action&lt;VideoSubscriberAccount.VSAccountMetadata,Foundation.NSError&gt;.</para>
			        </returns>
			<remarks>
			          <para copied="true">The EnqueueAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			          <para copied="true">The EnqueueAsync method is suitable to be used with C# async by returning control to the caller with a Task representing the operation.</para>
			        </remarks>
			""",
			XmlDocsWithOutParameter = """
			<param name="accountMetadataRequest">The metadata request to enqueue.</param>
			<param name="result">The result object that can cancel the request.</param>
			<summary>Enqueues a request for account metadata.</summary>
			<returns>A task that represents the asynchronous enqueue operation.</returns>
			
			""")]
		[Export ("enqueueAccountMetadataRequest:completionHandler:")]
		VSAccountManagerResult Enqueue (VSAccountMetadataRequest accountMetadataRequest, Action<VSAccountMetadata, NSError> completionHandler);

		[NoMac]
		[TV (13, 0)]
		[iOS (13, 0)]
		[Field ("VSOpenTVProviderSettingsURLString")]
		NSString OpenTVProviderSettingsUrl { get; }
	}

	[Static]
	[NoMacCatalyst]
	interface VSCheckAccessOptionKeys {

		[Field ("VSCheckAccessOptionPrompt")]
		NSString CheckAccessOptionPrompt { get; }
	}

#if !__MACOS__
	/// <summary>
	///    A <see cref="Foundation.DictionaryContainer" /> holding keys appropriate to <see cref="VSAccountManager.CheckAccessStatus(VSAccountManagerAccessOptions,Action{VSAccountAccessStatus,NSError})" />
	///    and <see cref="VSAccountManager.CheckAccessStatusAsync(VSAccountManagerAccessOptions)" />.
	/// </summary>
#endif
	[NoMacCatalyst]
	[StrongDictionary ("VSCheckAccessOptionKeys")]
	interface VSAccountManagerAccessOptions {

		/// <summary>If not <see langword="null" />, specifies whether the user should be asked for access permission.</summary>
		[Export ("CheckAccessOptionPrompt")]
		bool CheckAccessOptionPrompt { get; set; }
	}

	/// <summary>Represents a cancellable request that is still "in flight".</summary>
	///     
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/videosubscriberaccount/vsaccountmanagerresult">Apple documentation for <c>VSAccountManagerResult</c></related>
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSAccountManagerResult {

		/// <summary>Informs the <see cref="VSAccountManager" /> that the app no longer needs the requested work.</summary>
		
		[Export ("cancel")]
		void Cancel ();
	}

	/// <summary>Information about a subscription.</summary>
	///     
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/videosubscriberaccount/vsaccountmetadata">Apple documentation for <c>VSAccountMetadata</c></related>
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface VSAccountMetadata {

		/// <summary>A unique identifier for the account provider.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("accountProviderIdentifier")]
		string AccountProviderIdentifier { get; }

		/// <summary>When the user will be asked to re-authenticate.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("authenticationExpirationDate", ArgumentSemantic.Copy)]
		NSDate AuthenticationExpirationDate { get; }

		/// <summary>Arbitrary data, for instance to hold cryptographic verify the <see cref="VideoSubscriberAccount.VSAccountMetadata.SamlAttributeQueryResponse" />.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("verificationData", ArgumentSemantic.Copy)]
		NSData VerificationData { get; }

		/// <summary>If not <see langword="null" />, the SAML AttributeQuery response from the provider.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("SAMLAttributeQueryResponse")]
		string SamlAttributeQueryResponse { get; }

		/// <summary>Gets the response from the account provider.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("accountProviderResponse", ArgumentSemantic.Strong)]
		VSAccountProviderResponse AccountProviderResponse { get; }
	}

	/// <summary>Specifies information being requested from the subscriber's account.</summary>
	///     
	/// <related type="externalDocumentation" href="https://developer.apple.com/documentation/videosubscriberaccount/vsaccountmetadatarequest">Apple documentation for <c>VSAccountMetadataRequest</c></related>
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface VSAccountMetadataRequest {

		/// <summary>If not <see langword="null" />, identifies the source of the request.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("channelIdentifier")]
		string ChannelIdentifier { get; set; }

		/// <summary>If not empty, a list of provider identifiers that are allowed to respond to the request.</summary>
		/// <value>An array of supported provider identifiers.</value>
		
		[Export ("supportedAccountProviderIdentifiers", ArgumentSemantic.Copy)]
		string [] SupportedAccountProviderIdentifiers { get; set; }

		/// <summary>Gets or sets the list of featured account provider identifiers.</summary>
		/// <value>An array of featured provider identifiers.</value>
		
		[Export ("featuredAccountProviderIdentifiers", ArgumentSemantic.Copy)]
		string [] FeaturedAccountProviderIdentifiers { get; set; }

		/// <summary>If not <see langword="null" />, a value that the provider requires to verify the identity of the requesting app.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("verificationToken")]
		string VerificationToken { get; set; }

		/// <summary>Whether to ask for the provider's unique identification string.</summary>
		///         <value>To be added.</value>
		/// <value><see langword="true" /> to include the provider identifier; otherwise, <see langword="false" />.</value>
		
		bool IncludeAccountProviderIdentifier { get; set; }

		/// <summary>Whether to ask when the authentication expires.</summary>
		///         <value>To be added.</value>
		/// <value><see langword="true" /> to include the expiration date; otherwise, <see langword="false" />.</value>
		
		bool IncludeAuthenticationExpirationDate { get; set; }

		/// <summary>If not <see langword="null" />, a user-readable title of the video that the app will play on successful authentication.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("localizedVideoTitle")]
		string LocalizedVideoTitle { get; set; }

		/// <summary>If <see langword="true" />, the user may be prompted to authenticate.</summary>
		///         <value>To be added.</value>
		/// <value><see langword="true" /> if the user may be prompted; otherwise, <see langword="false" />.</value>
		
		bool InterruptionAllowed { [Bind ("isInterruptionAllowed")] get; set; }

		/// <summary>If <see langword="true" />, cached credentials will not be used.</summary>
		///         <value>To be added.</value>
		/// <value><see langword="true" /> to force authentication; otherwise, <see langword="false" />.</value>
		
		bool ForceAuthentication { get; set; }

		/// <summary>Values to be added to the SAML <c>attributeQuery</c> sent to the provider.</summary>
		///         <value>To be added.</value>
		/// <value>An array of SAML attribute names.</value>
		
		string [] AttributeNames { get; set; }

		/// <summary>Gets or sets the supported authentication schemes.</summary>
		/// <value>An array of authentication scheme strings.</value>
		
		[Protected]
		[Export ("supportedAuthenticationSchemes", ArgumentSemantic.Copy)]
		NSString [] SupportedAuthenticationSchemesString { get; set; }

		[iOS (13, 0)]
		[TV (13, 0)]
		[NullAllowed, Export ("accountProviderAuthenticationToken")]
		string AccountProviderAuthenticationToken { get; set; }

		[TV (14, 2), iOS (14, 2)]
		[NullAllowed, Export ("applicationAccountProviders", ArgumentSemantic.Copy)]
		VSAccountApplicationProvider [] ApplicationAccountProviders { get; set; }
	}

	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface VSAccountProviderResponse {

		/// <summary>Gets the authentication scheme string used by the provider.</summary>
		/// <value>The authentication scheme as an NSString constant.</value>
		
		[Protected]
		[Export ("authenticationScheme")]
		NSString AuthenticationSchemeString { get; }

		/// <summary>Gets the authentication scheme used by the provider.</summary>
		/// <value>The authentication scheme enumeration value.</value>
		
		[Wrap ("VSAccountProviderAuthenticationSchemeExtensions.GetValue (AuthenticationSchemeString)")]
		VSAccountProviderAuthenticationScheme AuthenticationScheme { get; }

		/// <summary>Gets the status of the authentication response.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("status")]
		string Status { get; }

		/// <summary>Gets the body of the authentication response.</summary>
		///         <value>
		///           <para>(More documentation for this node is coming)</para>
		///           <para tool="nullallowed">This value can be <see langword="null" />.</para>
		///         </value>
		
		[NullAllowed, Export ("body")]
		string Body { get; }
	}

	[NoMacCatalyst]
	enum VSAccountProviderAuthenticationScheme {
		/// <summary>The SAML authentication scheme.</summary>
		[Field ("VSAccountProviderAuthenticationSchemeSAML")]
		Saml,

		[iOS (13, 0)]
		[TV (13, 0)]
		[Field ("VSAccountProviderAuthenticationSchemeAPI")]
		Api,
	}

	[Deprecated (PlatformName.iOS, 18, 0, message: "Use the 'VSUserAccount' and 'VSUserAccountType' types instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use the 'VSUserAccount' and 'VSUserAccountType' types instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use the 'VSUserAccount' and 'VSUserAccountType' types instead.")]
	[NoMacCatalyst]
	[Native]
	public enum VSSubscriptionAccessLevel : long {
		/// <summary>The user has an unknown subscription level.</summary>
		Unknown,
		/// <summary>The user has a free account.</summary>
		FreeWithAccount,
		/// <summary>The user has a paid account.</summary>
		Paid,
	}

	[Deprecated (PlatformName.iOS, 18, 0, message: "Use the 'VSUserAccount' type instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use the 'VSUserAccount' type instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use the 'VSUserAccount' type instead.")]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	interface VSSubscription {
		/// <summary>Gets or sets the subscription expiration date.</summary>
		/// <value>The expiration date, or <see langword="null" /> for no expiration.</value>
		
		[NullAllowed] // null_resettable
		[Export ("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; set; }

		/// <summary>Gets or sets the access level of the subscription.</summary>
		/// <value>The subscription access level.</value>
		
		[Export ("accessLevel", ArgumentSemantic.Assign)]
		VSSubscriptionAccessLevel AccessLevel { get; set; }

		/// <summary>Gets or sets the tier identifiers for the subscription.</summary>
		/// <value>An array of tier identifier strings, or <see langword="null" />.</value>
		
		[NullAllowed] // null_resettable
		[Export ("tierIdentifiers", ArgumentSemantic.Copy)]
		string [] TierIdentifiers { get; set; }

		/// <summary>Gets or sets the billing identifier for the subscription.</summary>
		/// <value>The billing identifier, or <see langword="null" />.</value>
		
		[NullAllowed, Export ("billingIdentifier")]
		string BillingIdentifier { get; set; }
	}

	[Deprecated (PlatformName.iOS, 18, 0, message: "Use the 'VSUserAccountManager' type instead.")]
	[Deprecated (PlatformName.TvOS, 18, 0, message: "Use the 'VSUserAccountManager' type instead.")]
	[Deprecated (PlatformName.MacOSX, 15, 0, message: "Use the 'VSUserAccount' type instead.")]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSSubscriptionRegistrationCenter {
		/// <summary>Gets the default subscription registration center.</summary>
		/// <value>The shared default registration center instance.</value>
		
		[Static]
		[Export ("defaultSubscriptionRegistrationCenter")]
		VSSubscriptionRegistrationCenter Default { get; }

		/// <param name="currentSubscription">
		///   <para>The subscription to register, or <see langword="null" /> to clear.</para>
		///           <para tool="nullallowed">This parameter can be <see langword="null" />.</para>
		///         </param>
		/// <summary>Sets the current subscription for the app.</summary>
		
		[Export ("setCurrentSubscription:")]
		void SetCurrentSubscription ([NullAllowed] VSSubscription currentSubscription);
	}

	[TV (14, 2), iOS (14, 2)]
	[NoMacCatalyst]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSAccountApplicationProvider {

		[Export ("initWithLocalizedDisplayName:identifier:")]
		NativeHandle Constructor (string localizedDisplayName, string identifier);

		[Export ("localizedDisplayName")]
		string LocalizedDisplayName { get; }

		[Export ("identifier")]
		string Identifier { get; }
	}

	[TV (16, 0), NoMacCatalyst, iOS (16, 0), Mac (13, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSUserAccountManager {
		[Static]
		[Export ("sharedUserAccountManager")]
		VSUserAccountManager SharedUserAccountManager { get; }

		[Async]
		[Export ("updateUserAccount:completion:")]
		void UpdateUserAccount (VSUserAccount account, [NullAllowed] Action<NSError> completion);

		[Async]
		[Export ("queryUserAccountsWithOptions:completion:")]
		void QueryUserAccounts (VSUserAccountQueryOptions options, Action<NSArray<VSUserAccount>, NSError> completion);

		[Async]
		[TV (26, 0), NoMacCatalyst, Mac (26, 0), iOS (26, 0)]
		[Export ("queryAutoSignInTokenWithCompletionHandler:")]
		void QueryAutoSignInToken (VSUserAccountManagerQueryAutoSignInTokenCallback completion);

		[Async]
		[TV (26, 0), NoMacCatalyst, NoMac, iOS (26, 0)]
		[Export ("requestAutoSignInAuthorizationWithCompletionHandler:")]
		void RequestAutoSignInAuthorization (VSUserAccountManagerRequestAutoSignInAuthorizationCallback completion);

		[Async]
		[TV (26, 0), NoMacCatalyst, NoMac, iOS (26, 0)]
		[Export ("updateAutoSignInToken:updateContext:completionHandler:")]
		void UpdateAutoSignInToken (string autoSignInToken, VSAutoSignInTokenUpdateContext context, VSUserAccountManagerCallback completion);

		[Async]
		[TV (26, 0), NoMacCatalyst, Mac (26, 0), iOS (26, 0)]
		[Export ("deleteAutoSignInTokenWithCompletionHandler:")]
		void DeleteAutoSignInToken (VSUserAccountManagerCallback completion);
	}

	delegate void VSUserAccountManagerQueryAutoSignInTokenCallback ([NullAllowed] VSAutoSignInToken token, [NullAllowed] NSError error);
	delegate void VSUserAccountManagerRequestAutoSignInAuthorizationCallback ([NullAllowed] VSAutoSignInTokenUpdateContext updateContext, [NullAllowed] NSError error);
	delegate void VSUserAccountManagerCallback ([NullAllowed] NSError error);

	[TV (16, 0), NoMacCatalyst, iOS (16, 0), Mac (13, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSUserAccount {
		[NullAllowed, Export ("updateURL", ArgumentSemantic.Copy)]
		NSUrl UpdateUrl { get; set; }

		[Export ("requiresSystemTrust")]
		bool RequiresSystemTrust { get; set; }

		[NullAllowed, Export ("accountProviderIdentifier", ArgumentSemantic.Strong)]
		string AccountProviderIdentifier { get; set; }

		[NullAllowed, Export ("identifier")]
		string Identifier { get; set; }

		[Export ("accountType", ArgumentSemantic.Assign)]
		VSUserAccountType AccountType { get; set; }

		[Obsoleted (PlatformName.iOS, 16, 4, message: Constants.ApiRemovedGeneral)]
		[Obsoleted (PlatformName.TvOS, 16, 4, message: Constants.ApiRemovedGeneral)]
		[Obsoleted (PlatformName.MacOSX, 13, 3, message: Constants.ApiRemovedGeneral)]
		[Export ("deleted")]
		bool Deleted { [Bind ("isDeleted")] get; set; }

		[TV (16, 4), NoMacCatalyst, iOS (16, 4), Mac (13, 3)]
		[Export ("signedOut")]
		bool SignedOut { [Bind ("isSignedOut")] get; set; }

		[NullAllowed, Export ("subscriptionBillingCycleEndDate", ArgumentSemantic.Copy)]
		NSDate SubscriptionBillingCycleEndDate { get; set; }

		[NullAllowed, Export ("tierIdentifiers", ArgumentSemantic.Copy)]
		string [] TierIdentifiers { get; set; }

		[NullAllowed, Export ("billingIdentifier")]
		string BillingIdentifier { get; set; }

		[NullAllowed, Export ("authenticationData")]
		string AuthenticationData { get; set; }

		[Export ("fromCurrentDevice")]
		bool FromCurrentDevice { [Bind ("isFromCurrentDevice")] get; }

		[Export ("deviceCategory")]
		VSOriginatingDeviceCategory DeviceCategory { get; }

		[TV (17, 4), NoMacCatalyst, Mac (14, 4), iOS (17, 4)]
		[NullAllowed, Export ("appleSubscription", ArgumentSemantic.Strong)]
		VSAppleSubscription AppleSubscription { get; set; }

		[Export ("initWithAccountType:updateURL:")]
		NativeHandle Constructor (VSUserAccountType accountType, [NullAllowed] NSUrl url);
	}

	[TV (17, 4), NoMacCatalyst, Mac (14, 4), iOS (17, 4)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSAppleSubscription {

		[Export ("customerID", ArgumentSemantic.Strong)]
		string CustomerId { get; set; }

		[Export ("productCodes", ArgumentSemantic.Strong)]
		string [] ProductCodes { get; set; }

		[Export ("initWithCustomerID:productCodes:")]
		NativeHandle Constructor (string customerId, string [] productCodes);
	}

	[TV (26, 0), NoMacCatalyst, Mac (26, 0), iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSAutoSignInToken : NSSecureCoding {
		[Export ("authorization")]
		VSAutoSignInAuthorization Authorization { get; }

		[NullAllowed, Export ("value")]
		string Value { get; }
	}

	[TV (26, 0), NoMacCatalyst, NoMac, iOS (26, 0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface VSAutoSignInTokenUpdateContext {
		[Export ("authorization")]
		VSAutoSignInAuthorization Authorization { get; }
	}
}
