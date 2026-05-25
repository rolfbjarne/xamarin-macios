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
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Security;
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
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
namespace Intents {
	/// <summary>Enumerates errors associated with Intents / SiriKit.</summary><remarks>To be added.</remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[Native]
	public enum INIntentErrorCode : long {
		/// <summary>The interaction could not be donated or deleted because the device does not support the behavior.</summary>
		InteractionOperationNotSupported = 1900,
		/// <summary>An error occurred while donating an interaction.</summary>
		DonatingInteraction = 1901,
		/// <summary>An error occurred when attempting to delete all interactions.</summary>
		DeletingAllInteractions = 1902,
		/// <summary>An error occurred when attempting to delete specific interactions.</summary>
		DeletingInteractionWithIdentifiers = 1903,
		/// <summary>An error occurred when attempting to delete grouped interactions.</summary>
		DeletingInteractionWithGroupIdentifier = 1904,
		/// <summary>The app has multiple extensions attempting to handle the same intent.</summary>
		IntentSupportedByMultipleExtension = 2001,
		/// <summary>There is at least one intent in the info.plist <c>IntentsRestrictedWhileLocked</c> list that is not in the file's <c>IntentsSupported</c> list.</summary>
		RestrictedIntentsNotSupportedByExtension = 2002,
		/// <summary>The info.plist contains intents for which the app does not provide an extension.</summary>
		NoHandlerProvidedForIntent = 2003,
		/// <summary>The extension's intent does not match the intent names provided in info.plist.</summary>
		InvalidIntentName = 2004,
		/// <summary>To be added.</summary>
		NoAppAvailable = 2005,
		/// <summary>Too much time has elapsed for the underlying request.</summary>
		RequestTimedOut = 3001,
		/// <summary>To be added.</summary>
		MissingInformation = 3002,
		/// <summary>The user vocabulary file is not at the specified location.</summary>
		InvalidUserVocabularyFileLocation = 4000,
		/// <summary>The extension timed out.</summary>
		ExtensionLaunchingTimeout = 5000,
		/// <summary>An error occurred while trying to start communication with an extension.</summary>
		ExtensionBringUpFailed = 5001,
		/// <summary>To be added.</summary>
		ImageGeneric = 6000,
		/// <summary>To be added.</summary>
		ImageNoServiceAvailable = 6001,
		/// <summary>To be added.</summary>
		ImageStorageFailed = 6002,
		/// <summary>To be added.</summary>
		ImageLoadingFailed = 6003,
		/// <summary>To be added.</summary>
		ImageRetrievalFailed = 6004,
		/// <summary>To be added.</summary>
		ImageProxyLoop = 6005,
		/// <summary>To be added.</summary>
		ImageProxyInvalid = 6006,
		/// <summary>To be added.</summary>
		ImageProxyTimeout = 6007,
		/// <summary>To be added.</summary>
		ImageServiceFailure = 6008,
		/// <summary>To be added.</summary>
		ImageScalingFailed = 6009,
		/// <summary>To be added.</summary>
		PermissionDenied = 6010,
		/// <summary>To be added.</summary>
		VoiceShortcutCreationFailed = 7000,
		/// <summary>To be added.</summary>
		VoiceShortcutGetFailed = 7001,
		/// <summary>To be added.</summary>
		VoiceShortcutDeleteFailed = 7002,
		/// <summary>To be added.</summary>
		EncodingGeneric = 8000,
		/// <summary>To be added.</summary>
		EncodingFailed = 8001,
		/// <summary>To be added.</summary>
		DecodingGeneric = 9000,
		UnableToCreateAppIntentRepresentation = 10000,
		NoAppIntent = 10001,
	}
	/// <summary>Extension methods for the <see cref="global::Intents.INIntentErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::Intents.INIntentErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("tvos14.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[SupportedOSPlatform ("macos")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class INIntentErrorCodeExtensions {
		[Field ("INIntentErrorDomain", "Intents")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the Intents.INIntentErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this INIntentErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.Intents.Handle, "INIntentErrorDomain");
			return _domain;
		}
	}
}
