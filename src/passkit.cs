//
// PassKit bindings
//
// Authors:
//	Sebastien Pouliot  <sebastien@xamarin.com>
//
// Copyright 2012, 2015-2016 Xamarin Inc. All rights reserved.
// Copyright 2020 Microsoft Corp.
//

using System;
using System.ComponentModel;
using Contacts;
using CoreGraphics;
using ObjCRuntime;
using Foundation;
#if MONOMAC
using AppKit;
using ABRecord = Foundation.NSObject;
using UIButton = AppKit.NSButton;
using UIImage = AppKit.NSImage;
using UIViewController = AppKit.NSViewController;
using UIWindow = AppKit.NSWindow;
#else
using UIKit;
#if IOS
using AddressBook;
#else
using ABRecord = Foundation.NSObject;
using UIViewController = Foundation.NSObject;
using UIWindow = Foundation.NSObject;
#endif // IOS
#endif // MONOMAC

namespace PassKit {

	[Watch (3,0)]
	[iOS (9,0)]
	[Mac (11,0)] // mention 10.12 but the framework was not available on macOS at that time
	[BaseType (typeof(NSObject))]
	interface PKContact : NSSecureCoding
	{
		[NullAllowed, Export ("name", ArgumentSemantic.Strong)]
		NSPersonNameComponents Name { get; set; }
	
		[NullAllowed, Export ("postalAddress", ArgumentSemantic.Retain)]
		CNPostalAddress PostalAddress { get; set; }
	
		[NullAllowed, Export ("emailAddress", ArgumentSemantic.Strong)]
		string EmailAddress { get; set; }
	
		[NullAllowed, Export ("phoneNumber", ArgumentSemantic.Strong)]
		CNPhoneNumber PhoneNumber { get; set; }

		[NoMac]
		[iOS (9,2)]
		[Deprecated (PlatformName.iOS, 10,3, message:"Use 'SubLocality' and 'SubAdministrativeArea' on 'PostalAddress' instead.")]
		[Deprecated (PlatformName.WatchOS, 3,2, message:"Use 'SubLocality' and 'SubAdministrativeArea' on 'PostalAddress' instead.")]
		[NullAllowed, Export ("supplementarySubLocality", ArgumentSemantic.Strong)]
		string SupplementarySubLocality { get; set; }
	}

	[Mac (11,0)]
	[Watch (6,2), iOS (13,4)]
	delegate void PKPassLibrarySignDataCompletionHandler (NSData signedData, NSData signature, NSError error);
	
	[Mac (11,0)]
	[BaseType (typeof (NSObject))]
	interface PKPassLibrary {
		[Static][Export ("isPassLibraryAvailable")]
		bool IsAvailable { get; }

		[Export ("containsPass:")]
		bool Contains (PKPass pass);

		[Export ("passes")]
		PKPass[] GetPasses ();

		[Export ("passWithPassTypeIdentifier:serialNumber:")]
		PKPass GetPass (string identifier, string serialNumber);

		[iOS (8,0)]
		[Export ("passesOfType:")]
		PKPass [] GetPasses (PKPassType passType);

		[Export ("removePass:")]
		void Remove (PKPass pass);

		[Export ("replacePassWithPass:")]
		bool Replace (PKPass pass);

		[iOS (7,0)]
		[Export ("addPasses:withCompletionHandler:")]
		[Async]
		void AddPasses (PKPass[] passes, [NullAllowed] Action<PKPassLibraryAddPassesStatus> completion);

		[Field ("PKPassLibraryDidChangeNotification")]
		[Notification]
		NSString DidChangeNotification { get; }

		[iOS (9,0)]
		[Field ("PKPassLibraryRemotePaymentPassesDidChangeNotification")]
		[Notification]
		NSString RemotePaymentPassesDidChangeNotification { get; }

		[NoMac]
		[iOS (8,0)]
		[Static,Export ("isPaymentPassActivationAvailable")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use the library's instance 'IsLibraryPaymentPassActivationAvailable' property instead.")]
		bool IsPaymentPassActivationAvailable { get; }

		[NoMac]
		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'SecureElementPassActivationAvailable' instead.")]
		[Deprecated (PlatformName.WatchOS, 6, 2, message: "Use 'SecureElementPassActivationAvailable' instead.")]
		[iOS (9,0)]
		[Export ("isPaymentPassActivationAvailable")]
		bool IsLibraryPaymentPassActivationAvailable { get; }

		[Watch (6,2), iOS (13,4)]
		[Export ("secureElementPassActivationAvailable")]
		bool SecureElementPassActivationAvailable { [Bind ("isSecureElementPassActivationAvailable")] get; }

		[NoMac]
		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'ActivateSecureElementPass' instead.")]
		[NoWatch]
		[iOS (8,0)]
		[Async]
		[Export ("activatePaymentPass:withActivationData:completion:")]
		void ActivatePaymentPass (PKPaymentPass paymentPass, NSData activationData, [NullAllowed] Action<bool, NSError> completion);

		[Async]
		[NoWatch, iOS (13,4)]
		[Export ("activateSecureElementPass:withActivationData:completion:")]
		void ActivateSecureElementPass (PKSecureElementPass secureElementPass, NSData activationData, [NullAllowed] Action<bool, NSError> completion);

		[NoMac]
		[NoWatch]
		[iOS (8,0)]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'ActivatePaymentPass (PKPaymentPass, NSData, Action<bool, NSError> completion)' instead.")]
		[Async]
		[Export ("activatePaymentPass:withActivationCode:completion:")]
		void ActivatePaymentPass (PKPaymentPass paymentPass, string activationCode, [NullAllowed] Action<bool, NSError> completion);

		[NoWatch]
		[iOS (8,3)]
		[Export ("openPaymentSetup")]
		void OpenPaymentSetup ();

		[NoMac]
		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'CanAddSecureElementPass' instead.")]
		[Deprecated (PlatformName.WatchOS, 6, 2, message: "Use 'CanAddSecureElementPass' instead.")]
		[iOS (9,0)]
		[Export ("canAddPaymentPassWithPrimaryAccountIdentifier:")]
		bool CanAddPaymentPass (string primaryAccountIdentifier);

		[Watch (6,2), iOS (13,4)]
		[Export ("canAddSecureElementPassWithPrimaryAccountIdentifier:")]
		bool CanAddSecureElementPass (string primaryAccountIdentifier);

		[iOS (10,1)]
		[Watch (3,1)]
		[Export ("canAddFelicaPass")]
		bool CanAddFelicaPass { get; }

		[NoWatch]
		[iOS(9,0)]
		[Static]
		[Export ("endAutomaticPassPresentationSuppressionWithRequestToken:")]
		void EndAutomaticPassPresentationSuppression (nuint requestToken);

		[NoWatch]
		[iOS(9,0)]
		[Static]
		[Export ("isSuppressingAutomaticPassPresentation")]
		bool IsSuppressingAutomaticPassPresentation { get; }

		[NoMac]
		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'RemoteSecureElementPasses' instead.")]
		[Deprecated (PlatformName.WatchOS, 6, 2, message: "Use 'RemoteSecureElementPasses' instead.")]
		[iOS (9,0)]
		[Export ("remotePaymentPasses")]
		PKPaymentPass[] RemotePaymentPasses { get; }

		[Watch (6,2), iOS (13,4)]
		[Export ("remoteSecureElementPasses", ArgumentSemantic.Copy)]
		PKSecureElementPass[] RemoteSecureElementPasses { get; }

#if !WATCH
		[NoWatch]
		[iOS(9,0)]
		[Static]
		[Export ("requestAutomaticPassPresentationSuppressionWithResponseHandler:")]
		nuint RequestAutomaticPassPresentationSuppression (Action<PKAutomaticPassPresentationSuppressionResult> responseHandler);
#endif

		[NoMac]
		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'PresentSecureElementPass' instead.")]
		[NoWatch][iOS (10,0)]
		[Export ("presentPaymentPass:")]
		void PresentPaymentPass (PKPaymentPass pass);

		[NoWatch, iOS (13,4)]
		[Export ("presentSecureElementPass:")]
		void PresentSecureElementPass (PKSecureElementPass pass);

		[Async (ResultTypeName = "PKSignDataCompletionResult")]
		[Watch (6,2), iOS (13,4)]
		[Export ("signData:withSecureElementPass:completion:")]
		void SignData (NSData signData, PKSecureElementPass secureElementPass, PKPassLibrarySignDataCompletionHandler completion);

		[Async (ResultTypeName = "PKServiceProviderDataCompletionResult")]
		[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
		[Export ("serviceProviderDataForSecureElementPass:completion:")]
		void GetServiceProviderData (PKSecureElementPass secureElementPass, Action<NSData, NSError> completion);
	}

	[Static]
	[Mac (11,0)]
	interface PKPassLibraryUserInfoKey
	{
		[Field ("PKPassLibraryAddedPassesUserInfoKey")]
		NSString AddedPasses { get; }

		[Field ("PKPassLibraryReplacementPassesUserInfoKey")]
		NSString ReplacementPasses { get; }

		[Field ("PKPassLibraryRemovedPassInfosUserInfoKey")]
		NSString RemovedPassInfos { get; }

		[Field ("PKPassLibraryPassTypeIdentifierUserInfoKey")]
		NSString PassTypeIdentifier { get; }

		[Field ("PKPassLibrarySerialNumberUserInfoKey")]
		NSString SerialNumber { get; }
	}

	[Watch (3,0)]
	[iOS (8,0)]
	[Mac (11,0)]
	[BaseType (typeof (NSObject))]
	interface PKPayment {
		[Export ("token", ArgumentSemantic.Strong)]
		PKPaymentToken Token { get; }

		[NoMac]
		[NoMacCatalyst]
		[NoWatch]
		[Export ("billingAddress", ArgumentSemantic.Assign)]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'BillingContact' instead.")]
		ABRecord BillingAddress { get; }

		[NoMac]
		[NoMacCatalyst]
		[NoWatch]
		[Export ("shippingAddress", ArgumentSemantic.Assign)]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'ShippingContact' instead.")]
		ABRecord ShippingAddress { get; }

		[Export ("shippingMethod", ArgumentSemantic.Strong)]
		PKShippingMethod ShippingMethod { get; }

		
		[iOS (9,0)]
		[NullAllowed, Export ("shippingContact", ArgumentSemantic.Strong)]
		PKContact ShippingContact { get; }

		[iOS (9,0)]
		[NullAllowed, Export ("billingContact", ArgumentSemantic.Strong)]
		PKContact BillingContact { get; }
	}

#if !WATCH
	delegate void PKPaymentShippingAddressSelected (PKPaymentAuthorizationStatus status, PKShippingMethod [] shippingMethods, PKPaymentSummaryItem [] summaryItems);
	delegate void PKPaymentShippingMethodSelected (PKPaymentAuthorizationStatus status, PKPaymentSummaryItem[] summaryItems);

	[Mac (11,0)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PKPaymentAuthorizationViewControllerDelegate {
		
		[NoMac]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidAuthorizePayment2' instead.")]
		[Export ("paymentAuthorizationViewController:didAuthorizePayment:completion:")]
		[EventArgs ("PKPaymentAuthorization")]
#if !XAMCORE_4_0
		[Abstract]
#endif
		void DidAuthorizePayment (PKPaymentAuthorizationViewController controller, PKPayment payment, Action<PKPaymentAuthorizationStatus> completion);

		[iOS (11,0)]
		[Export ("paymentAuthorizationViewController:didAuthorizePayment:handler:")]
		[EventArgs ("PKPaymentAuthorizationResult")]
		void DidAuthorizePayment2 (PKPaymentAuthorizationViewController controller, PKPayment payment, Action<PKPaymentAuthorizationResult> completion);

		[Export ("paymentAuthorizationViewControllerDidFinish:")]
		[Abstract]
		void PaymentAuthorizationViewControllerDidFinish (PKPaymentAuthorizationViewController controller);

		[NoMac]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidSelectShippingMethod2' instead.")]
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:completion:")]
		[EventArgs ("PKPaymentShippingMethodSelected")]
		void DidSelectShippingMethod (PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, PKPaymentShippingMethodSelected completion);

		[iOS (11,0)]
		[Export ("paymentAuthorizationViewController:didSelectShippingMethod:handler:")]
		[EventArgs ("PKPaymentRequestShippingMethodUpdate")]
		void DidSelectShippingMethod2 (PKPaymentAuthorizationViewController controller, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> completion);

		[NoMacCatalyst]
		[Deprecated (PlatformName.iOS, 9, 0)]
		[NoMac]
		[Export ("paymentAuthorizationViewController:didSelectShippingAddress:completion:")]
		[EventArgs ("PKPaymentShippingAddressSelected")]
		void DidSelectShippingAddress (PKPaymentAuthorizationViewController controller, ABRecord address, PKPaymentShippingAddressSelected completion);

		[iOS (8,3)]
		[Export ("paymentAuthorizationViewControllerWillAuthorizePayment:")]
#if !XAMCORE_4_0
		[Abstract]
#endif
		void WillAuthorizePayment (PKPaymentAuthorizationViewController controller);

		[NoMac]
		[iOS (9,0)]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidSelectShippingContact' instead.")]
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:completion:")]
		[EventArgs ("PKPaymentSelectedContact")]
		void DidSelectShippingContact (PKPaymentAuthorizationViewController controller, PKContact contact, PKPaymentShippingAddressSelected completion);

		[iOS (11,0)]
		[Export ("paymentAuthorizationViewController:didSelectShippingContact:handler:")]
		[EventArgs ("PKPaymentRequestShippingContactUpdate")]
		void DidSelectShippingContact2 (PKPaymentAuthorizationViewController controller, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> completion);

		[NoMac]
		[iOS (9,0)]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidSelectPaymentMethod2' instead.")]
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:completion:")]
		[EventArgs ("PKPaymentMethodSelected")]
		void DidSelectPaymentMethod (PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, Action<PKPaymentSummaryItem[]> completion);

		[iOS (11,0)]
		[Export ("paymentAuthorizationViewController:didSelectPaymentMethod:handler:")]
		[EventArgs ("PKPaymentRequestPaymentMethodUpdate")]
		void DidSelectPaymentMethod2 (PKPaymentAuthorizationViewController controller, PKPaymentMethod paymentMethod, Action<PKPaymentRequestPaymentMethodUpdate> completion);

		[Watch (7,0)][iOS (14,0)]
		[MacCatalyst (14,0)]
		[Export ("paymentAuthorizationViewController:didRequestMerchantSessionUpdate:")]
		[EventArgs ("PKPaymentRequestMerchantSessionUpdate")]
		void DidRequestMerchantSessionUpdate (PKPaymentAuthorizationViewController controller, Action<PKPaymentRequestMerchantSessionUpdate> updateHandler);

		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Export ("paymentAuthorizationViewController:didChangeCouponCode:handler:")]
		[EventArgs ("PKPaymentRequestCouponCodeUpdate")]
		void DidChangeCouponCode (PKPaymentAuthorizationViewController controller, string couponCode, Action<PKPaymentRequestCouponCodeUpdate> completion);
	}

	[Mac (11,0)]
	[iOS (8,0)]
	[BaseType (typeof (UIViewController), Delegates=new string []{"Delegate"}, Events=new Type [] {typeof(PKPaymentAuthorizationViewControllerDelegate)})]
	[DisableDefaultCtor]
	interface PKPaymentAuthorizationViewController {
		[DesignatedInitializer]
		[Export ("initWithPaymentRequest:")]
		IntPtr Constructor (PKPaymentRequest request);

		[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		[Protocolize]
		PKPaymentAuthorizationViewControllerDelegate Delegate { get; set; }

		[Static, Export ("canMakePayments")]
		bool CanMakePayments { get; }

		// These are the NSString constants
		[Static, Export ("canMakePaymentsUsingNetworks:")]
		bool CanMakePaymentsUsingNetworks (NSString [] paymentNetworks);

		[iOS (9,0)]
		[Static]
		[Export ("canMakePaymentsUsingNetworks:capabilities:")]
		bool CanMakePaymentsUsingNetworks (string[] supportedNetworks, PKMerchantCapability capabilties);
	}
#endif

	[Watch (3,0)]
	[iOS (8,0)]
	[Mac (11,0)]
	[BaseType (typeof (NSObject))]
	interface PKPaymentSummaryItem {
		[NullAllowed] // by default this property is null
		[Export ("label")]
		string Label { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("amount", ArgumentSemantic.Copy)]
		NSDecimalNumber Amount { get; set; }

		[Static, Export ("summaryItemWithLabel:amount:")]
		PKPaymentSummaryItem Create (string label, NSDecimalNumber amount);

		[iOS (9,0)]
		[Export ("type", ArgumentSemantic.Assign)]
		PKPaymentSummaryItemType Type { get; set; }

		[iOS (9,0)]
		[Static]
		[Export ("summaryItemWithLabel:amount:type:")]
		PKPaymentSummaryItem Create (string label, NSDecimalNumber amount, PKPaymentSummaryItemType type);
	}

	[Watch (3,0)]
	[iOS (8,0)]
	[Mac (11,0)]
	[BaseType (typeof (PKPaymentSummaryItem))]
	interface PKShippingMethod {
		[NullAllowed] // by default this property is null
		[Export ("identifier")]
		string Identifier { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("detail")]
		string Detail { get; set; }

		[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
		[NullAllowed]
		[Export ("dateComponentsRange", ArgumentSemantic.Copy)]
		PKDateComponentsRange DateComponentsRange { get; set; }
	}

	[Watch (3,0)]
	[iOS (8,0)]
	[Mac (11,0)]
	[BaseType (typeof (NSObject))]
	interface PKPaymentRequest {
		[NullAllowed] // by default this property is null
		[Export ("merchantIdentifier")]
		string MerchantIdentifier { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("countryCode")]
		string CountryCode { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("supportedNetworks", ArgumentSemantic.Copy)]
		NSString [] SupportedNetworks { get; set; }

		[Export ("merchantCapabilities", ArgumentSemantic.UnsafeUnretained)]
		PKMerchantCapability MerchantCapabilities { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("paymentSummaryItems", ArgumentSemantic.Copy)]
		PKPaymentSummaryItem [] PaymentSummaryItems { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("currencyCode")]
		string CurrencyCode { get; set; }

		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Export ("supportsCouponCode")]
		bool SupportsCouponCode { get; set; }

		[NullAllowed]
		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Export ("couponCode")]
		string CouponCode { get; set; }

		[Watch (8,0), Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Export ("shippingContactEditingMode", ArgumentSemantic.Assign)]
		PKShippingContactEditingMode ShippingContactEditingMode { get; set; }

		[NoMac]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'RequiredBillingContactFields' instead.")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'RequiredBillingContactFields' instead.")]
		[Export ("requiredBillingAddressFields", ArgumentSemantic.UnsafeUnretained)]
		PKAddressField RequiredBillingAddressFields { get; set; }

		[NoMac]
		[NoMacCatalyst]
		[NoWatch]
		[NullAllowed] // by default this property is null
		[Export ("billingAddress", ArgumentSemantic.Assign)]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'BillingContact' instead.")]
		ABRecord BillingAddress { get; set; }

		[NoMac]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'RequiredShippingContactFields' instead.")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'RequiredShippingContactFields' instead.")]
		[Export ("requiredShippingAddressFields", ArgumentSemantic.UnsafeUnretained)]
		PKAddressField RequiredShippingAddressFields { get; set; }

		[NoMac]
		[NoMacCatalyst]
		[NoWatch]
		[NullAllowed] // by default this property is null
		[Export ("shippingAddress", ArgumentSemantic.Assign)]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'ShippingContact' instead.")]
		ABRecord ShippingAddress { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("shippingMethods", ArgumentSemantic.Copy)]
		PKShippingMethod [] ShippingMethods { get; set; }

		[NullAllowed] // by default this property is null
		[Export ("applicationData", ArgumentSemantic.Copy)]
		NSData ApplicationData { get; set; }

		[iOS (8,3)]
		[Export ("shippingType", ArgumentSemantic.Assign)]
		PKShippingType ShippingType { get; set; }

		[iOS (9,0)]
		[NullAllowed, Export ("shippingContact", ArgumentSemantic.Strong)]
		PKContact ShippingContact { get; set; }

		[iOS (9,0)]
		[NullAllowed, Export ("billingContact", ArgumentSemantic.Strong)]
		PKContact BillingContact { get; set; }

		[iOS (10,0)]
		[Static]
		[Export ("availableNetworks")]
		NSString[] AvailableNetworks { get; }

		[Watch (4,0)][iOS (11,0)]
		[Export ("requiredBillingContactFields", ArgumentSemantic.Strong)]
		NSSet WeakRequiredBillingContactFields { get; set; }

		[Watch (4,0)][iOS (11,0)]
		[Export ("requiredShippingContactFields", ArgumentSemantic.Strong)]
		NSSet WeakRequiredShippingContactFields { get; set; }

		[Watch (4,0)][iOS (11,0)]
		[NullAllowed, Export ("supportedCountries", ArgumentSemantic.Copy)]
		NSSet<NSString> SupportedCountries { get; set; }

		[Watch (4,0)][iOS (11,0)]
		[Static]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("paymentContactInvalidErrorWithContactField:localizedDescription:")]
		NSError CreatePaymentContactInvalidError (NSString field, [NullAllowed] string localizedDescription);

		[Watch (4,0)][iOS (11,0)]
		[Static]
		[Wrap ("CreatePaymentContactInvalidError (contactField.GetConstant ()!, localizedDescription)")]
		NSError CreatePaymentContactInvalidError (PKContactFields contactField, [NullAllowed] string localizedDescription);

		[Watch (4,0)][iOS (11,0)]
		[Static]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("paymentShippingAddressInvalidErrorWithKey:localizedDescription:")]
		NSError CreatePaymentShippingAddressInvalidError (NSString postalAddressKey, [NullAllowed] string localizedDescription);

		[Watch (4,0)][iOS (11,0)]
		[Static]
		[Wrap ("CreatePaymentShippingAddressInvalidError (postalAddress.GetConstant ()!, localizedDescription)")]
		NSError CreatePaymentShippingAddressInvalidError (CNPostalAddressKeyOption postalAddress, [NullAllowed] string localizedDescription);

		[Watch (4,0)][iOS (11,0)]
		[Static]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("paymentBillingAddressInvalidErrorWithKey:localizedDescription:")]
		NSError CreatePaymentBillingAddressInvalidError (NSString postalAddressKey, [NullAllowed] string localizedDescription);

		[Watch (4,0)][iOS (11,0)]
		[Static]
		[Wrap ("CreatePaymentBillingAddressInvalidError (postalAddress.GetConstant ()!, localizedDescription)")]
		NSError CreatePaymentBillingAddressInvalidError (CNPostalAddressKeyOption postalAddress, [NullAllowed] string localizedDescription);

		[Watch (4,0)][iOS (11,0)]
		[Static]
		[Export ("paymentShippingAddressUnserviceableErrorWithLocalizedDescription:")]
		NSError CreatePaymentShippingAddressUnserviceableError ([NullAllowed] string localizedDescription);

		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Static]
		[Export ("paymentCouponCodeInvalidErrorWithLocalizedDescription:")]
		NSError GetCouponCodeInvalidError ([NullAllowed] string localizedDescription);

		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Static]
		[Export ("paymentCouponCodeExpiredErrorWithLocalizedDescription:")]
		NSError GetCouponCodeExpiredError ([NullAllowed] string localizedDescription);
	}

	[Mac  (11,0)]
	[Watch (4,0)][iOS (11,0)]
	[Flags]
	enum PKContactFields {
		None = 0,

		[Field ("PKContactFieldPostalAddress")]
		PostalAddress = 1 << 0,

		[Field ("PKContactFieldEmailAddress")]
		EmailAddress = 1 << 1,

		[Field ("PKContactFieldPhoneNumber")]
		PhoneNumber = 1 << 2,

		[Field ("PKContactFieldName")]
		Name = 1 << 3,

		[Field ("PKContactFieldPhoneticName")]
		PhoneticName = 1 << 4,
	}

	[Watch (3,0)]
	[iOS (8,0)]
	[Mac (11,0)]
	[BaseType (typeof (NSObject))]
	interface PKPaymentToken {

		[NoMac]
		[NoWatch]
		[Export ("paymentInstrumentName", ArgumentSemantic.Copy)]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'PaymentMethod' instead.")]
		string PaymentInstrumentName { get; }

		[NoMac]
		[NoWatch]
		[Export ("paymentNetwork")]
		[Deprecated (PlatformName.iOS, 9, 0, message: "Use 'PaymentMethod' instead.")]
		string PaymentNetwork { get; }

		[Export ("transactionIdentifier")]
		string TransactionIdentifier { get; }

		[Export ("paymentData", ArgumentSemantic.Copy)]
		NSData PaymentData { get; }

		[iOS (9,0)]
		[Export ("paymentMethod", ArgumentSemantic.Strong)]
		PKPaymentMethod PaymentMethod { get; }		
	}

	[NoMac] // under `TARGET_OS_IPHONE`
	[NoWatch]
	[BaseType (typeof (UIViewController), Delegates = new string [] {"WeakDelegate"}, Events = new Type [] { typeof (PKAddPassesViewControllerDelegate) })]
	// invalid null handle for default 'init'
	[DisableDefaultCtor]
	interface PKAddPassesViewController {

		[Export ("initWithNibName:bundle:")]
		[PostGet ("NibBundle")]
		IntPtr Constructor ([NullAllowed] string nibName, [NullAllowed] NSBundle bundle);

		[Export ("initWithPass:")]
		IntPtr Constructor (PKPass pass);

		[iOS (7,0)]
		[Export ("initWithPasses:")]
		IntPtr Constructor (PKPass[] pass);

		[iOS (8,0)]
		[Static]
		[Export ("canAddPasses")]
		bool CanAddPasses { get;}
			
		[Export ("delegate", ArgumentSemantic.Assign), NullAllowed]
		NSObject WeakDelegate { get; set; }

		[Wrap ("WeakDelegate")]
		[Protocolize]
		PKAddPassesViewControllerDelegate Delegate { get; set;  }
	}

	[NoMac] // under `TARGET_OS_IPHONE`
	[NoWatch]
	[BaseType (typeof (NSObject))]
	[Model]
	[Protocol]
	interface PKAddPassesViewControllerDelegate {
		[Export ("addPassesViewControllerDidFinish:")]
		void Finished (PKAddPassesViewController controller);
	}

	[NoWatch]
	[iOS (9,0)]
	[Mac (11,0)]
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor] // designated
	interface PKAddPaymentPassRequest : NSSecureCoding
	{
		[DesignatedInitializer]
		[Export ("init")]
		IntPtr Constructor ();

		[NullAllowed, Export ("encryptedPassData", ArgumentSemantic.Copy)]
		NSData EncryptedPassData { get; set; }
	
		[NullAllowed, Export ("activationData", ArgumentSemantic.Copy)]
		NSData ActivationData { get; set; }
	
		[NullAllowed, Export ("ephemeralPublicKey", ArgumentSemantic.Copy)]
		NSData EphemeralPublicKey { get; set; }
	
		[NullAllowed, Export ("wrappedKey", ArgumentSemantic.Copy)]
		NSData WrappedKey { get; set; }
	}

	[Mac (11,0)] // not explict (no availability macro) but part of macOS headers
	[NoWatch]
	[iOS (9,0)]
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PKAddPaymentPassRequestConfiguration : NSSecureCoding
	{
		[DesignatedInitializer]
		[Export ("initWithEncryptionScheme:")]
		IntPtr Constructor (NSString encryptionScheme);

		[Export ("encryptionScheme")]
		NSString EncryptionScheme { get; }
	
		[NullAllowed, Export ("cardholderName")]
		string CardholderName { get; set; }
	
		[NullAllowed, Export ("primaryAccountSuffix")]
		string PrimaryAccountSuffix { get; set; }

		[iOS (10,1)]
		[NoWatch] // Radar: https://trello.com/c/MvaHEZlc
		[Export ("cardDetails", ArgumentSemantic.Copy)]
		PKLabeledValue[] CardDetails { get; set; }
	
		[NullAllowed, Export ("localizedDescription")]
		string LocalizedDescription { get; set; }
	
		[NullAllowed, Export ("primaryAccountIdentifier")]
		string PrimaryAccountIdentifier { get; set; }
	
		[NullAllowed, Export ("paymentNetwork")]
		string PaymentNetwork { get; set; }

		[iOS (10,1)]
		[NoWatch] // Radar: https://trello.com/c/MvaHEZlc
		[Export ("requiresFelicaSecureElement")]
		bool RequiresFelicaSecureElement { get; set; }

		[iOS (12, 0)]
		[Export ("style", ArgumentSemantic.Assign)]
		PKAddPaymentPassStyle Style { get; set; }

		[NoWatch] // https://feedbackassistant.apple.com/feedback/6301809 https://github.com/xamarin/maccore/issues/1819
		[iOS (12,3)]
		[Export ("productIdentifiers", ArgumentSemantic.Copy)]
		NSSet<NSString> ProductIdentifiers { get; set; }
	}

	[NoMac] // under `#if TARGET_OS_IPHONE`
	[NoWatch]
	[iOS (9,0)]
	[BaseType (typeof(UIViewController))]
	[DisableDefaultCtor]
	interface PKAddPaymentPassViewController
	{
		[Static]
		[Export ("canAddPaymentPass")]
		bool CanAddPaymentPass { get; }
	
		[DesignatedInitializer]
		[Export ("initWithRequestConfiguration:delegate:")]
		IntPtr Constructor (PKAddPaymentPassRequestConfiguration configuration, [NullAllowed] IPKAddPaymentPassViewControllerDelegate viewControllerDelegate);

#if !XAMCORE_4_0
		[Obsolete ("Use the overload accepting a IPKAddPaymentPassViewControllerDelegate")]
		[Wrap ("this (configuration, (IPKAddPaymentPassViewControllerDelegate) viewControllerDelegate)")]
		IntPtr Constructor (PKAddPaymentPassRequestConfiguration configuration, PKAddPaymentPassViewControllerDelegate viewControllerDelegate);
#endif

		[Wrap ("WeakDelegate")]
		[NullAllowed, Protocolize]
		PKAddPaymentPassViewControllerDelegate Delegate { get; set; }
	
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	interface IPKAddPaymentPassViewControllerDelegate {}
	
	[NoWatch]
	[NoMac] // under `#if TARGET_OS_IPHONE`
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface PKAddPaymentPassViewControllerDelegate
	{
		[Abstract]
		[Export ("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:")]
		void GenerateRequestWithCertificateChain (PKAddPaymentPassViewController controller, NSData[] certificates, NSData nonce, NSData nonceSignature, Action<PKAddPaymentPassRequest> handler);
	
		[Abstract]
		[Export ("addPaymentPassViewController:didFinishAddingPaymentPass:error:")]
		void DidFinishAddingPaymentPass (PKAddPaymentPassViewController controller, [NullAllowed] PKPaymentPass pass, [NullAllowed] NSError error);
	}
		
	[Mac (11,0)]
	[BaseType (typeof (PKObject))]
	interface PKPass : NSSecureCoding, NSCopying {
		[Export ("initWithData:error:")]
		IntPtr Constructor (NSData data, out NSError error);

		[Export ("authenticationToken", ArgumentSemantic.Copy)]
		string AuthenticationToken { get; }

		[NoWatch]
		[NoMac]
		[NoMacCatalyst]
		[Export ("icon", ArgumentSemantic.Copy)]
		UIImage Icon { get; }

		[Export ("localizedDescription", ArgumentSemantic.Copy)]
		string LocalizedDescription { get; }

		[Export ("localizedName", ArgumentSemantic.Copy)]
		string LocalizedName { get; }

		[Export ("organizationName", ArgumentSemantic.Copy)]
		string OrganizationName { get; }

		[Export ("passTypeIdentifier", ArgumentSemantic.Copy)]
		string PassTypeIdentifier { get; }

		[NullAllowed]
		[Export ("passURL", ArgumentSemantic.Copy)]
		NSUrl PassUrl { get; }

		[Export ("relevantDate", ArgumentSemantic.Copy)]
		NSDate RelevantDate { get; }

		[Export ("serialNumber", ArgumentSemantic.Copy)]
		string SerialNumber { get; }

		[Export ("webServiceURL", ArgumentSemantic.Copy)]
		NSUrl WebServiceUrl { get; }

		[Export ("localizedValueForFieldKey:")]
		NSObject GetLocalizedValue (NSString key); // TODO: Should be enum for PKPassLibraryUserInfoKey

#if !XAMCORE_4_0 && !MONOMAC
		[Field ("PKPassKitErrorDomain")]
		NSString ErrorDomain { get; }
#endif

		[iOS (7,0)]
		[Export ("userInfo", ArgumentSemantic.Copy)]
		NSDictionary UserInfo { get; }

		[iOS (8,0)]
		[Export ("passType")]
		PKPassType PassType { get; }

		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'SecureElementPass' instead.")]
		[Deprecated (PlatformName.WatchOS, 6, 2, message: "Use 'SecureElementPass' instead.")]
		[NoMac]
		[iOS (8,0)]
		[Export ("paymentPass")]
		PKPaymentPass PaymentPass { get; }

		[Watch (6,2), iOS (13,4)]
		[NullAllowed, Export ("secureElementPass")]
		PKSecureElementPass SecureElementPass { get; }

		[iOS (9,0)]
		[Export ("remotePass")]
		bool RemotePass { [Bind ("isRemotePass")] get; }

		[iOS (9,0)]
		[Export ("deviceName")]
		string DeviceName { get; }		
	}

	[Watch (3,0)]
	[iOS (9,0)]
	[Mac (11,0)]
	[BaseType (typeof(NSObject))]
	interface PKPaymentMethod : NSSecureCoding
	{
		[NullAllowed, Export ("displayName")]
		string DisplayName { get; }
	
		[NullAllowed, Export ("network")]
		string Network { get; }
	
		[Export ("type")]
		PKPaymentMethodType Type { get; }

		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'SecureElementPass' instead.")]
		[Deprecated (PlatformName.WatchOS, 6, 2, message: "Use 'SecureElementPass' instead.")]
		[NoMac]
		[NullAllowed, Export ("paymentPass", ArgumentSemantic.Copy)]
		PKPaymentPass PaymentPass { get; }

		[Watch (6,2), iOS (13,4)]
		[NullAllowed, Export ("secureElementPass", ArgumentSemantic.Copy)]
		PKSecureElementPass SecureElementPass { get; }

		[Watch (6, 0), iOS (13, 0)]
		[NullAllowed, Export ("billingAddress", ArgumentSemantic.Copy)]
		CNContact BillingAddress { get; }
	}

	[iOS (8,0)]
	[Mac (11,0)]
	[BaseType (typeof (PKSecureElementPass))]
	interface PKPaymentPass {

		[Deprecated (PlatformName.iOS, 13, 4, message: "Use 'PKSecureElementPass.PassActivationState' instead.")]
		[Deprecated (PlatformName.WatchOS, 6, 2, message: "Use 'PKSecureElementPass.PassActivationState' instead.")]
		[NoMac]
		[Export ("activationState")]
		PKPaymentPassActivationState ActivationState { get; }
	}
	
	[iOS (8,0)]
	[Mac (11,0)]
	[BaseType (typeof (NSObject))]
	partial interface PKObject : NSCoding, NSSecureCoding, NSCopying {
		//Empty class in header file
	}

	[Static]
	[iOS (8,0)]
	[Watch (3,0)]
	[Mac (11,0)]
	interface PKPaymentNetwork {
		[Field ("PKPaymentNetworkAmex")]
		NSString Amex { get; }

		[NoMac]
		[iOS (10,3), Watch (3,2)]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'CartesBancaires' instead.")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'CartesBancaires' instead.")]
		[Field ("PKPaymentNetworkCarteBancaire")]
		NSString CarteBancaire { get; }

		[NoMac]
		[iOS (11,0)][Watch (4,0)]
		[Deprecated (PlatformName.WatchOS, 4,2, message: "Use 'CartesBancaires' instead.")]
		[Deprecated (PlatformName.iOS, 11,2, message: "Use 'CartesBancaires' instead.")]
		[Field ("PKPaymentNetworkCarteBancaires")]
		NSString CarteBancaires { get; }

		[iOS (11,2)][Watch (4,2)]
		[Field ("PKPaymentNetworkCartesBancaires")]
		NSString CartesBancaires { get; }

		[iOS (9,2)]
		[Field ("PKPaymentNetworkChinaUnionPay")]
		NSString ChinaUnionPay { get; }

		[iOS (9,2)]
		[Field ("PKPaymentNetworkInterac")]
		NSString Interac { get; }

		[Field ("PKPaymentNetworkMasterCard")]
		NSString MasterCard { get; }

		[Field ("PKPaymentNetworkVisa")]
		NSString Visa { get; }

		[iOS (9,0)]
		[Field ("PKPaymentNetworkDiscover")]
		NSString Discover { get; }

		[iOS (9,0)]
		[Field ("PKPaymentNetworkPrivateLabel")]
		NSString PrivateLabel { get; }

		[Watch (3,1), iOS (10,1)]
		[Field ("PKPaymentNetworkJCB")]
		NSString Jcb { get; }

		[Watch (3,1), iOS (10,1)]
		[Field ("PKPaymentNetworkSuica")]
		NSString Suica { get; }

		[iOS (10,3), Watch (3,2)]
		[Field ("PKPaymentNetworkQuicPay")]
		NSString QuicPay { get; }

		[iOS (10,3), Watch (3,2)]
		[Field ("PKPaymentNetworkIDCredit")]
		NSString IDCredit { get; }

		[iOS (12,0), Watch (5,0)]
		[Field ("PKPaymentNetworkElectron")]
		NSString Electron { get; }

		[iOS (12,0), Watch (5,0)]
		[Field ("PKPaymentNetworkMaestro")]
		NSString Maestro { get; }

		[iOS (12,0), Watch (5,0)]
		[Field ("PKPaymentNetworkVPay")]
		NSString VPay { get; }

		[iOS (12,0), Watch (5,0)]
		[Field ("PKPaymentNetworkEftpos")]
		NSString Eftpos { get; }

		[Watch (5,1,2)][iOS (12,1,1)]
		[Field ("PKPaymentNetworkElo")]
		NSString Elo { get; }

		[Watch (5,1,2)][iOS (12,1,1)]
		[Field ("PKPaymentNetworkMada")]
		NSString Mada { get; }

		[Watch (7,0)][iOS (14,0)]
		[MacCatalyst (14,0)]
		[Field ("PKPaymentNetworkBarcode")]
		NSString Barcode { get; }

		[Watch (7,0)][iOS (14,0)]
		[MacCatalyst (14,0)]
		[Field ("PKPaymentNetworkGirocard")]
		NSString Girocard { get; }

		[Watch (7,4)][Mac (11,3)][iOS (14, 5)]
		[MacCatalyst (14,5)]
		[Field ("PKPaymentNetworkMir")]
		NSString Mir { get; }

		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Field ("PKPaymentNetworkNanaco")]
		NSString Nanaco { get; }

		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Field ("PKPaymentNetworkWaon")]
		NSString Waon { get; }

	}

#if !WATCH
	[Mac (11,0)]
	[iOS (8,3)]
	[BaseType (typeof (UIButton))]
	[DisableDefaultCtor]
	interface PKPaymentButton {

		[Static]
		[Export ("buttonWithType:style:")]
		// note: named like UIButton method
		PKPaymentButton FromType (PKPaymentButtonType buttonType, PKPaymentButtonStyle buttonStyle);

		[iOS (9,0)]
		[Export ("initWithPaymentButtonType:paymentButtonStyle:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKPaymentButtonType type, PKPaymentButtonStyle style);

		[iOS (12, 0)]
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }
	}

	[NoMac] // under `#if TARGET_OS_IOS`
	[iOS (9,0)]
	[BaseType (typeof (UIButton))]
	[DisableDefaultCtor]
	interface PKAddPassButton {
		[Static]
		[Export ("addPassButtonWithStyle:")]
		PKAddPassButton Create (PKAddPassButtonStyle addPassButtonStyle);

		[Export ("initWithAddPassButtonStyle:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKAddPassButtonStyle style);

		[Appearance]
		[Export ("addPassButtonStyle", ArgumentSemantic.Assign)]
		PKAddPassButtonStyle Style { get; set; }
	}
#endif // !WATCH

	[Mac (11,0)]
	[iOS(9,0)]
	[Static]
	interface PKEncryptionScheme {
		[Field ("PKEncryptionSchemeECC_V2")]
		NSString Ecc_V2 { get; }

		[iOS (10,0)]
		[Watch (3,0)]
		[Field ("PKEncryptionSchemeRSA_V2")]
		NSString Rsa_V2 { get; }
	}

	[Mac (11,0)]
	[Watch (3,0)][iOS (10,0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // providing DesignatedInitializer
	interface PKPaymentAuthorizationController {

		[Static]
		[Export ("canMakePayments")]
		bool CanMakePayments { get; }

		[Static]
		[Export ("canMakePaymentsUsingNetworks:")]
		bool CanMakePaymentsUsingNetworks (string[] supportedNetworks);

		[Static]
		[Export ("canMakePaymentsUsingNetworks:capabilities:")]
		bool CanMakePaymentsUsingNetworks (string[] supportedNetworks, PKMerchantCapability capabilties);

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		IPKPaymentAuthorizationControllerDelegate Delegate { get; set; }

		[Export ("initWithPaymentRequest:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKPaymentRequest request);

		[Async]
		[Export ("presentWithCompletion:")]
		void Present ([NullAllowed] Action<bool> completion);

		[Async]
		[Export ("dismissWithCompletion:")]
		void Dismiss ([NullAllowed] Action completion);
	}

	interface IPKPaymentAuthorizationControllerDelegate {}

	[Mac (11,0)]
	[Watch (3,0)][iOS (10,0)]
	[Protocol][Model]
	[BaseType (typeof (NSObject))]
	interface PKPaymentAuthorizationControllerDelegate {

		[NoMac]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidAuthorizePayment' overload with the 'Action<PKPaymentAuthorizationResult>' parameter instead.")]
#if !XAMCORE_4_0
		[Abstract]
#endif
		[Export ("paymentAuthorizationController:didAuthorizePayment:completion:")]
		void DidAuthorizePayment (PKPaymentAuthorizationController controller, PKPayment payment, Action<PKPaymentAuthorizationStatus> completion);

		[Watch (4,0)][iOS (11,0)]
		[Export ("paymentAuthorizationController:didAuthorizePayment:handler:")]
		void DidAuthorizePayment (PKPaymentAuthorizationController controller, PKPayment payment, Action<PKPaymentAuthorizationResult> completion);

		[Abstract]
		[Export ("paymentAuthorizationControllerDidFinish:")]
		void DidFinish (PKPaymentAuthorizationController controller);

		[Export ("paymentAuthorizationControllerWillAuthorizePayment:")]
		void WillAuthorizePayment (PKPaymentAuthorizationController controller);

		[NoMac]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidSelectShippingMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[Export ("paymentAuthorizationController:didSelectShippingMethod:completion:")]
		void DidSelectShippingMethod (PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, Action<PKPaymentAuthorizationStatus, PKPaymentSummaryItem[]> completion);

		[Watch (4,0)][iOS (11,0)]
		[Export ("paymentAuthorizationController:didSelectShippingMethod:handler:")]
		void DidSelectShippingMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, Action<PKPaymentRequestPaymentMethodUpdate> completion);

		[NoMac]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidSelectShippingContact' overload with the 'Action<PKPaymentRequestShippingContactUpdate>' parameter instead.")]
		[Export ("paymentAuthorizationController:didSelectShippingContact:completion:")]
		void DidSelectShippingContact (PKPaymentAuthorizationController controller, PKContact contact, Action<PKPaymentAuthorizationStatus, PKShippingMethod[], PKPaymentSummaryItem[]> completion);

		[Watch (4,0)][iOS (11,0)]
		[Export ("paymentAuthorizationController:didSelectShippingContact:handler:")]
		void DidSelectShippingContact (PKPaymentAuthorizationController controller, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> completion);

		[NoMac]
		[Deprecated (PlatformName.WatchOS, 4,0, message: "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[Deprecated (PlatformName.iOS, 11,0, message: "Use 'DidSelectPaymentMethod' overload with the 'Action<PKPaymentRequestPaymentMethodUpdate>' parameter instead.")]
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:completion:")]
		void DidSelectPaymentMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, Action<PKPaymentSummaryItem[]> completion);

		[Watch (4,0)][iOS (11,0)]
		[Export ("paymentAuthorizationController:didSelectPaymentMethod:handler:")]
		void DidSelectPaymentMethod (PKPaymentAuthorizationController controller, PKPaymentMethod paymentMethod, Action<PKPaymentRequestPaymentMethodUpdate> completion);

		[Watch (7,0)][iOS (14,0)]
		[MacCatalyst (14,0)]
		[Export ("paymentAuthorizationController:didRequestMerchantSessionUpdate:")]
		void DidRequestMerchantSessionUpdate (PKPaymentAuthorizationController controller, Action<PKPaymentRequestMerchantSessionUpdate> handler);

		[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Export ("paymentAuthorizationController:didChangeCouponCode:handler:")]
		void DidChangeCouponCode (PKPaymentAuthorizationController controller, string couponCode, Action<PKPaymentRequestCouponCodeUpdate> completion);

		[Watch (7,0)][iOS (14,0)]
		[MacCatalyst (14,0)]
		[Export ("presentationWindowForPaymentAuthorizationController:")]
		[return: NullAllowed]
#if MONOMAC
		[Abstract]
#endif
		UIWindow GetPresentationWindow (PKPaymentAuthorizationController controller);
	}

	[Mac (11,0)]
	[iOS (10,1)]
	[NoWatch] // Radar: https://trello.com/c/MvaHEZlc
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor] // there's a designated initializer and it does not accept null
	interface PKLabeledValue
	{
		[Export ("initWithLabel:value:")]
		[DesignatedInitializer]
		IntPtr Constructor (string label, string value);

		[Export ("label")]
		string Label { get; }

		[Export ("value")]
		string Value { get; }
	}

	[Mac (11,0)]
	[Watch (4,3), iOS (11,3)]
	[BaseType (typeof (PKStoredValuePassProperties))]
	[DisableDefaultCtor]
	interface PKTransitPassProperties {

		[Static]
		[Export ("passPropertiesForPass:")]
		[return: NullAllowed]
		PKTransitPassProperties GetPassProperties (PKPass pass);

		[Deprecated (PlatformName.iOS, 15, 0)]
		[Deprecated (PlatformName.WatchOS, 8, 0)]
		[Deprecated (PlatformName.MacOSX, 12, 0)]
		[Deprecated (PlatformName.MacCatalyst, 15, 0)]
		[Export ("transitBalance", ArgumentSemantic.Copy)]
		NSDecimalNumber TransitBalance { get; }

		[Deprecated (PlatformName.iOS, 15, 0)]
		[Deprecated (PlatformName.WatchOS, 8, 0)]
		[Deprecated (PlatformName.MacOSX, 12, 0)]
		[Deprecated (PlatformName.MacCatalyst, 15, 0)]
		[Export ("transitBalanceCurrencyCode")]
		string TransitBalanceCurrencyCode { get; }

		[Export ("inStation")]
		bool InStation { [Bind ("isInStation")] get; }

		[Deprecated (PlatformName.iOS, 14,5, message: "Use 'Blocked' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 14,5, message: "Use 'Blocked' instead.")]
		[Deprecated (PlatformName.WatchOS, 7,4, message: "Use 'Blocked' instead.")]
		[Deprecated (PlatformName.MacOSX, 11,3, message: "Use 'Blocked' instead.")]
		[Export ("blacklisted")]
		bool Blacklisted { [Bind ("isBlacklisted")] get; }

		[iOS (14,5)][Watch (7,4)]
		[Mac (11,3)]
		[MacCatalyst (14,5)]
		[Export ("blocked")]
		bool Blocked { [Bind ("isBlocked")] get; }

		[NullAllowed, Export ("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; }
	}

	[Mac (11,0)]
	[Watch (3,1), iOS (10,1)]
#if XAMCORE_4_0 || MONOMAC
	[DisableDefaultCtor] // hint: getter only props and a factory method.
#endif
	[BaseType (typeof (PKTransitPassProperties))]
	interface PKSuicaPassProperties
	{
		[Static]
		[Export ("passPropertiesForPass:")]
		[return: NullAllowed]
		PKSuicaPassProperties GetPassProperties (PKPass pass);

		[Export ("transitBalance", ArgumentSemantic.Copy)]
		NSDecimalNumber TransitBalance { get; }

		[Export ("transitBalanceCurrencyCode")]
		string TransitBalanceCurrencyCode { get; }

		[Export ("inStation")]
		bool InStation { [Bind ("isInStation")] get; }

		[Export ("inShinkansenStation")]
		bool InShinkansenStation { [Bind ("isInShinkansenStation")] get; }

		[Watch (4,3), iOS (11,3)]
		[Export ("balanceAllowedForCommute")]
		bool BalanceAllowedForCommute { [Bind ("isBalanceAllowedForCommute")] get; }

		[Watch (4,3), iOS (11,3)]
		[Export ("lowBalanceGateNotificationEnabled")]
		bool LowBalanceGateNotificationEnabled { [Bind ("isLowBalanceGateNotificationEnabled")] get; }

		[Export ("greenCarTicketUsed")]
		bool GreenCarTicketUsed { [Bind ("isGreenCarTicketUsed")] get; }

		[Export ("blacklisted")]
		[Deprecated (PlatformName.iOS, 14,5, message: "Use 'Blocked' instead.")] // exists in base class
		[Deprecated (PlatformName.WatchOS, 7,4, message: "Use 'Blocked' instead.")]
		[Deprecated (PlatformName.MacOSX, 11,3, message: "Use 'Blocked' instead.")]
		[Deprecated (PlatformName.MacCatalyst, 14,5, message: "Use 'Blocked' instead.")]
		bool Blacklisted { [Bind ("isBlacklisted")] get; }
	}

	[Mac (11,0)]
	[Watch (4,0)][iOS (11,0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKPaymentAuthorizationResult {
		[Export ("initWithStatus:errors:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKPaymentAuthorizationStatus status, [NullAllowed] NSError[] errors);

		[Export ("status", ArgumentSemantic.Assign)]
		PKPaymentAuthorizationStatus Status { get; set; }

		[Export ("errors", ArgumentSemantic.Copy)]
		NSError[] Errors { get; set; }
	}

	[Mac (11,0)]
	[Watch (4,0)][iOS (11,0)]
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PKPaymentRequestUpdate {

		[Export ("initWithPaymentSummaryItems:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKPaymentSummaryItem[] paymentSummaryItems);

		[Export ("status", ArgumentSemantic.Assign)]
		PKPaymentAuthorizationStatus Status { get; set; }

		[Export ("paymentSummaryItems", ArgumentSemantic.Copy)]
		PKPaymentSummaryItem[] PaymentSummaryItems { get; set; }

		[Watch (8,0), Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
		[Export ("shippingMethods", ArgumentSemantic.Copy)]
		PKShippingMethod[] ShippingMethods { get; set; }
	}

	[Mac (11,0)]
	[Watch (4,0)][iOS (11,0)]
	[BaseType (typeof (PKPaymentRequestUpdate))]
	[DisableDefaultCtor]
	interface PKPaymentRequestShippingContactUpdate {

		[Export ("initWithErrors:paymentSummaryItems:shippingMethods:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSError[] errors, PKPaymentSummaryItem[] paymentSummaryItems, PKShippingMethod[] shippingMethods);

		[Export ("shippingMethods", ArgumentSemantic.Copy)]
		PKShippingMethod[] ShippingMethods { get; set; }

		[Export ("errors", ArgumentSemantic.Copy)]
		NSError[] Errors { get; set; }
	}

	[Mac (11,0)]
	[Watch (4,0)][iOS (11,0)]
	[BaseType (typeof (PKPaymentRequestUpdate))]
	[DisableDefaultCtor]
	interface PKPaymentRequestShippingMethodUpdate {

		// inlined
		[Export ("initWithPaymentSummaryItems:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKPaymentSummaryItem[] paymentSummaryItems);
	}

	[Mac (11,0)]
	[Watch (4,0)][iOS (11,0)]
	[BaseType (typeof (PKPaymentRequestUpdate))]
	[DisableDefaultCtor]
	interface PKPaymentRequestPaymentMethodUpdate {

		[Watch (6,0), iOS (13,0)]
		[Export ("initWithErrors:paymentSummaryItems:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSError[] errors, PKPaymentSummaryItem [] paymentSummaryItems);

		[Watch (6,0), iOS (13,0)]
		[Export ("errors", ArgumentSemantic.Copy)]
		NSError [] Errors { get; set; }

		// inlined
		[Export ("initWithPaymentSummaryItems:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKPaymentSummaryItem[] paymentSummaryItems);
	}

	[Mac (11,0)]
	[Static] // not to enum'ify - exposed as NSString inside NSError
	interface PKPaymentErrorKeys {

		[Watch (4,0)][iOS (11,0)]
		[Field ("PKPaymentErrorContactFieldUserInfoKey")]
		NSString ContactFieldUserInfoKey { get; }

		[Watch (4,0)][iOS (11,0)]
		[Field ("PKPaymentErrorPostalAddressUserInfoKey")]
		NSString PostalAddressUserInfoKey { get; }
	}

	interface IPKDisbursementAuthorizationControllerDelegate { }

	[NoWatch]
	[NoMac] // both members are not available but, like many times, the protocol is not decorated
	[iOS (12,2)]
	[Protocol, Model]
	[BaseType (typeof (NSObject))]
	interface PKDisbursementAuthorizationControllerDelegate {
		[Abstract]
		[Export ("disbursementAuthorizationController:didAuthorizeWithDisbursementVoucher:")]
		void DidAuthorize (PKDisbursementAuthorizationController controller, PKDisbursementVoucher disbursementVoucher);

		[Abstract]
		[Export ("disbursementAuthorizationControllerDidFinish:")]
		void DidFinish (PKDisbursementAuthorizationController controller);
	}

	[NoWatch]
	[NoMac] // all members are not available but, like many times, the type is not decorated
	[iOS (12,2)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKDisbursementAuthorizationController {

		[Export ("initWithDisbursementRequest:delegate:")]
		IntPtr Constructor (PKDisbursementRequest disbursementRequest, IPKDisbursementAuthorizationControllerDelegate @delegate);

		[Wrap ("WeakDelegate")]
		IPKDisbursementAuthorizationControllerDelegate Delegate { get; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Assign)]
		NSObject WeakDelegate { get; }

		[Async]
		[Export ("authorizeDisbursementWithCompletion:")]
		void AuthorizeDisbursement (Action<bool, NSError> completion);

		[Static]
		[Export ("supportsDisbursements")]
		bool SupportsDisbursements { get; }
	}

	[NoMac] // only used in non-macOS API
	[NoWatch]
	[iOS (12, 2)]
	[Native]
	public enum PKDisbursementRequestSchedule : long {
		OneTime,
		Future,
	}

	[NoWatch]
	[iOS (12, 2)]
	[NoMac] // all members are decorated as such, but not the type itself
	[BaseType (typeof (NSObject))]
	interface PKDisbursementRequest {
		[Export ("amount", ArgumentSemantic.Copy)]
		NSDecimalNumber Amount { get; set; }

		[NullAllowed, Export ("currencyCode")]
		string CurrencyCode { get; set; }

		[Export ("countryCode")]
		string CountryCode { get; set; }

		[NoMac]
		[Export ("requestSchedule", ArgumentSemantic.Assign)]
		PKDisbursementRequestSchedule RequestSchedule { get; set; }

		[NullAllowed, Export ("summaryItems", ArgumentSemantic.Copy)]
		PKPaymentSummaryItem [] SummaryItems { get; set; }
	}

	[NoMac] // all members annoted `API_UNAVAILABLE(...macos)`
	[NoWatch]
	[iOS (12,2)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor] // given from OS to PKDisbursementAuthorizationControllerDelegate
	interface PKDisbursementVoucher {
		[Export ("data", ArgumentSemantic.Copy)]
		NSData Data { get; }

		[Export ("redemptionURL", ArgumentSemantic.Copy)]
		NSUrl RedemptionUrl { get; }
	}

	[Mac (11,0)]
	[Watch (6,2), iOS (13,4)]
	[BaseType (typeof (PKPass))]
	[DisableDefaultCtor]
	interface PKSecureElementPass {

		[Export ("primaryAccountIdentifier")]
		string PrimaryAccountIdentifier { get; }

		[Export ("primaryAccountNumberSuffix")]
		string PrimaryAccountNumberSuffix { get; }

		[Export ("deviceAccountIdentifier", ArgumentSemantic.Strong)]
		string DeviceAccountIdentifier { get; }

		[Export ("deviceAccountNumberSuffix", ArgumentSemantic.Strong)]
		string DeviceAccountNumberSuffix { get; }

		[Export ("passActivationState")]
		PKSecureElementPassActivationState PassActivationState { get; }

		[NullAllowed, Export ("devicePassIdentifier")]
		string DevicePassIdentifier { get; }

		[NullAllowed, Export ("pairedTerminalIdentifier")]
		string PairedTerminalIdentifier { get; }
	}

	[Mac (11,0)]
	[NoWatch, NoTV]
	[iOS (14,0)]
	[MacCatalyst (14,0)]
	[Native]
	public enum PKAddShareablePassConfigurationPrimaryAction : ulong {
		Add,
		Share,
	}

	[Mac (11,0)]
	[Watch (7,0), iOS (14,0)]
	[MacCatalyst (14,0)]
	[NoTV]
	[Native]
	public enum PKBarcodeEventConfigurationDataType : long {
		Unknown,
		SigningKeyMaterial,
		SigningCertificate,
	}

	[NoWatch, NoTV, NoMac]
	[iOS (14,0)]
	[MacCatalyst (14,0)]
	[Native]
	public enum PKIssuerProvisioningExtensionAuthorizationResult : long {
		Canceled,
		Authorized,
	}

	[NoWatch, NoTV]
	[iOS (13,4)]
	[Mac (11,0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKAddSecureElementPassConfiguration {

		[NullAllowed, Export ("issuerIdentifier")]
		string IssuerIdentifier { get; set; }

		[NullAllowed, Export ("localizedDescription")]
		string LocalizedDescription { get; set; }
	}

	[NoWatch, NoTV]
	[Mac (11,0)] // not explicit (no attribute) but headers are present
	[iOS (13,4)]
	[BaseType (typeof (PKAddSecureElementPassConfiguration))]
	// note: `init` is present in headers
	interface PKAddCarKeyPassConfiguration {

		[Export ("password")]
		string Password { get; set; }

		[iOS (14,5)]
		[Mac (11,3)]
		[MacCatalyst (14,5)]
		[Export ("supportedRadioTechnologies", ArgumentSemantic.Assign)]
		PKRadioTechnology SupportedRadioTechnologies { get; set; }
	}

	interface IPKAddSecureElementPassViewControllerDelegate {}

	[NoWatch, NoTV, NoMac] // under `#if TARGET_OS_IOS`
	[iOS (13,4)]
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof (NSObject))]
	interface PKAddSecureElementPassViewControllerDelegate {

		[Deprecated (PlatformName.iOS, 14,0, message: "Use 'DidFinishAddingSecureElementPasses' instead.")]
		[Abstract]
		[Export ("addSecureElementPassViewController:didFinishAddingSecureElementPass:error:")]
		void DidFinishAddingSecureElementPass (PKAddSecureElementPassViewController controller, [NullAllowed] PKSecureElementPass pass, [NullAllowed] NSError error);
	
		[Abstract]
		[Export ("addSecureElementPassViewController:didFinishAddingSecureElementPasses:error:")]
		void DidFinishAddingSecureElementPasses (PKAddSecureElementPassViewController controller, [NullAllowed] PKSecureElementPass[] passes, [NullAllowed] NSError error);
}

	[NoWatch, NoTV, NoMac] // under `#if TARGET_OS_IOS`
	[iOS (13,4)]
	[MacCatalyst (14,0)] // doc mention 13.4 but we can't load the class
	[BaseType (typeof (UIViewController))]
	[DisableDefaultCtor]
	interface PKAddSecureElementPassViewController {

		[Static]
		[Export ("canAddSecureElementPassWithConfiguration:")]
		bool CanAddSecureElementPass (PKAddSecureElementPassConfiguration configuration);

		[Export ("initWithConfiguration:delegate:")]
		IntPtr Constructor (PKAddSecureElementPassConfiguration configuration, [NullAllowed] IPKAddSecureElementPassViewControllerDelegate @delegate);

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		IPKAddSecureElementPassViewControllerDelegate Delegate { get; set; }

		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	[NoWatch, NoTV]
	[iOS (14,0)]
	[Mac (11,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKShareablePassMetadata {

		[Export ("initWithProvisioningCredentialIdentifier:cardConfigurationIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:")]
		IntPtr Constructor (string credentialIdentifier, string cardConfigurationIdentifier, string sharingInstanceIdentifier, CGImage passThumbnailImage, string ownerDisplayName, string localizedDescription);

		[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
		[Export ("initWithProvisioningCredentialIdentifier:sharingInstanceIdentifier:passThumbnailImage:ownerDisplayName:localizedDescription:accountHash:templateIdentifier:relyingPartyIdentifier:requiresUnifiedAccessCapableDevice:")]
		IntPtr Constructor (string credentialIdentifier, string sharingInstanceIdentifier, CGImage passThumbnailImage, string ownerDisplayName, string localizedDescription, string accountHash, string templateIdentifier, string relyingPartyIdentifier, bool requiresUnifiedAccessCapableDevice);

		[Export ("credentialIdentifier", ArgumentSemantic.Strong)]
		string CredentialIdentifier { get; }

		[Export ("cardConfigurationIdentifier", ArgumentSemantic.Strong)]
		string CardConfigurationIdentifier { get; }

		[Export ("sharingInstanceIdentifier", ArgumentSemantic.Strong)]
		string SharingInstanceIdentifier { get; }

		[Export ("passThumbnailImage")]
		CGImage PassThumbnailImage { get; }

		[Export ("localizedDescription", ArgumentSemantic.Strong)]
		string LocalizedDescription { get; }

		[Export ("ownerDisplayName", ArgumentSemantic.Strong)]
		string OwnerDisplayName { get; }

		[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
		[Export ("accountHash", ArgumentSemantic.Strong)]
		string AccountHash { get; }

		[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
		[Export ("templateIdentifier", ArgumentSemantic.Strong)]
		string TemplateIdentifier { get; }

		[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
		[Export ("relyingPartyIdentifier", ArgumentSemantic.Strong)]
		string RelyingPartyIdentifier { get; }

		[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
		[Export ("requiresUnifiedAccessCapableDevice")]
		bool RequiresUnifiedAccessCapableDevice { get; }
	}

	[NoWatch, NoTV]
	[iOS (14,0)]
	[Mac (11,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (PKAddSecureElementPassConfiguration))]
	[DisableDefaultCtor]
	interface PKAddShareablePassConfiguration {

		[Async]
		[Static]
		[Export ("configurationForPassMetadata:provisioningPolicyIdentifier:primaryAction:completion:")]
		void GetConfiguration (PKShareablePassMetadata[] passMetadata, string provisioningPolicyIdentifier, PKAddShareablePassConfigurationPrimaryAction action, Action<PKAddShareablePassConfiguration, NSError> completion);

		[Export ("primaryAction")]
		PKAddShareablePassConfigurationPrimaryAction PrimaryAction { get; }

		[Export ("credentialsMetadata", ArgumentSemantic.Strong)]
		PKShareablePassMetadata[] CredentialsMetadata { get; }

		[Export ("provisioningPolicyIdentifier", ArgumentSemantic.Strong)]
		string ProvisioningPolicyIdentifier { get; }
	}

	[Mac (11,0)]
	[Watch (7,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKBarcodeEventConfigurationRequest {

		[Export ("deviceAccountIdentifier")]
		string DeviceAccountIdentifier { get; }

		[Export ("configurationData")]
		NSData ConfigurationData { get; }

		[Export ("configurationDataType")]
		PKBarcodeEventConfigurationDataType ConfigurationDataType { get; }
	}

	[Mac (11,0)]
	[Watch (7,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKBarcodeEventMetadataRequest {

		[Export ("deviceAccountIdentifier")]
		string DeviceAccountIdentifier { get; }

		[Export ("lastUsedBarcodeIdentifier")]
		string LastUsedBarcodeIdentifier { get; }
	}

	[Mac (11,0)]
	[Watch (7,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKBarcodeEventMetadataResponse {

		[Export ("initWithPaymentInformation:")]
		IntPtr Constructor (NSData paymentInformation);

		[Export ("paymentInformation", ArgumentSemantic.Copy)]
		NSData PaymentInformation { get; set; }
	}

	[Mac (11,0)]
	[Watch (7,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKBarcodeEventSignatureRequest {

		[Export ("deviceAccountIdentifier")]
		string DeviceAccountIdentifier { get; }

		[Export ("transactionIdentifier")]
		string TransactionIdentifier { get; }

		[Export ("barcodeIdentifier")]
		string BarcodeIdentifier { get; }

		[Export ("rawMerchantName")]
		string RawMerchantName { get; }

		[Export ("merchantName")]
		string MerchantName { get; }

		[Export ("transactionDate", ArgumentSemantic.Strong)]
		NSDate TransactionDate { get; }

		[Export ("currencyCode")]
		string CurrencyCode { get; }

		// NSDecimalNumber is used elsewhere (but it's a subclass for NSNumber and can't be used here)
		[Export ("amount", ArgumentSemantic.Strong)]
		NSNumber Amount { get; }

		[Export ("transactionStatus")]
		string TransactionStatus { get; }

		[Export ("partialSignature", ArgumentSemantic.Copy)]
		NSData PartialSignature { get; }
	}

	[Mac (11,0)]
	[Watch (7,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[NoTV]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKBarcodeEventSignatureResponse {

		[Export ("initWithSignedData:")]
		IntPtr Constructor (NSData signedData);

		[Export ("signedData", ArgumentSemantic.Copy)]
		NSData SignedData { get; set; }
	}

	[NoWatch, NoTV]
	[iOS (14,0)]
	[Mac (11,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (NSObject))]
	[DesignatedDefaultCtor]
	interface PKIssuerProvisioningExtensionStatus {

		[Export ("requiresAuthentication")]
		bool RequiresAuthentication { get; set; }

		[Export ("passEntriesAvailable")]
		bool PassEntriesAvailable { get; set; }

		[Export ("remotePassEntriesAvailable")]
		bool RemotePassEntriesAvailable { get; set; }
	}

	[NoWatch, NoTV]
	[iOS (14,0)]
	[Mac (11,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKIssuerProvisioningExtensionPassEntry {

		[Export ("identifier")]
		string Identifier { get; }

		[Export ("title")]
		string Title { get; }

		[Export ("art")]
		CGImage Art { get; }
	}

	[NoWatch, NoTV, NoMac]
	[iOS (14,0)]
	[NoMacCatalyst] // type cannot be loaded, lack of documentation about usage
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKIssuerProvisioningExtensionHandler {

		[Async]
		[Export ("statusWithCompletion:")]
		void GetStatus (Action<PKIssuerProvisioningExtensionStatus> completion);

		[Async]
		[Export ("passEntriesWithCompletion:")]
		void PassEntries (Action<PKIssuerProvisioningExtensionPassEntry[]> completion);

		[Async]
		[Export ("remotePassEntriesWithCompletion:")]
		void RemotePassEntries (Action<PKIssuerProvisioningExtensionPassEntry[]> completion);

		[Async]
		[Export ("generateAddPaymentPassRequestForPassEntryWithIdentifier:configuration:certificateChain:nonce:nonceSignature:completionHandler:")]
		void GenerateAddPaymentPassRequest (string identifier, PKAddPaymentPassRequestConfiguration configuration, NSData[] certificates, NSData nonce, NSData nonceSignature, Action<PKAddPaymentPassRequest> completion);
	}

	[NoWatch, NoTV, NoMac]
	[iOS (14,0)]
	[MacCatalyst (14,0)]
	[Protocol]
	interface PKIssuerProvisioningExtensionAuthorizationProviding {

		[Abstract]
		[NullAllowed, Export ("completionHandler", ArgumentSemantic.Copy)]
		Action<PKIssuerProvisioningExtensionAuthorizationResult> CompletionHandler { get; set; }
	}

	[NoWatch, NoTV, NoMac]
	[iOS (14,0)]
	[MacCatalyst (14,0)]
	delegate void PKInformationRequestCompletionBlock (PKBarcodeEventMetadataResponse response);

	[NoWatch, NoTV, NoMac]
	[iOS (14,0)]
	[MacCatalyst (14,0)]
	delegate void PKSignatureRequestCompletionBlock (PKBarcodeEventSignatureResponse response);

	[NoTV]
	[Mac (11,0)]
	[Watch (7,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[Protocol]
	interface PKPaymentInformationRequestHandling {

		[Abstract]
		[Export ("handleInformationRequest:completion:")]
		void HandleInformationRequest (PKBarcodeEventMetadataRequest infoRequest, PKInformationRequestCompletionBlock completion);

		[Abstract]
		[Export ("handleSignatureRequest:completion:")]
		void HandleSignatureRequest (PKBarcodeEventSignatureRequest signatureRequest, PKSignatureRequestCompletionBlock completion);

		[Abstract]
		[Export ("handleConfigurationRequest:completion:")]
		void HandleConfigurationRequest (PKBarcodeEventConfigurationRequest configurationRequest, Action completion);
	}

	[NoWatch, NoTV]
	[iOS (14,0)]
	[Mac (11,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (PKIssuerProvisioningExtensionPassEntry))]
	[DisableDefaultCtor]
	interface PKIssuerProvisioningExtensionPaymentPassEntry {

		[Export ("initWithIdentifier:title:art:addRequestConfiguration:")]
		[DesignatedInitializer]
		IntPtr Constructor (string identifier, string title, CGImage art, PKAddPaymentPassRequestConfiguration configuration);

		[Export ("addRequestConfiguration")]
		PKAddPaymentPassRequestConfiguration AddRequestConfiguration { get; }
	}

	[NoTV]
	[Watch (7,0)][Mac (11,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKPaymentMerchantSession {

		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dictionary);
	}

	[NoTV]
	[Watch (7,0)][Mac (11,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (NSObject))]
	interface PKPaymentRequestMerchantSessionUpdate {

		[Export ("initWithStatus:merchantSession:")]
		IntPtr Constructor (PKPaymentAuthorizationStatus status, [NullAllowed] PKPaymentMerchantSession session);

		[Export ("status", ArgumentSemantic.Assign)]
		PKPaymentAuthorizationStatus Status { get; set; }

		[NullAllowed, Export ("session", ArgumentSemantic.Strong)]
		PKPaymentMerchantSession Session { get; set; }
	}

	[NoWatch, Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
	[BaseType (typeof(PKPaymentRequestUpdate))]
	[DisableDefaultCtor]
	interface PKPaymentRequestCouponCodeUpdate
	{
		[Export ("initWithPaymentSummaryItems:")]
		[DesignatedInitializer]
		IntPtr Constructor (PKPaymentSummaryItem[] paymentSummaryItems);

		[Export ("initWithErrors:paymentSummaryItems:shippingMethods:")]
		[DesignatedInitializer]
		IntPtr Constructor ([NullAllowed] NSError[] errors, PKPaymentSummaryItem[] paymentSummaryItems, PKShippingMethod[] shippingMethods);

		[NullAllowed, Export ("errors", ArgumentSemantic.Copy)]
		NSError[] Errors { get; set; }
	}

	[Watch (7,0)][Mac (11,0)][iOS (14,0)]
	[MacCatalyst (14,0)]
	[BaseType (typeof (NSObject))]
	[DisableDefaultCtor]
	interface PKPaymentInformationEventExtension {
	}

	[iOS (14,5)]
	[Flags]
	[Native]
	enum PKRadioTechnology : ulong {
		None = 0,
		Nfc = 1 << 0,
		Bluetooth = 1 << 1,
	}

	[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PKDateComponentsRange : NSCopying, NSSecureCoding
	{
		[Export ("initWithStartDateComponents:endDateComponents:")]
		[return: NullAllowed]
		IntPtr Constructor (NSDateComponents startDateComponents, NSDateComponents endDateComponents);

		[Export ("startDateComponents", ArgumentSemantic.Copy)]
		NSDateComponents StartDateComponents { get; }

		[Export ("endDateComponents", ArgumentSemantic.Copy)]
		NSDateComponents EndDateComponents { get; }
	}

	[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
	[BaseType (typeof(PKPaymentSummaryItem))]
	[DisableDefaultCtor]
	interface PKDeferredPaymentSummaryItem
	{
		[Export ("deferredDate", ArgumentSemantic.Copy)]
		NSDate DeferredDate { get; set; }
	}

	[Watch (8,0), Mac (12,0), iOS (15,0), MacCatalyst (15,0)]
	[Native]
	public enum PKShippingContactEditingMode : ulong
	{
		Enabled = 1,
		StorePickup,
	}

	[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
	[BaseType (typeof(PKPaymentSummaryItem))]
	[DisableDefaultCtor]
	interface PKRecurringPaymentSummaryItem
	{
		[NullAllowed, Export ("startDate", ArgumentSemantic.Copy)]
		NSDate StartDate { get; set; }

		[Export ("intervalUnit", ArgumentSemantic.Assign)]
		NSCalendarUnit IntervalUnit { get; set; }

		[Export ("intervalCount")]
		nint IntervalCount { get; set; }

		[NullAllowed, Export ("endDate", ArgumentSemantic.Copy)]
		NSDate EndDate { get; set; }
	}

	[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
	public enum PKStoredValuePassBalanceType
	{
		[Field ("PKStoredValuePassBalanceTypeCash")]
		Cash,
		[Field ("PKStoredValuePassBalanceTypeLoyaltyPoints")]
		LoyaltyPoints,
	}

	[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PKStoredValuePassBalance
	{
		[Export ("amount", ArgumentSemantic.Strong)]
		NSDecimalNumber Amount { get; }

		[NullAllowed, Export ("currencyCode")]
		string CurrencyCode { get; }

		[Export ("balanceType")]
		string BalanceType { get; }

		[NullAllowed, Export ("expiryDate", ArgumentSemantic.Strong)]
		NSDate ExpiryDate { get; }

		[Export ("isEqualToBalance:")]
		bool IsEqual (PKStoredValuePassBalance balance);
	}

	[Watch (8,0), iOS (15,0), Mac (12,0), MacCatalyst (15,0)]
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface PKStoredValuePassProperties
	{
		[Static]
		[Export ("passPropertiesForPass:")]
		[return: NullAllowed]
		PKStoredValuePassProperties GetPassProperties (PKPass pass);

		[Export ("blocked")]
		bool Blocked { [Bind ("isBlocked")] get; }

		[NullAllowed, Export ("expirationDate", ArgumentSemantic.Copy)]
		NSDate ExpirationDate { get; }

		[Export ("balances", ArgumentSemantic.Copy)]
		PKStoredValuePassBalance[] Balances { get; }
	}
}
