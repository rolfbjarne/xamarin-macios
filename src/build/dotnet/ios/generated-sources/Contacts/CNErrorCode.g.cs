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
	/// <summary>Enumerates kinds of error encountered while working with contacts.</summary>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum CNErrorCode : long {
		/// <summary>An error occurred at the transport level.</summary>
		CommunicationError = 1,
		/// <summary>An error occurred while trying to access the data.</summary>
		DataAccessError = 2,
		/// <summary>The user has denied the app access to their contacts.</summary>
		AuthorizationDenied = 100,
		/// <summary>To be added.</summary>
		NoAccessibleWritableContainers = 101,
		UnauthorizedKeys = 102,
		FeatureDisabledByUser = 103,
		FeatureNotAvailable = 104,
		/// <summary>The <see cref="T:Contacts.CNContact" /> does not exist.</summary>
		RecordDoesNotExist = 200,
		/// <summary>The inserted record is a duplicate.</summary>
		InsertedRecordAlreadyExists = 201,
		/// <summary>Code containment cycle error.</summary>
		ContainmentCycle = 202,
		/// <summary>Code containment scope error.</summary>
		ContainmentScope = 203,
		/// <summary>The <see cref="T:Contacts.CNContact" /> does not exist.</summary>
		ParentRecordDoesNotExist = 204,
		/// <summary>To be added.</summary>
		RecordIdentifierInvalid = 205,
		RecordNotWritable = 206,
		ParentContainerNotWritable = 207,
		/// <summary>Multiple errors occurred relating to validation.</summary>
		ValidationMultipleErrors = 300,
		/// <summary>There was a type mismatch during validation.</summary>
		ValidationTypeMismatch = 301,
		/// <summary>The validation attempt was misconfigured.</summary>
		ValidationConfigurationError = 302,
		/// <summary>The <see cref="T:Foundation.NSPredicate" /> is invalid.</summary>
		PredicateInvalid = 400,
		/// <summary>A policy validation error.</summary>
		PolicyViolation = 500,
		/// <summary>To be added.</summary>
		ClientIdentifierInvalid = 600,
		/// <summary>To be added.</summary>
		ClientIdentifierDoesNotExist = 601,
		ClientIdentifierCollision = 602,
		ChangeHistoryExpired = 603,
		ChangeHistoryInvalidAnchor = 604,
		ChangeHistoryInvalidFetchRequest = 605,
		/// <summary>To be added.</summary>
		VCardMalformed = 700,
		/// <summary>To be added.</summary>
		VCardSummarizationError = 701,
	}
	/// <summary>Extension methods for the <see cref="global::Contacts.CNErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Contacts.CNErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class CNErrorCodeExtensions {
		[Field ("CNErrorDomain", "Contacts")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Contacts.CNErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this CNErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Contacts.Handle, "CNErrorDomain");
			return _domain;
		}
	}
}
