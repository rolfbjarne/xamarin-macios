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
namespace ARKit {
	/// <summary>Enumerate causes for an <see cref="T:ARKit.ARSession" /> failure.</summary>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[Native]
	public enum ARErrorCode : long {
		/// <summary>The requested <see cref="T:ARKit.ARConfiguration" /> is not compatible with the device.</summary>
		UnsupportedConfiguration = 100,
		/// <summary>A suitable capture device could not be found.</summary>
		SensorUnavailable = 101,
		/// <summary>A failure relating to the capture device(s).</summary>
		SensorFailed = 102,
		/// <summary>Indicates that the user has not allowed access to the camera.</summary>
		CameraUnauthorized = 103,
		MicrophoneUnauthorized = 104,
		LocationUnauthorized = 105,
		HighResolutionFrameCaptureInProgress = 106,
		HighResolutionFrameCaptureFailed = 107,
		/// <summary>A failure relating to world tracking.</summary>
		WorldTrackingFailed = 200,
		GeoTrackingNotAvailableAtLocation = 201,
		GeoTrackingFailed = 202,
		/// <summary>To be added.</summary>
		InvalidReferenceImage = 300,
		/// <summary>To be added.</summary>
		InvalidReferenceObject = 301,
		/// <summary>To be added.</summary>
		InvalidWorldMap = 302,
		/// <summary>To be added.</summary>
		InvalidConfiguration = 303,
		InvalidCollaborationData = 304,
		/// <summary>To be added.</summary>
		InsufficientFeatures = 400,
		/// <summary>To be added.</summary>
		ObjectMergeFailed = 401,
		/// <summary>To be added.</summary>
		FileIOFailed = 500,
		RequestFailed = 501,
	}
	/// <summary>Extension methods for the <see cref="global::ARKit.ARErrorCode" /> enumeration.</summary>
	/// <remarks>
	///   <para>The extension method for the <see cref="global::ARKit.ARErrorCode" /> enumeration can be used to fetch the error domain associated with these error codes.</para>
	/// </remarks>
	[UnsupportedOSPlatform ("tvos")]
	[UnsupportedOSPlatform ("macos")]
	[SupportedOSPlatform ("ios")]
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static public partial class ARErrorCodeExtensions {
		[Field ("ARErrorDomain", "ARKit")]
		static NSString? _domain;
		/// <summary>Returns the error domain associated with the ARKit.ARErrorCode value</summary>
		/// <param name="self">The enumeration value</param>
		/// <remarks>
		///   <para>See the <see cref="global::Foundation.NSError" /> for information on how to use the error domains when reporting errors.</para>
		/// </remarks>
		public static NSString? GetDomain (this ARErrorCode self)
		{
			if (_domain is null)
				_domain = Dlfcn.GetStringConstant (Libraries.ARKit.Handle, "ARErrorDomain");
			return _domain;
		}
	}
}
