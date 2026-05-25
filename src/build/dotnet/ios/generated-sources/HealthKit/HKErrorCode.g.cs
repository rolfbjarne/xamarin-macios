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
namespace HealthKit {
	/// <summary>Enumerates common errors made when accessing health data.</summary>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum HKErrorCode : long {
		/// <summary>Indicates no error in accessing the data.</summary>
		NoError = 0,
		/// <summary>The requested data is not available.</summary>
		HealthDataUnavailable = 1,
		/// <summary>The data are restricted.</summary>
		HealthDataRestricted = 2,
		/// <summary>There was an error in the arguments to the data-access request.</summary>
		InvalidArgument = 3,
		/// <summary>The app has been denied permission to access the requested data.</summary>
		AuthorizationDenied = 4,
		/// <summary>The user has not yet interacted with the permissions dialog in relation to the current app.</summary>
		AuthorizationNotDetermined = 5,
		/// <summary>The Health Kit datastore is not available.</summary>
		DatabaseInaccessible = 6,
		/// <summary>The user canceled the operation.</summary>
		UserCanceled = 7,
		/// <summary>Indicates that another app started a workout session.</summary>
		AnotherWorkoutSessionStarted = 8,
		/// <summary>Indicates that the user exited the workout session.</summary>
		UserExitedWorkoutSession = 9,
		RequiredAuthorizationDenied = 10,
		NoData = 11,
		WorkoutActivityNotAllowed = 12,
		DataSizeExceeded = 13,
		BackgroundWorkoutSessionNotAllowed = 14,
		NotPermissibleForGuestUserMode = 15,
	}
	/// <summary>Extension methods for the <see cref="global::HealthKit.HKErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::HealthKit.HKErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[SupportedOSPlatform ("macos13.0")]
	[SupportedOSPlatform ("maccatalyst")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class HKErrorCodeExtensions {
		[Field ("HKErrorDomain", "HealthKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the HealthKit.HKErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this HKErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.HealthKit.Handle, "HKErrorDomain");
			return _domain;
		}
	}
}
