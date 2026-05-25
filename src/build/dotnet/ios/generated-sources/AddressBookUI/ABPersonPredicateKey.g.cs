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
namespace AddressBookUI {
	/// <summary>Constants for use with <see cref="T:AddressBookUI.ABPeoplePickerNavigationController" /> predicate methods (<see cref="P:AddressBookUI.ABPeoplePickerNavigationController.PredicateForEnablingPerson" />,
	/// 	<see cref="P:AddressBookUI.ABPeoplePickerNavigationController.PredicateForSelectionOfPerson" />
	/// 	and <see cref="P:AddressBookUI.ABPeoplePickerNavigationController.PredicateForSelectionOfProperty" />).</summary>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[UnsupportedOSPlatform ("maccatalyst")]
	public unsafe static partial class ABPersonPredicateKey  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Birthday;
		/// <summary>Represents the value associated with the constant ABPersonBirthdayProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonBirthdayProperty",  "AddressBookUI")]
		public static NSString Birthday {
			get {
				if (_Birthday is null)
					_Birthday = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonBirthdayProperty")!;
				return _Birthday;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Dates;
		/// <summary>Represents the value associated with the constant ABPersonDatesProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonDatesProperty",  "AddressBookUI")]
		public static NSString Dates {
			get {
				if (_Dates is null)
					_Dates = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonDatesProperty")!;
				return _Dates;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _DepartmentName;
		/// <summary>Represents the value associated with the constant ABPersonDepartmentNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonDepartmentNameProperty",  "AddressBookUI")]
		public static NSString DepartmentName {
			get {
				if (_DepartmentName is null)
					_DepartmentName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonDepartmentNameProperty")!;
				return _DepartmentName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _EmailAddresses;
		/// <summary>Represents the value associated with the constant ABPersonEmailAddressesProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonEmailAddressesProperty",  "AddressBookUI")]
		public static NSString EmailAddresses {
			get {
				if (_EmailAddresses is null)
					_EmailAddresses = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonEmailAddressesProperty")!;
				return _EmailAddresses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _FamilyName;
		/// <summary>Represents the value associated with the constant ABPersonFamilyNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonFamilyNameProperty",  "AddressBookUI")]
		public static NSString FamilyName {
			get {
				if (_FamilyName is null)
					_FamilyName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonFamilyNameProperty")!;
				return _FamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _GivenName;
		/// <summary>Represents the value associated with the constant ABPersonGivenNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonGivenNameProperty",  "AddressBookUI")]
		public static NSString GivenName {
			get {
				if (_GivenName is null)
					_GivenName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonGivenNameProperty")!;
				return _GivenName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _InstantMessageAddresses;
		/// <summary>Represents the value associated with the constant ABPersonInstantMessageAddressesProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonInstantMessageAddressesProperty",  "AddressBookUI")]
		public static NSString InstantMessageAddresses {
			get {
				if (_InstantMessageAddresses is null)
					_InstantMessageAddresses = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonInstantMessageAddressesProperty")!;
				return _InstantMessageAddresses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _JobTitle;
		/// <summary>Represents the value associated with the constant ABPersonJobTitleProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonJobTitleProperty",  "AddressBookUI")]
		public static NSString JobTitle {
			get {
				if (_JobTitle is null)
					_JobTitle = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonJobTitleProperty")!;
				return _JobTitle;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _MiddleName;
		/// <summary>Represents the value associated with the constant ABPersonMiddleNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonMiddleNameProperty",  "AddressBookUI")]
		public static NSString MiddleName {
			get {
				if (_MiddleName is null)
					_MiddleName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonMiddleNameProperty")!;
				return _MiddleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NamePrefix;
		/// <summary>Represents the value associated with the constant ABPersonNamePrefixProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonNamePrefixProperty",  "AddressBookUI")]
		public static NSString NamePrefix {
			get {
				if (_NamePrefix is null)
					_NamePrefix = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonNamePrefixProperty")!;
				return _NamePrefix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _NameSuffix;
		/// <summary>Represents the value associated with the constant ABPersonNameSuffixProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonNameSuffixProperty",  "AddressBookUI")]
		public static NSString NameSuffix {
			get {
				if (_NameSuffix is null)
					_NameSuffix = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonNameSuffixProperty")!;
				return _NameSuffix;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Nickname;
		/// <summary>Represents the value associated with the constant ABPersonNicknameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonNicknameProperty",  "AddressBookUI")]
		public static NSString Nickname {
			get {
				if (_Nickname is null)
					_Nickname = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonNicknameProperty")!;
				return _Nickname;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _Note;
		/// <summary>Represents the value associated with the constant ABPersonNoteProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonNoteProperty",  "AddressBookUI")]
		public static NSString Note {
			get {
				if (_Note is null)
					_Note = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonNoteProperty")!;
				return _Note;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _OrganizationName;
		/// <summary>Represents the value associated with the constant ABPersonOrganizationNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonOrganizationNameProperty",  "AddressBookUI")]
		public static NSString OrganizationName {
			get {
				if (_OrganizationName is null)
					_OrganizationName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonOrganizationNameProperty")!;
				return _OrganizationName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneNumbers;
		/// <summary>Represents the value associated with the constant ABPersonPhoneNumbersProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonPhoneNumbersProperty",  "AddressBookUI")]
		public static NSString PhoneNumbers {
			get {
				if (_PhoneNumbers is null)
					_PhoneNumbers = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonPhoneNumbersProperty")!;
				return _PhoneNumbers;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneticFamilyName;
		/// <summary>Represents the value associated with the constant ABPersonPhoneticFamilyNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonPhoneticFamilyNameProperty",  "AddressBookUI")]
		public static NSString PhoneticFamilyName {
			get {
				if (_PhoneticFamilyName is null)
					_PhoneticFamilyName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonPhoneticFamilyNameProperty")!;
				return _PhoneticFamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneticGivenName;
		/// <summary>Represents the value associated with the constant ABPersonPhoneticGivenNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonPhoneticGivenNameProperty",  "AddressBookUI")]
		public static NSString PhoneticGivenName {
			get {
				if (_PhoneticGivenName is null)
					_PhoneticGivenName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonPhoneticGivenNameProperty")!;
				return _PhoneticGivenName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PhoneticMiddleName;
		/// <summary>Represents the value associated with the constant ABPersonPhoneticMiddleNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonPhoneticMiddleNameProperty",  "AddressBookUI")]
		public static NSString PhoneticMiddleName {
			get {
				if (_PhoneticMiddleName is null)
					_PhoneticMiddleName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonPhoneticMiddleNameProperty")!;
				return _PhoneticMiddleName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PostalAddresses;
		/// <summary>Represents the value associated with the constant ABPersonPostalAddressesProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonPostalAddressesProperty",  "AddressBookUI")]
		public static NSString PostalAddresses {
			get {
				if (_PostalAddresses is null)
					_PostalAddresses = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonPostalAddressesProperty")!;
				return _PostalAddresses;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _PreviousFamilyName;
		/// <summary>Represents the value associated with the constant ABPersonPreviousFamilyNameProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonPreviousFamilyNameProperty",  "AddressBookUI")]
		public static NSString PreviousFamilyName {
			get {
				if (_PreviousFamilyName is null)
					_PreviousFamilyName = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonPreviousFamilyNameProperty")!;
				return _PreviousFamilyName;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _RelatedNames;
		/// <summary>Represents the value associated with the constant ABPersonRelatedNamesProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonRelatedNamesProperty",  "AddressBookUI")]
		public static NSString RelatedNames {
			get {
				if (_RelatedNames is null)
					_RelatedNames = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonRelatedNamesProperty")!;
				return _RelatedNames;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _SocialProfiles;
		/// <summary>Represents the value associated with the constant ABPersonSocialProfilesProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonSocialProfilesProperty",  "AddressBookUI")]
		public static NSString SocialProfiles {
			get {
				if (_SocialProfiles is null)
					_SocialProfiles = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonSocialProfilesProperty")!;
				return _SocialProfiles;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static NSString? _UrlAddresses;
		/// <summary>Represents the value associated with the constant ABPersonUrlAddressesProperty</summary><value></value><remarks>To be added.</remarks>
		[Field ("ABPersonUrlAddressesProperty",  "AddressBookUI")]
		public static NSString UrlAddresses {
			get {
				if (_UrlAddresses is null)
					_UrlAddresses = Dlfcn.GetStringConstant (Libraries.AddressBookUI.Handle, "ABPersonUrlAddressesProperty")!;
				return _UrlAddresses;
			}
		}
	} /* class ABPersonPredicateKey */
}
