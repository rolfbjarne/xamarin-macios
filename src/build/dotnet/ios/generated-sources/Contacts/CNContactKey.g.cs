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
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
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
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Contacts {
	/// <summary>Provides string constants whose values are the names of the possibly-available keys for <see cref="T:Contacts.CNContact" /> objects.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[EditorBrowsable (EditorBrowsableState.Never)]
	public unsafe static partial class CNContactKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Birthday;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.Birthday" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactBirthdayKey",  "Contacts")]
		public static NSString Birthday {
			get {
				if (_Birthday is null)
					_Birthday = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactBirthdayKey")!;
				return _Birthday;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Dates;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.Dates" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactDatesKey",  "Contacts")]
		public static NSString Dates {
			get {
				if (_Dates is null)
					_Dates = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactDatesKey")!;
				return _Dates;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DepartmentName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.DepartmentName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactDepartmentNameKey",  "Contacts")]
		public static NSString DepartmentName {
			get {
				if (_DepartmentName is null)
					_DepartmentName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactDepartmentNameKey")!;
				return _DepartmentName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmailAddresses;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.EmailAddresses" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactEmailAddressesKey",  "Contacts")]
		public static NSString EmailAddresses {
			get {
				if (_EmailAddresses is null)
					_EmailAddresses = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactEmailAddressesKey")!;
				return _EmailAddresses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FamilyName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.FamilyName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactFamilyNameKey",  "Contacts")]
		public static NSString FamilyName {
			get {
				if (_FamilyName is null)
					_FamilyName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactFamilyNameKey")!;
				return _FamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GivenName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.GivenName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactGivenNameKey",  "Contacts")]
		public static NSString GivenName {
			get {
				if (_GivenName is null)
					_GivenName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactGivenNameKey")!;
				return _GivenName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Identifier;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.Identifier" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactIdentifierKey",  "Contacts")]
		public static NSString Identifier {
			get {
				if (_Identifier is null)
					_Identifier = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactIdentifierKey")!;
				return _Identifier;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageData;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.ImageData" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactImageDataKey",  "Contacts")]
		public static NSString ImageData {
			get {
				if (_ImageData is null)
					_ImageData = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactImageDataKey")!;
				return _ImageData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ImageDataAvailable;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.ImageDataAvailable" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactImageDataAvailableKey",  "Contacts")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString ImageDataAvailable {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_ImageDataAvailable is null)
					_ImageDataAvailable = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactImageDataAvailableKey")!;
				return _ImageDataAvailable;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InstantMessageAddresses;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.InstantMessageAddresses" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactInstantMessageAddressesKey",  "Contacts")]
		public static NSString InstantMessageAddresses {
			get {
				if (_InstantMessageAddresses is null)
					_InstantMessageAddresses = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactInstantMessageAddressesKey")!;
				return _InstantMessageAddresses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JobTitle;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.JobTitle" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactJobTitleKey",  "Contacts")]
		public static NSString JobTitle {
			get {
				if (_JobTitle is null)
					_JobTitle = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactJobTitleKey")!;
				return _JobTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MiddleName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.MiddleName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactMiddleNameKey",  "Contacts")]
		public static NSString MiddleName {
			get {
				if (_MiddleName is null)
					_MiddleName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactMiddleNameKey")!;
				return _MiddleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NamePrefix;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.NamePrefix" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactNamePrefixKey",  "Contacts")]
		public static NSString NamePrefix {
			get {
				if (_NamePrefix is null)
					_NamePrefix = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactNamePrefixKey")!;
				return _NamePrefix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameSuffix;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.NameSuffix" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactNameSuffixKey",  "Contacts")]
		public static NSString NameSuffix {
			get {
				if (_NameSuffix is null)
					_NameSuffix = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactNameSuffixKey")!;
				return _NameSuffix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Nickname;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.Nickname" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactNicknameKey",  "Contacts")]
		public static NSString Nickname {
			get {
				if (_Nickname is null)
					_Nickname = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactNicknameKey")!;
				return _Nickname;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NonGregorianBirthday;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.NonGregorianBirthday" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactNonGregorianBirthdayKey",  "Contacts")]
		public static NSString NonGregorianBirthday {
			get {
				if (_NonGregorianBirthday is null)
					_NonGregorianBirthday = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactNonGregorianBirthdayKey")!;
				return _NonGregorianBirthday;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Note;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.Note" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactNoteKey",  "Contacts")]
		public static NSString Note {
			get {
				if (_Note is null)
					_Note = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactNoteKey")!;
				return _Note;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrganizationName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.OrganizationName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactOrganizationNameKey",  "Contacts")]
		public static NSString OrganizationName {
			get {
				if (_OrganizationName is null)
					_OrganizationName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactOrganizationNameKey")!;
				return _OrganizationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneNumbers;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.PhoneNumbers" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactPhoneNumbersKey",  "Contacts")]
		public static NSString PhoneNumbers {
			get {
				if (_PhoneNumbers is null)
					_PhoneNumbers = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactPhoneNumbersKey")!;
				return _PhoneNumbers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneticFamilyName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.PhoneticFamilyName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactPhoneticFamilyNameKey",  "Contacts")]
		public static NSString PhoneticFamilyName {
			get {
				if (_PhoneticFamilyName is null)
					_PhoneticFamilyName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactPhoneticFamilyNameKey")!;
				return _PhoneticFamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneticGivenName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.PhoneticGivenName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactPhoneticGivenNameKey",  "Contacts")]
		public static NSString PhoneticGivenName {
			get {
				if (_PhoneticGivenName is null)
					_PhoneticGivenName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactPhoneticGivenNameKey")!;
				return _PhoneticGivenName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneticMiddleName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.PhoneticMiddleName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactPhoneticMiddleNameKey",  "Contacts")]
		public static NSString PhoneticMiddleName {
			get {
				if (_PhoneticMiddleName is null)
					_PhoneticMiddleName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactPhoneticMiddleNameKey")!;
				return _PhoneticMiddleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneticOrganizationName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.PhoneticOrganizationName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactPhoneticOrganizationNameKey",  "Contacts")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		[SupportedOSPlatform ("macos")]
		public static NSString PhoneticOrganizationName {
			[SupportedOSPlatform ("maccatalyst")]
			[SupportedOSPlatform ("ios")]
			[SupportedOSPlatform ("macos")]
			get {
				if (_PhoneticOrganizationName is null)
					_PhoneticOrganizationName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactPhoneticOrganizationNameKey")!;
				return _PhoneticOrganizationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostalAddresses;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.PostalAddresses" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactPostalAddressesKey",  "Contacts")]
		public static NSString PostalAddresses {
			get {
				if (_PostalAddresses is null)
					_PostalAddresses = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactPostalAddressesKey")!;
				return _PostalAddresses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreviousFamilyName;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.PreviousFamilyName" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactPreviousFamilyNameKey",  "Contacts")]
		public static NSString PreviousFamilyName {
			get {
				if (_PreviousFamilyName is null)
					_PreviousFamilyName = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactPreviousFamilyNameKey")!;
				return _PreviousFamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Relations;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.ContactRelations" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactRelationsKey",  "Contacts")]
		public static NSString Relations {
			get {
				if (_Relations is null)
					_Relations = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactRelationsKey")!;
				return _Relations;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocialProfiles;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.SocialProfiles" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactSocialProfilesKey",  "Contacts")]
		public static NSString SocialProfiles {
			get {
				if (_SocialProfiles is null)
					_SocialProfiles = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactSocialProfilesKey")!;
				return _SocialProfiles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _ThumbnailImageData;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.ThumbnailImageData" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactThumbnailImageDataKey",  "Contacts")]
		public static NSString ThumbnailImageData {
			get {
				if (_ThumbnailImageData is null)
					_ThumbnailImageData = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactThumbnailImageDataKey")!;
				return _ThumbnailImageData;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Type;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.ContactType" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactTypeKey",  "Contacts")]
		public static NSString Type {
			get {
				if (_Type is null)
					_Type = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactTypeKey")!;
				return _Type;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UrlAddresses;
		/// <summary>Key identifying the <see cref="P:Contacts.CNContact.UrlAddresses" /> property.</summary><value>To be added.</value><remarks>To be added.</remarks>
		[Field ("CNContactUrlAddressesKey",  "Contacts")]
		public static NSString UrlAddresses {
			get {
				if (_UrlAddresses is null)
					_UrlAddresses = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNContactUrlAddressesKey")!;
				return _UrlAddresses;
			}
		}
	} /* class CNContactKey */
}
