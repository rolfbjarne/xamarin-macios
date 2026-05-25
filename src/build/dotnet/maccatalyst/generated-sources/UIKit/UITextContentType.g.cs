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
using Metal;
using CoreML;
using AppKit;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace UIKit {
	/// <summary>Known values for <see cref="UIKit.UITextField.TextContentType" /> that are hints to the system of the kind of <see cref="T:UIKit.UITextField" /> data.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("tvos")]
	public unsafe static partial class UITextContentType  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddressCity;
		/// <summary>Indicates a text fieldn address field that contains a city name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeAddressCity",  "UIKit")]
		public static NSString AddressCity {
			get {
				if (_AddressCity is null)
					_AddressCity = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeAddressCity")!;
				return _AddressCity;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddressCityAndState;
		/// <summary>Indicates a text fieldn address field that contains a city name and state name or state code.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeAddressCityAndState",  "UIKit")]
		public static NSString AddressCityAndState {
			get {
				if (_AddressCityAndState is null)
					_AddressCityAndState = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeAddressCityAndState")!;
				return _AddressCityAndState;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _AddressState;
		/// <summary>Indicates a text fieldn address field that holds a state name or state code.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeAddressState",  "UIKit")]
		public static NSString AddressState {
			get {
				if (_AddressState is null)
					_AddressState = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeAddressState")!;
				return _AddressState;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Birthdate;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeBirthdate'.</summary>
		[Field ("UITextContentTypeBirthdate",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString Birthdate {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_Birthdate is null)
					_Birthdate = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeBirthdate")!;
				return _Birthdate;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BirthdateDay;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeBirthdateDay'.</summary>
		[Field ("UITextContentTypeBirthdateDay",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString BirthdateDay {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_BirthdateDay is null)
					_BirthdateDay = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeBirthdateDay")!;
				return _BirthdateDay;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BirthdateMonth;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeBirthdateMonth'.</summary>
		[Field ("UITextContentTypeBirthdateMonth",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString BirthdateMonth {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_BirthdateMonth is null)
					_BirthdateMonth = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeBirthdateMonth")!;
				return _BirthdateMonth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _BirthdateYear;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeBirthdateYear'.</summary>
		[Field ("UITextContentTypeBirthdateYear",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString BirthdateYear {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_BirthdateYear is null)
					_BirthdateYear = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeBirthdateYear")!;
				return _BirthdateYear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellularEid;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCellularEID'.</summary>
		[Field ("UITextContentTypeCellularEID",  "UIKit")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		public static NSString CellularEid {
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			get {
				if (_CellularEid is null)
					_CellularEid = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCellularEID")!;
				return _CellularEid;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CellularImei;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCellularIMEI'.</summary>
		[Field ("UITextContentTypeCellularIMEI",  "UIKit")]
		[SupportedOSPlatform ("ios17.4")]
		[SupportedOSPlatform ("maccatalyst17.4")]
		[SupportedOSPlatform ("tvos17.4")]
		public static NSString CellularImei {
			[SupportedOSPlatform ("ios17.4")]
			[SupportedOSPlatform ("maccatalyst17.4")]
			[SupportedOSPlatform ("tvos17.4")]
			get {
				if (_CellularImei is null)
					_CellularImei = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCellularIMEI")!;
				return _CellularImei;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CountryName;
		/// <summary>Indicates a text fieldn address field that holds the name of a country.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeCountryName",  "UIKit")]
		public static NSString CountryName {
			get {
				if (_CountryName is null)
					_CountryName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCountryName")!;
				return _CountryName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardExpiration;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardExpiration'.</summary>
		[Field ("UITextContentTypeCreditCardExpiration",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardExpiration {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardExpiration is null)
					_CreditCardExpiration = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardExpiration")!;
				return _CreditCardExpiration;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardExpirationMonth;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardExpirationMonth'.</summary>
		[Field ("UITextContentTypeCreditCardExpirationMonth",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardExpirationMonth {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardExpirationMonth is null)
					_CreditCardExpirationMonth = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardExpirationMonth")!;
				return _CreditCardExpirationMonth;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardExpirationYear;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardExpirationYear'.</summary>
		[Field ("UITextContentTypeCreditCardExpirationYear",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardExpirationYear {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardExpirationYear is null)
					_CreditCardExpirationYear = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardExpirationYear")!;
				return _CreditCardExpirationYear;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardFamilyName;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardFamilyName'.</summary>
		[Field ("UITextContentTypeCreditCardFamilyName",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardFamilyName {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardFamilyName is null)
					_CreditCardFamilyName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardFamilyName")!;
				return _CreditCardFamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardGivenName;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardGivenName'.</summary>
		[Field ("UITextContentTypeCreditCardGivenName",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardGivenName {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardGivenName is null)
					_CreditCardGivenName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardGivenName")!;
				return _CreditCardGivenName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardMiddleName;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardMiddleName'.</summary>
		[Field ("UITextContentTypeCreditCardMiddleName",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardMiddleName {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardMiddleName is null)
					_CreditCardMiddleName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardMiddleName")!;
				return _CreditCardMiddleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardName;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardName'.</summary>
		[Field ("UITextContentTypeCreditCardName",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardName {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardName is null)
					_CreditCardName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardName")!;
				return _CreditCardName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardNumber;
		/// <summary>Indicates a text field that holds a credit-card number.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeCreditCardNumber",  "UIKit")]
		public static NSString CreditCardNumber {
			get {
				if (_CreditCardNumber is null)
					_CreditCardNumber = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardNumber")!;
				return _CreditCardNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardSecurityCode;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardSecurityCode'.</summary>
		[Field ("UITextContentTypeCreditCardSecurityCode",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardSecurityCode {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardSecurityCode is null)
					_CreditCardSecurityCode = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardSecurityCode")!;
				return _CreditCardSecurityCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _CreditCardType;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeCreditCardType'.</summary>
		[Field ("UITextContentTypeCreditCardType",  "UIKit")]
		[SupportedOSPlatform ("ios17.0")]
		[SupportedOSPlatform ("maccatalyst17.0")]
		[SupportedOSPlatform ("tvos17.0")]
		public static NSString CreditCardType {
			[SupportedOSPlatform ("ios17.0")]
			[SupportedOSPlatform ("maccatalyst17.0")]
			[SupportedOSPlatform ("tvos17.0")]
			get {
				if (_CreditCardType is null)
					_CreditCardType = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeCreditCardType")!;
				return _CreditCardType;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DateTime;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeDateTime'.</summary>
		[Field ("UITextContentTypeDateTime",  "UIKit")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString DateTime {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_DateTime is null)
					_DateTime = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeDateTime")!;
				return _DateTime;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmailAddress;
		/// <summary>Indicates a text field that holds an email address.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeEmailAddress",  "UIKit")]
		public static NSString EmailAddress {
			get {
				if (_EmailAddress is null)
					_EmailAddress = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeEmailAddress")!;
				return _EmailAddress;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FamilyName;
		/// <summary>Indicates a text field that holds a family name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeFamilyName",  "UIKit")]
		public static NSString FamilyName {
			get {
				if (_FamilyName is null)
					_FamilyName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeFamilyName")!;
				return _FamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FlightNumber;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeFlightNumber'.</summary>
		[Field ("UITextContentTypeFlightNumber",  "UIKit")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString FlightNumber {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_FlightNumber is null)
					_FlightNumber = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeFlightNumber")!;
				return _FlightNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FullStreetAddress;
		/// <summary>Indicates a text fieldn address field that holds a complete street address, which may have several parts.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeFullStreetAddress",  "UIKit")]
		public static NSString FullStreetAddress {
			get {
				if (_FullStreetAddress is null)
					_FullStreetAddress = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeFullStreetAddress")!;
				return _FullStreetAddress;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GivenName;
		/// <summary>Indicates a text field that holds a given name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeGivenName",  "UIKit")]
		public static NSString GivenName {
			get {
				if (_GivenName is null)
					_GivenName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeGivenName")!;
				return _GivenName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JobTitle;
		/// <summary>Indicates a text field that holds the title of a job.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeJobTitle",  "UIKit")]
		public static NSString JobTitle {
			get {
				if (_JobTitle is null)
					_JobTitle = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeJobTitle")!;
				return _JobTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Location;
		/// <summary>Indicates a text field that holds a precise location (such as an address, latitude and longitude coordinates, or a named point of interest).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeLocation",  "UIKit")]
		public static NSString Location {
			get {
				if (_Location is null)
					_Location = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeLocation")!;
				return _Location;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MiddleName;
		/// <summary>Indicates a text field that holds a middle name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeMiddleName",  "UIKit")]
		public static NSString MiddleName {
			get {
				if (_MiddleName is null)
					_MiddleName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeMiddleName")!;
				return _MiddleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Name;
		/// <summary>Indicates a text field that holds a name, which may consist of several parts.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeName",  "UIKit")]
		public static NSString Name {
			get {
				if (_Name is null)
					_Name = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeName")!;
				return _Name;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NamePrefix;
		/// <summary>Indicates a text field that holds a name prefix such as an honorific ("Mr.", "Ms.", "Dr.", etc.).</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeNamePrefix",  "UIKit")]
		public static NSString NamePrefix {
			get {
				if (_NamePrefix is null)
					_NamePrefix = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeNamePrefix")!;
				return _NamePrefix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameSuffix;
		/// <summary>Indicates a text field that holds the suffix to a name (e.g., "Jr.").</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeNameSuffix",  "UIKit")]
		public static NSString NameSuffix {
			get {
				if (_NameSuffix is null)
					_NameSuffix = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeNameSuffix")!;
				return _NameSuffix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NewPassword;
		/// <summary>Indicates a text field that accepts a new password.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeNewPassword",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString NewPassword {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_NewPassword is null)
					_NewPassword = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeNewPassword")!;
				return _NewPassword;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Nickname;
		/// <summary>Indicates a text field that holds a preferred name.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeNickname",  "UIKit")]
		public static NSString Nickname {
			get {
				if (_Nickname is null)
					_Nickname = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeNickname")!;
				return _Nickname;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OneTimeCode;
		/// <summary>Indicates a text field that accepts a one-time passcode.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeOneTimeCode",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString OneTimeCode {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_OneTimeCode is null)
					_OneTimeCode = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeOneTimeCode")!;
				return _OneTimeCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrganizationName;
		/// <summary>Indicates a text field that holds the name of an organization.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeOrganizationName",  "UIKit")]
		public static NSString OrganizationName {
			get {
				if (_OrganizationName is null)
					_OrganizationName = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeOrganizationName")!;
				return _OrganizationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Password;
		/// <summary>Indicates a text field password field.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypePassword",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Password {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Password is null)
					_Password = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypePassword")!;
				return _Password;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostalCode;
		/// <summary>Indicates a text field that holds a postal code.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypePostalCode",  "UIKit")]
		public static NSString PostalCode {
			get {
				if (_PostalCode is null)
					_PostalCode = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypePostalCode")!;
				return _PostalCode;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ShipmentTrackingNumber;
		/// <summary>Represents the value associated with the constant 'UITextContentTypeShipmentTrackingNumber'.</summary>
		[Field ("UITextContentTypeShipmentTrackingNumber",  "UIKit")]
		[SupportedOSPlatform ("tvos15.0")]
		[SupportedOSPlatform ("ios15.0")]
		[SupportedOSPlatform ("maccatalyst")]
		public static NSString ShipmentTrackingNumber {
			[SupportedOSPlatform ("tvos15.0")]
			[SupportedOSPlatform ("ios15.0")]
			[SupportedOSPlatform ("maccatalyst")]
			get {
				if (_ShipmentTrackingNumber is null)
					_ShipmentTrackingNumber = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeShipmentTrackingNumber")!;
				return _ShipmentTrackingNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StreetAddressLine1;
		/// <summary>Indicates a text fieldn address field that holds the first line of a street address.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeStreetAddressLine1",  "UIKit")]
		public static NSString StreetAddressLine1 {
			get {
				if (_StreetAddressLine1 is null)
					_StreetAddressLine1 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeStreetAddressLine1")!;
				return _StreetAddressLine1;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _StreetAddressLine2;
		/// <summary>Indicates a text fieldn address field that holds the second line of a street address.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeStreetAddressLine2",  "UIKit")]
		public static NSString StreetAddressLine2 {
			get {
				if (_StreetAddressLine2 is null)
					_StreetAddressLine2 = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeStreetAddressLine2")!;
				return _StreetAddressLine2;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Sublocality;
		/// <summary>Indicates a text fieldn address field that holds a sublocality, such as a county.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeSublocality",  "UIKit")]
		public static NSString Sublocality {
			get {
				if (_Sublocality is null)
					_Sublocality = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeSublocality")!;
				return _Sublocality;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _TelephoneNumber;
		/// <summary>Indicates a text field field that holds a telephone number.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeTelephoneNumber",  "UIKit")]
		public static NSString TelephoneNumber {
			get {
				if (_TelephoneNumber is null)
					_TelephoneNumber = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeTelephoneNumber")!;
				return _TelephoneNumber;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Url;
		/// <summary>Indicates a text field field that holds a URL.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeURL",  "UIKit")]
		public static NSString Url {
			get {
				if (_Url is null)
					_Url = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeURL")!;
				return _Url;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Username;
		/// <summary>Indicates a text field user name field.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("UITextContentTypeUsername",  "UIKit")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("tvos")]
		public static NSString Username {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("tvos")]
			get {
				if (_Username is null)
					_Username = Dlfcn.GetStringConstant (Libraries.UIKit.Handle, "UITextContentTypeUsername")!;
				return _Username;
			}
		}
	} /* class UITextContentType */
}
