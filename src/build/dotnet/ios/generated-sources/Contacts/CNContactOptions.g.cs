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
	/// <summary>Flagging enumeration that specifies keys that can be checked with <see cref="M:Contacts.CNContact.IsKeyAvailable(Foundation.NSString)" /> and <see cref="Contacts.CNContact.AreKeysAvailable&lt;T&gt;(T[])" />.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Flags]
	public enum CNContactOptions : long {
		/// <summary>To be added.</summary>
		None = 0,
		/// <summary>To be added.</summary>
		Nickname = 1,
		/// <summary>To be added.</summary>
		PhoneticGivenName = 2,
		/// <summary>To be added.</summary>
		PhoneticMiddleName = 4,
		/// <summary>To be added.</summary>
		PhoneticFamilyName = 8,
		/// <summary>To be added.</summary>
		OrganizationName = 16,
		/// <summary>To be added.</summary>
		DepartmentName = 32,
		/// <summary>To be added.</summary>
		JobTitle = 64,
		/// <summary>To be added.</summary>
		Birthday = 128,
		/// <summary>To be added.</summary>
		NonGregorianBirthday = 256,
		/// <summary>To be added.</summary>
		Note = 512,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		ImageData = 1024,
		/// <summary>To be added.</summary>
		ThumbnailImageData = 2048,
		/// <summary>To be added.</summary>
		[UnsupportedOSPlatform ("macos")]
		[SupportedOSPlatform ("maccatalyst")]
		[SupportedOSPlatform ("ios")]
		ImageDataAvailable = 4096,
		/// <summary>To be added.</summary>
		Type = 8192,
		/// <summary>To be added.</summary>
		PhoneNumbers = 16384,
		/// <summary>To be added.</summary>
		EmailAddresses = 32768,
		/// <summary>To be added.</summary>
		PostalAddresses = 65536,
		/// <summary>To be added.</summary>
		Dates = 131072,
		/// <summary>To be added.</summary>
		UrlAddresses = 262144,
		/// <summary>To be added.</summary>
		Relations = 524288,
		/// <summary>To be added.</summary>
		SocialProfiles = 1048576,
		/// <summary>To be added.</summary>
		InstantMessageAddresses = 2097152,
	}
}
