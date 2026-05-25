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
namespace Accounts {
	/// <summary>An enumeration whose values indicate various errors relating to accessing accounts.</summary><!-- TODO: Confirm that this value is used somewhere -->
	public enum ACErrorCode : int {
		/// <summary>Indicates that an unknown error occurred.</summary>
		Unknown = 1,
		/// <summary>Indicates the the account was not saved because it was missing a required property.</summary>
		AccountMissingRequiredProperty = 2,
		/// <summary>Indicates that the account was not saved because authentication of its credentials failed.</summary>
		AccountAuthenticationFailed = 3,
		/// <summary>Indicates that the account was not saved because it was of an invalid type.</summary>
		AccountTypeInvalid = 4,
		/// <summary>Indicates that an attempt was made to add an account that already exists.</summary>
		AccountAlreadyExits = 5,
		/// <summary>Indicates that the account was not found, and therefore could not be deleted.</summary>
		AccountNotFound = 6,
		/// <summary>Indicates that the application did not have permission to complete the operation.</summary>
		PermissionDenied = 7,
		/// <summary>Indicates that the client access information dictionary is missing values or contains incorrect values.</summary>
		AccessInfoInvalid = 8,
		/// <summary>Indicates that the client was denied permission.</summary>
		ClientPermissionDenied = 9,
		/// <summary>Indicates that the current protection policy stopped the credentials from being fetched.</summary>
		AccessDeniedByProtectionPolicy = 10,
		/// <summary>Indicates that the credential was not found.</summary>
		CredentialNotFound = 11,
		/// <summary>Indicates that the credentials could not be fetched.</summary>
		FetchCredentialFailed = 12,
		/// <summary>Indicates that the credentials were not stored in the Keychain.</summary>
		StoreCredentialFailed = 13,
		/// <summary>Indicates that the credentials could not be removed from the Keychain.</summary>
		RemoveCredentialFailed = 14,
		/// <summary>Indicates that the target account of an updated did not exist.</summary>
		UpdatingNonexistentAccount = 15,
		/// <summary>Indicates that the client did not have a valid bundle identifier.</summary>
		InvalidClientBundleID = 16,
		/// <summary>Indicates that the operation was denied by a plug-in.</summary>
		DeniedByPlugin = 17,
		/// <summary>Indicates that Core Data failed to save the account.</summary>
		CoreDataSaveFailed = 18,
		/// <summary>Indicates that the account information could not be serialized.</summary>
		FailedSerializingAccountInfo = 19,
		/// <summary>Indicates that the command was invalid.</summary>
		InvalidCommand = 20,
		/// <summary>Indicates that the message identifier was missing.</summary>
		MissingTransportMessageId = 21,
		/// <summary>Indicates that the credential item was not found.</summary>
		CredentialItemNotFound = 22,
		/// <summary>Indicates that the credential item wasn't expired.</summary>
		CredentialItemNotExpired = 23,
	}
	/// <summary>Extension methods for the <see cref="global::Accounts.ACErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Accounts.ACErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ACErrorCodeExtensions {
		[Field ("ACErrorDomain", "Accounts")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Accounts.ACErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this ACErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Accounts.Handle, "ACErrorDomain");
			return _domain;
		}
	}
}
