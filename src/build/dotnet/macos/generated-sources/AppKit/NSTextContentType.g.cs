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
using Metal;
using CoreML;
using OpenGL;
using AppKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using CloudKit;
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
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace AppKit {
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	public enum NSTextContentType : int {
		Username = 0,
		Password = 1,
		OneTimeCode = 2,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		AddressCity = 3,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		AddressCityAndState = 4,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		AddressState = 5,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Birthdate = 6,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		BirthdateDay = 7,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		BirthdateMonth = 8,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		BirthdateYear = 9,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CountryName = 10,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardExpiration = 11,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardExpirationMonth = 12,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardExpirationYear = 13,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardFamilyName = 14,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardGivenName = 15,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardMiddleName = 16,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardName = 17,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardNumber = 18,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardSecurityCode = 19,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		CreditCardType = 20,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		DateTime = 21,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		EmailAddress = 22,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		FamilyName = 23,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		FlightNumber = 24,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		FullStreetAddress = 25,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		GivenName = 26,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		JobTitle = 27,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Location = 28,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		MiddleName = 29,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Name = 30,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		NamePrefix = 31,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		NameSuffix = 32,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		NewPassword = 33,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Nickname = 34,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		OrganizationName = 35,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		PostalCode = 36,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		ShipmentTrackingNumber = 37,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		StreetAddressLine1 = 38,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		AddressLine2 = 39,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Sublocality = 40,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		TelephoneNumber = 41,
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		Url = 42,
	}
	/// <summary>Extension methods for the <see cref="global::AppKit.NSTextContentType" /> enumeration.</summary>
	[UnsupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class NSTextContentTypeExtensions {
		static IntPtr[] values = new IntPtr [43];
		[Field ("NSTextContentTypeUsername", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeUsername {
			get {
				fixed (IntPtr *storage = &values [0])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeUsername", storage);
			}
		}
		[Field ("NSTextContentTypePassword", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypePassword {
			get {
				fixed (IntPtr *storage = &values [1])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypePassword", storage);
			}
		}
		[Field ("NSTextContentTypeOneTimeCode", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeOneTimeCode {
			get {
				fixed (IntPtr *storage = &values [2])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeOneTimeCode", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeAddressCity", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeAddressCity {
			get {
				fixed (IntPtr *storage = &values [3])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeAddressCity", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeAddressCityAndState", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeAddressCityAndState {
			get {
				fixed (IntPtr *storage = &values [4])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeAddressCityAndState", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeAddressState", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeAddressState {
			get {
				fixed (IntPtr *storage = &values [5])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeAddressState", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeBirthdate", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeBirthdate {
			get {
				fixed (IntPtr *storage = &values [6])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeBirthdate", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeBirthdateDay", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeBirthdateDay {
			get {
				fixed (IntPtr *storage = &values [7])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeBirthdateDay", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeBirthdateMonth", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeBirthdateMonth {
			get {
				fixed (IntPtr *storage = &values [8])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeBirthdateMonth", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeBirthdateYear", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeBirthdateYear {
			get {
				fixed (IntPtr *storage = &values [9])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeBirthdateYear", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCountryName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCountryName {
			get {
				fixed (IntPtr *storage = &values [10])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCountryName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardExpiration", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardExpiration {
			get {
				fixed (IntPtr *storage = &values [11])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardExpiration", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardExpirationMonth", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardExpirationMonth {
			get {
				fixed (IntPtr *storage = &values [12])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardExpirationMonth", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardExpirationYear", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardExpirationYear {
			get {
				fixed (IntPtr *storage = &values [13])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardExpirationYear", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardFamilyName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardFamilyName {
			get {
				fixed (IntPtr *storage = &values [14])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardFamilyName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardGivenName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardGivenName {
			get {
				fixed (IntPtr *storage = &values [15])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardGivenName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardMiddleName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardMiddleName {
			get {
				fixed (IntPtr *storage = &values [16])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardMiddleName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardName {
			get {
				fixed (IntPtr *storage = &values [17])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardNumber", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardNumber {
			get {
				fixed (IntPtr *storage = &values [18])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardNumber", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardSecurityCode", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardSecurityCode {
			get {
				fixed (IntPtr *storage = &values [19])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardSecurityCode", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeCreditCardType", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeCreditCardType {
			get {
				fixed (IntPtr *storage = &values [20])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeCreditCardType", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeDateTime", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeDateTime {
			get {
				fixed (IntPtr *storage = &values [21])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeDateTime", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeEmailAddress", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeEmailAddress {
			get {
				fixed (IntPtr *storage = &values [22])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeEmailAddress", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeFamilyName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeFamilyName {
			get {
				fixed (IntPtr *storage = &values [23])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeFamilyName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeFlightNumber", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeFlightNumber {
			get {
				fixed (IntPtr *storage = &values [24])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeFlightNumber", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeFullStreetAddress", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeFullStreetAddress {
			get {
				fixed (IntPtr *storage = &values [25])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeFullStreetAddress", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeGivenName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeGivenName {
			get {
				fixed (IntPtr *storage = &values [26])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeGivenName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeJobTitle", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeJobTitle {
			get {
				fixed (IntPtr *storage = &values [27])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeJobTitle", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeLocation", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeLocation {
			get {
				fixed (IntPtr *storage = &values [28])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeLocation", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeMiddleName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeMiddleName {
			get {
				fixed (IntPtr *storage = &values [29])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeMiddleName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeName {
			get {
				fixed (IntPtr *storage = &values [30])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeNamePrefix", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeNamePrefix {
			get {
				fixed (IntPtr *storage = &values [31])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeNamePrefix", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeNameSuffix", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeNameSuffix {
			get {
				fixed (IntPtr *storage = &values [32])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeNameSuffix", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeNewPassword", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeNewPassword {
			get {
				fixed (IntPtr *storage = &values [33])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeNewPassword", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeNickname", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeNickname {
			get {
				fixed (IntPtr *storage = &values [34])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeNickname", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeOrganizationName", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeOrganizationName {
			get {
				fixed (IntPtr *storage = &values [35])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeOrganizationName", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypePostalCode", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypePostalCode {
			get {
				fixed (IntPtr *storage = &values [36])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypePostalCode", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeShipmentTrackingNumber", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeShipmentTrackingNumber {
			get {
				fixed (IntPtr *storage = &values [37])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeShipmentTrackingNumber", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeStreetAddressLine1", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeStreetAddressLine1 {
			get {
				fixed (IntPtr *storage = &values [38])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeStreetAddressLine1", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeStreetAddressLine2", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeStreetAddressLine2 {
			get {
				fixed (IntPtr *storage = &values [39])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeStreetAddressLine2", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeSublocality", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeSublocality {
			get {
				fixed (IntPtr *storage = &values [40])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeSublocality", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeTelephoneNumber", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeTelephoneNumber {
			get {
				fixed (IntPtr *storage = &values [41])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeTelephoneNumber", storage);
			}
		}
		[SupportedOSPlatform ("macos14.0")]
		[UnsupportedOSPlatform ("maccatalyst")]
		[Field ("NSTextContentTypeURL", "AppKit")]
		internal unsafe static IntPtr NSTextContentTypeURL {
			get {
				fixed (IntPtr *storage = &values [42])
					return Dlfcn.CachePointer (Libraries.AppKit.Handle, "NSTextContentTypeURL", storage);
			}
		}
		/// <summary>Retrieves the <see cref="global::Foundation.NSString" /> constant that describes <paramref name="self" />.</summary>
		/// <param name="self">The instance on which this method operates.</param>
		public static NSString? GetConstant (this NSTextContentType self)
		{
			IntPtr ptr = IntPtr.Zero;
			switch ((int) self) {
			case 0: // NSTextContentType.Username
				ptr = NSTextContentTypeUsername;
				break;
			case 1: // NSTextContentType.Password
				ptr = NSTextContentTypePassword;
				break;
			case 2: // NSTextContentType.OneTimeCode
				ptr = NSTextContentTypeOneTimeCode;
				break;
			case 3: // NSTextContentType.AddressCity
				ptr = NSTextContentTypeAddressCity;
				break;
			case 4: // NSTextContentType.AddressCityAndState
				ptr = NSTextContentTypeAddressCityAndState;
				break;
			case 5: // NSTextContentType.AddressState
				ptr = NSTextContentTypeAddressState;
				break;
			case 6: // NSTextContentType.Birthdate
				ptr = NSTextContentTypeBirthdate;
				break;
			case 7: // NSTextContentType.BirthdateDay
				ptr = NSTextContentTypeBirthdateDay;
				break;
			case 8: // NSTextContentType.BirthdateMonth
				ptr = NSTextContentTypeBirthdateMonth;
				break;
			case 9: // NSTextContentType.BirthdateYear
				ptr = NSTextContentTypeBirthdateYear;
				break;
			case 10: // NSTextContentType.CountryName
				ptr = NSTextContentTypeCountryName;
				break;
			case 11: // NSTextContentType.CreditCardExpiration
				ptr = NSTextContentTypeCreditCardExpiration;
				break;
			case 12: // NSTextContentType.CreditCardExpirationMonth
				ptr = NSTextContentTypeCreditCardExpirationMonth;
				break;
			case 13: // NSTextContentType.CreditCardExpirationYear
				ptr = NSTextContentTypeCreditCardExpirationYear;
				break;
			case 14: // NSTextContentType.CreditCardFamilyName
				ptr = NSTextContentTypeCreditCardFamilyName;
				break;
			case 15: // NSTextContentType.CreditCardGivenName
				ptr = NSTextContentTypeCreditCardGivenName;
				break;
			case 16: // NSTextContentType.CreditCardMiddleName
				ptr = NSTextContentTypeCreditCardMiddleName;
				break;
			case 17: // NSTextContentType.CreditCardName
				ptr = NSTextContentTypeCreditCardName;
				break;
			case 18: // NSTextContentType.CreditCardNumber
				ptr = NSTextContentTypeCreditCardNumber;
				break;
			case 19: // NSTextContentType.CreditCardSecurityCode
				ptr = NSTextContentTypeCreditCardSecurityCode;
				break;
			case 20: // NSTextContentType.CreditCardType
				ptr = NSTextContentTypeCreditCardType;
				break;
			case 21: // NSTextContentType.DateTime
				ptr = NSTextContentTypeDateTime;
				break;
			case 22: // NSTextContentType.EmailAddress
				ptr = NSTextContentTypeEmailAddress;
				break;
			case 23: // NSTextContentType.FamilyName
				ptr = NSTextContentTypeFamilyName;
				break;
			case 24: // NSTextContentType.FlightNumber
				ptr = NSTextContentTypeFlightNumber;
				break;
			case 25: // NSTextContentType.FullStreetAddress
				ptr = NSTextContentTypeFullStreetAddress;
				break;
			case 26: // NSTextContentType.GivenName
				ptr = NSTextContentTypeGivenName;
				break;
			case 27: // NSTextContentType.JobTitle
				ptr = NSTextContentTypeJobTitle;
				break;
			case 28: // NSTextContentType.Location
				ptr = NSTextContentTypeLocation;
				break;
			case 29: // NSTextContentType.MiddleName
				ptr = NSTextContentTypeMiddleName;
				break;
			case 30: // NSTextContentType.Name
				ptr = NSTextContentTypeName;
				break;
			case 31: // NSTextContentType.NamePrefix
				ptr = NSTextContentTypeNamePrefix;
				break;
			case 32: // NSTextContentType.NameSuffix
				ptr = NSTextContentTypeNameSuffix;
				break;
			case 33: // NSTextContentType.NewPassword
				ptr = NSTextContentTypeNewPassword;
				break;
			case 34: // NSTextContentType.Nickname
				ptr = NSTextContentTypeNickname;
				break;
			case 35: // NSTextContentType.OrganizationName
				ptr = NSTextContentTypeOrganizationName;
				break;
			case 36: // NSTextContentType.PostalCode
				ptr = NSTextContentTypePostalCode;
				break;
			case 37: // NSTextContentType.ShipmentTrackingNumber
				ptr = NSTextContentTypeShipmentTrackingNumber;
				break;
			case 38: // NSTextContentType.StreetAddressLine1
				ptr = NSTextContentTypeStreetAddressLine1;
				break;
			case 39: // NSTextContentType.AddressLine2
				ptr = NSTextContentTypeStreetAddressLine2;
				break;
			case 40: // NSTextContentType.Sublocality
				ptr = NSTextContentTypeSublocality;
				break;
			case 41: // NSTextContentType.TelephoneNumber
				ptr = NSTextContentTypeTelephoneNumber;
				break;
			case 42: // NSTextContentType.Url
				ptr = NSTextContentTypeURL;
				break;
			}
			return (NSString?) Runtime.GetNSObject (ptr);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSTextContentType" /> value named by <paramref name="constant" />.</summary>
		/// <param name="constant">The name of the constant to retrieve.</param>
		public static NSTextContentType GetValue (NSString constant)
		{
			if (constant is null)
				throw new ArgumentNullException (nameof (constant));
			if (constant.IsEqualTo (NSTextContentTypeUsername))
				return NSTextContentType.Username;
			if (constant.IsEqualTo (NSTextContentTypePassword))
				return NSTextContentType.Password;
			if (constant.IsEqualTo (NSTextContentTypeOneTimeCode))
				return NSTextContentType.OneTimeCode;
			if (constant.IsEqualTo (NSTextContentTypeAddressCity))
				return NSTextContentType.AddressCity;
			if (constant.IsEqualTo (NSTextContentTypeAddressCityAndState))
				return NSTextContentType.AddressCityAndState;
			if (constant.IsEqualTo (NSTextContentTypeAddressState))
				return NSTextContentType.AddressState;
			if (constant.IsEqualTo (NSTextContentTypeBirthdate))
				return NSTextContentType.Birthdate;
			if (constant.IsEqualTo (NSTextContentTypeBirthdateDay))
				return NSTextContentType.BirthdateDay;
			if (constant.IsEqualTo (NSTextContentTypeBirthdateMonth))
				return NSTextContentType.BirthdateMonth;
			if (constant.IsEqualTo (NSTextContentTypeBirthdateYear))
				return NSTextContentType.BirthdateYear;
			if (constant.IsEqualTo (NSTextContentTypeCountryName))
				return NSTextContentType.CountryName;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardExpiration))
				return NSTextContentType.CreditCardExpiration;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardExpirationMonth))
				return NSTextContentType.CreditCardExpirationMonth;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardExpirationYear))
				return NSTextContentType.CreditCardExpirationYear;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardFamilyName))
				return NSTextContentType.CreditCardFamilyName;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardGivenName))
				return NSTextContentType.CreditCardGivenName;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardMiddleName))
				return NSTextContentType.CreditCardMiddleName;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardName))
				return NSTextContentType.CreditCardName;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardNumber))
				return NSTextContentType.CreditCardNumber;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardSecurityCode))
				return NSTextContentType.CreditCardSecurityCode;
			if (constant.IsEqualTo (NSTextContentTypeCreditCardType))
				return NSTextContentType.CreditCardType;
			if (constant.IsEqualTo (NSTextContentTypeDateTime))
				return NSTextContentType.DateTime;
			if (constant.IsEqualTo (NSTextContentTypeEmailAddress))
				return NSTextContentType.EmailAddress;
			if (constant.IsEqualTo (NSTextContentTypeFamilyName))
				return NSTextContentType.FamilyName;
			if (constant.IsEqualTo (NSTextContentTypeFlightNumber))
				return NSTextContentType.FlightNumber;
			if (constant.IsEqualTo (NSTextContentTypeFullStreetAddress))
				return NSTextContentType.FullStreetAddress;
			if (constant.IsEqualTo (NSTextContentTypeGivenName))
				return NSTextContentType.GivenName;
			if (constant.IsEqualTo (NSTextContentTypeJobTitle))
				return NSTextContentType.JobTitle;
			if (constant.IsEqualTo (NSTextContentTypeLocation))
				return NSTextContentType.Location;
			if (constant.IsEqualTo (NSTextContentTypeMiddleName))
				return NSTextContentType.MiddleName;
			if (constant.IsEqualTo (NSTextContentTypeName))
				return NSTextContentType.Name;
			if (constant.IsEqualTo (NSTextContentTypeNamePrefix))
				return NSTextContentType.NamePrefix;
			if (constant.IsEqualTo (NSTextContentTypeNameSuffix))
				return NSTextContentType.NameSuffix;
			if (constant.IsEqualTo (NSTextContentTypeNewPassword))
				return NSTextContentType.NewPassword;
			if (constant.IsEqualTo (NSTextContentTypeNickname))
				return NSTextContentType.Nickname;
			if (constant.IsEqualTo (NSTextContentTypeOrganizationName))
				return NSTextContentType.OrganizationName;
			if (constant.IsEqualTo (NSTextContentTypePostalCode))
				return NSTextContentType.PostalCode;
			if (constant.IsEqualTo (NSTextContentTypeShipmentTrackingNumber))
				return NSTextContentType.ShipmentTrackingNumber;
			if (constant.IsEqualTo (NSTextContentTypeStreetAddressLine1))
				return NSTextContentType.StreetAddressLine1;
			if (constant.IsEqualTo (NSTextContentTypeStreetAddressLine2))
				return NSTextContentType.AddressLine2;
			if (constant.IsEqualTo (NSTextContentTypeSublocality))
				return NSTextContentType.Sublocality;
			if (constant.IsEqualTo (NSTextContentTypeTelephoneNumber))
				return NSTextContentType.TelephoneNumber;
			if (constant.IsEqualTo (NSTextContentTypeURL))
				return NSTextContentType.Url;
			throw new NotSupportedException ($"{constant} has no associated enum value on this platform.");
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSTextContentType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTextContentType GetValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle)!;
			return GetValue (str);
		}
		/// <summary>Retrieves the <see cref="global::AppKit.NSTextContentType" /> value represented by the backing field value in <paramref name="handle" />.</summary>
		/// <param name="handle">The native handle with the name of the constant to retrieve.</param>
		public static NSTextContentType? GetNullableValue (NativeHandle handle)
		{
			using var str = Runtime.GetNSObject<NSString> (handle);
			if (str is null)
				return null;
			return GetValue (str);
		}
		/// <summary>Converts an array of <see cref="global::AppKit.NSTextContentType" /> enum values into an array of their corresponding constants.</summary>
		/// <param name="values">The array of enum values to convert.</param>
		internal static NSString?[]? ToConstantArray (this NSTextContentType[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSString?> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (value.GetConstant ());
			}
			return rv.ToArray ();
		}
		/// <summary>Converts an array of <see cref="NSString" /> values into an array of their corresponding enum values.</summary>
		/// <param name="values">The array if <see cref="NSString" /> values to convert.</param>
		internal static NSTextContentType[]? ToEnumArray (this NSString[]? values)
		{
			if (values is null)
				return null;
			var rv = new global::System.Collections.Generic.List<NSTextContentType> ();
			for (var i = 0; i < values.Length; i++) {
				var value = values [i];
				rv.Add (GetValue (value));
			}
			return rv.ToArray ();
		}
	}
}
