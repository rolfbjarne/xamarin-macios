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
namespace AddressBook {
	/// <summary>
	/// The <see cref="T:AddressBook.ABPerson" />
	/// properties.
	/// </summary>
	[ObsoletedOSPlatform ("ios9.0", "Use the 'Contacts' API instead.")]
	[ObsoletedOSPlatform ("maccatalyst13.1", "Use the 'Contacts' API instead.")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("maccatalyst")]
	public enum ABPersonProperty : int {
		/// <summary>
		/// The
		/// <see cref="AddressBook.ABPerson.GetVCards(AddressBook.ABPerson[])" />
		/// multi-value property.
		/// </summary>
		Address = 0,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.Birthday" /> property.
		/// </summary>
		Birthday = 1,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.CreationDate" /> property.
		/// </summary>
		CreationDate = 2,
		/// <summary>
		/// The
		/// <see cref="AddressBook.ABPerson.GetDates" />
		/// multi-value property.
		/// </summary>
		Date = 3,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.Department" /> property.
		/// </summary>
		Department = 4,
		/// <summary>
		/// The
		/// <see cref="AddressBook.ABPerson.GetEmails" />
		/// multi-value property.
		/// </summary>
		Email = 5,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.FirstName" /> property.
		/// </summary>
		FirstName = 6,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.FirstNamePhonetic" /> property.
		/// </summary>
		FirstNamePhonetic = 7,
		/// <summary>
		/// The
		/// <see cref="AddressBook.ABPerson.GetInstantMessageServices" />
		/// multi-value property.
		/// </summary>
		InstantMessage = 8,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.JobTitle" /> property.
		/// </summary>
		JobTitle = 9,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.PersonKind" /> property.
		/// </summary>
		Kind = 10,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.LastName" /> property.
		/// </summary>
		LastName = 11,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.LastNamePhonetic" /> property.
		/// </summary>
		LastNamePhonetic = 12,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.MiddleName" /> property.
		/// </summary>
		MiddleName = 13,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.MiddleNamePhonetic" /> property.
		/// </summary>
		MiddleNamePhonetic = 14,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.ModificationDate" /> property.
		/// </summary>
		ModificationDate = 15,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.Nickname" /> property.
		/// </summary>
		Nickname = 16,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.Note" /> property.
		/// </summary>
		Note = 17,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.Organization" /> property.
		/// </summary>
		Organization = 18,
		/// <summary>
		/// The
		/// <see cref="AddressBook.ABPerson.GetPhones" />
		/// multi-value property.
		/// </summary>
		Phone = 19,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.Prefix" /> property.
		/// </summary>
		Prefix = 20,
		RelatedNames = 21,
		/// <summary>
		/// The <see cref="AddressBook.ABPerson.Suffix" /> property.
		/// </summary>
		Suffix = 22,
		/// <summary>
		/// The
		/// <see cref="AddressBook.ABPerson.GetUrls" />
		/// multi-value property.
		/// </summary>
		Url = 23,
		/// <summary>To be added.</summary>
		SocialProfile = 24,
	}
}
